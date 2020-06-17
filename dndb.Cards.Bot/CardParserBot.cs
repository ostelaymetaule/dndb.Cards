using dndb.Cards.Parser;
using dndb.Cards.Pdf;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace dndb.Cards.Bot
{
    public class CardParserBot
    {
        private ITelegramBotClient _botClient;
        private ConcurrentDictionary<long, List<string>> _chatMessages;
        private ConcurrentDictionary<long, List<string>> _chatDocuments;

        private PdfCombiner _pdfCombiner;
        private CharacterLoader _charLoader;
        private ImageModification _imgMod;
        public CardParserBot(string token)
        {
            _pdfCombiner = new PdfCombiner();
            _charLoader = new CharacterLoader();
            _imgMod = new ImageModification();

            _chatMessages = new ConcurrentDictionary<long, List<string>>();
            _chatDocuments = new ConcurrentDictionary<long, List<string>>();
            _botClient = new TelegramBotClient(token);
            Console.WriteLine($"bot will run until {TimeSpan.MaxValue.TotalDays.ToString()}");

            _botClient.OnMessage += Bot_OnMessage;
            _botClient.OnCallbackQuery += _botClient_OnCallbackQueryAsync;
            _botClient.StartReceiving();

            while (true)
            {
                Console.WriteLine($"bot working");

                Thread.Sleep(100000);
            }

        }

        private async void _botClient_OnCallbackQueryAsync(object sender, CallbackQueryEventArgs e)
        {
            var messageText = e.CallbackQuery.Message.Text;
            var replyData = e.CallbackQuery.Data;
            var chat = e.CallbackQuery.Message.Chat;
            if (messageText != null && replyData == "Generare Pdf")
            {
                await Task.Run(async () => await ProcessPdf(chat));
            }
        }

        private async Task ProcessPdf(Chat chat)
        {
            Console.WriteLine($"Received a CallbackQuery message for PDF generation in chat  {chat.Id}.");


            await _botClient.SendTextMessageAsync(
              chatId: chat,
              text: "Starting generating your pdf, please wait."
            );

            List<string> urlsFromMemmory;
            _chatMessages.TryGetValue(chat.Id, out urlsFromMemmory);

            List<string> fileIdsFromMemmory;
            _chatDocuments.TryGetValue(chat.Id, out fileIdsFromMemmory);
            List<Stream> downloadedImages = new List<Stream>();
            List<Stream> downloadedDocumentImages = new List<Stream>();
            List<Stream> listOfStreatchedImages = new List<Stream>();
            if (fileIdsFromMemmory.Any())
            {
                await _botClient.SendTextMessageAsync(
                 chatId: chat,
                 text: "downloading file images"
               );

                foreach (var fileId in fileIdsFromMemmory)
                {
                    Console.WriteLine("Downloading a document " + fileId);
                    await _botClient.SendTextMessageAsync(
                       chatId: chat,
                       text: "Downloading " + string.Concat(fileId)
                     );
                    var fileStream = new MemoryStream();
                    var fileDownloaded = await _botClient.GetInfoAndDownloadFileAsync(fileId, fileStream);

                    downloadedDocumentImages.Add(fileStream);
                }
            }
            if (urlsFromMemmory != null && urlsFromMemmory.Any())
                {
                await _botClient.SendTextMessageAsync(
              chatId: chat,
              text: String.Join(", ", urlsFromMemmory.Select(x => string.Concat(x.TakeLast(6))))
            );

                await _botClient.SendTextMessageAsync(
                  chatId: chat,
                  text: "downloading OG images"
                );

                foreach (var url in urlsFromMemmory)
                {
                    Console.WriteLine("Downloading and parsing OG Card from " + url);
                    await _botClient.SendTextMessageAsync(
                       chatId: chat,
                       text: "Downloading " + string.Concat(url.TakeLast(6))
                     );
                    var freshImage = await _charLoader.LoadSingleCharacterCardAsync(url);
                    //waiting some time before trying next image
                    Thread.Sleep(5000);
                    downloadedImages.Add(freshImage);
                }
                await _botClient.SendTextMessageAsync(
              chatId: chat,
              text: "cutting and rearranging images"
            );

                listOfStreatchedImages = downloadedImages
                     .Select(x =>
                         _imgMod.StretchCharCard(x)
                     ).ToList();

                await _botClient.SendTextMessageAsync(
                 chatId: chat,
                 text: "generating pdf"
               );
            }


            //listOfStreatchedImages.AddRange(downloadedDocumentImages);
            var outputDoc = _pdfCombiner.Combine(listOfStreatchedImages, downloadedDocumentImages);

            await _botClient.SendDocumentAsync(
              chatId: chat,
              new Telegram.Bot.Types.InputFiles.InputOnlineFile(outputDoc, "combinedStretchedCards.pdf")
            );
            listOfStreatchedImages.ForEach(x => x.Close());
            downloadedImages.ForEach(x => x.Close());
            outputDoc.Close();


            downloadedDocumentImages.ForEach(x => x.Close());

            FlushUrlFromMemory(chat.Id);
        }

        private async void AskButtonWithCallBack(long chatId, string qustionText, List<string> options)
        {
            var keyboard = new InlineKeyboardMarkup(options.Select(x => new[] { new InlineKeyboardButton() { Text = x, CallbackData = x } }).ToArray());

            await _botClient.SendTextMessageAsync(chatId, qustionText,
                replyMarkup: keyboard);
        }
        void SaveUrlToMemory(long id, string text)
        {

            List<string> previousMessages;
            previousMessages = new List<string> { text };
            _chatMessages.AddOrUpdate(id, previousMessages, (key, oldValue) => { oldValue.Add(text); return oldValue; });

        }
        void SaveDocumentToMemory(long id, string fileId)
        {

            List<string> previousMessages;
            previousMessages = new List<string> { fileId };
            _chatDocuments.AddOrUpdate(id, previousMessages, (key, oldValue) => { oldValue.Add(fileId); return oldValue; });

        }
        void FlushUrlFromMemory(long id)
        {
            if (_chatMessages.ContainsKey(id))
            {
                _chatMessages[id].Clear();
            }
        }


        private async void Bot_OnMessage(object sender, MessageEventArgs e)
        {

            Console.WriteLine($"Received a text message in chat {e.Message.Chat.Id}.");

            //Validate the send text is a URL to DDB
            if ((e.Message.Text != null) && ValidateAndSaveDdbUrl(e.Message.Chat.Id, e.Message.Text))
            {
                AskButtonWithCallBack(e.Message.Chat.Id, "Generate pdf or send more links?", new List<string>() { "Generare Pdf" });
            }
            else if (ValidateAndSaveImage(e.Message.Chat.Id, e.Message.Document))
            {

                await _botClient.SendTextMessageAsync(
                 chatId: e.Message.Chat,
                 text: $"You send a document, hopefully an png image. well put it near the cards",
                 parseMode: ParseMode.Html,
                 disableWebPagePreview: true
                 );
                AskButtonWithCallBack(e.Message.Chat.Id, "Generate pdf or send more?", new List<string>() { "Generare Pdf" });
            }
            else
            {
                await _botClient.SendTextMessageAsync(
                 chatId: e.Message.Chat,
                 text: $"Hallo there, can you please send a valid Shareable link from dndbeyond.com, which you can access via the drop down menu beside your character portrait. The right link looks like https://ddb.ac/characters/20536107/VuZtzz and is accesable via character portrait dropdown menu",
                 parseMode: ParseMode.Html,
                 disableWebPagePreview: true
                 );
            }

        }

        private bool ValidateAndSaveImage(long id, Document photo)
        {
            if (photo != null)
            {
                var fileId = photo.FileId;
                SaveDocumentToMemory(id, fileId);
                return true;
            }

            return false;
        }

        /// <summary>
        /// validate if the url looks like https://ddb.ac/characters/20536107/VuZtzz
        /// </summary>
        /// <param name="text"></param>
        private bool ValidateAndSaveDdbUrl(long chatId, string url)
        {
            if (url.StartsWith("ddb.ac/characters/"))
            {
                url = "https://" + url;
            }
            bool startsWithDdb = url.StartsWith("https://ddb.ac/characters/");
            var splittedUrl = url.Split("/");
            var lastElement = splittedUrl.Last();
            bool isDdbShareableLink = false;
            if (!String.IsNullOrEmpty(lastElement))
            {
                isDdbShareableLink = lastElement.ToCharArray().All(x => Char.IsLetterOrDigit(x));
            }

            if (startsWithDdb && isDdbShareableLink)
            {
                SaveUrlToMemory(chatId, url);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
