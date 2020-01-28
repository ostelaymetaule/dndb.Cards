using dndb.Cards.Parser;
using dndb.Cards.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.ReplyMarkups;

namespace dndb.Cards.Bot
{
    public class CardParserBot
    {
        private ITelegramBotClient _botClient;
        private IDictionary<long, List<string>> _chatMessages;
        private PdfCombiner _pdfCombiner;
        private CharacterLoader _charLoader;
        private ImageModification _imgMod;
        public CardParserBot(string token)
        {
            _pdfCombiner = new PdfCombiner();
            _charLoader = new CharacterLoader();
            _imgMod = new ImageModification();

            _chatMessages = new Dictionary<long, List<string>>();
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
            if (messageText != null && replyData == "Generare Pdf")
            {
                Console.WriteLine($"Received a CallbackQuery message for PDF generation in chat  {e.CallbackQuery.Message.Chat.Id}.");


                await _botClient.SendTextMessageAsync(
                  chatId: e.CallbackQuery.Message.Chat,
                  text: "Starting generating your pdf, please wait."
                );




                List<string> urlsFromMemmory;
                _chatMessages.TryGetValue(e.CallbackQuery.Message.Chat.Id, out urlsFromMemmory);

                if (urlsFromMemmory != null && urlsFromMemmory.Any())
                {
                    await _botClient.SendTextMessageAsync(
                      chatId: e.CallbackQuery.Message.Chat,
                      text: String.Join(", ", urlsFromMemmory.Select(x=>x.TakeLast(6)))
                    );

                    await _botClient.SendTextMessageAsync(
                      chatId: e.CallbackQuery.Message.Chat,
                      text: "downloading OG images"
                    );
                    List<Stream> downloadedImages = new List<Stream>();

                    foreach (var url in urlsFromMemmory)
                    {
                        Console.WriteLine("Downloading and parsing OG Card from " + url);
                        await _botClient.SendTextMessageAsync(
                           chatId: e.CallbackQuery.Message.Chat,
                           text: "Downloading " + url.TakeLast(6)
                         ); ;
                        var freshImage = await _charLoader.LoadSingleCharacterCardAsync(url);
                        Thread.Sleep(1000);
                        downloadedImages.Add(freshImage);
                    }

                    await _botClient.SendTextMessageAsync(
                        chatId: e.CallbackQuery.Message.Chat,
                        text: "cutting and rearranging images"
                      );

                    var listOfStreatchedImages = downloadedImages
                         .Select(x =>
                             _imgMod.StretchCharCard(x)
                         ).ToList();

                    await _botClient.SendTextMessageAsync(
                     chatId: e.CallbackQuery.Message.Chat,
                     text: "generating pdf"
                   );

                    var outputDoc = _pdfCombiner.Combine(listOfStreatchedImages);

                    await _botClient.SendDocumentAsync(
                      chatId: e.CallbackQuery.Message.Chat,
                      new Telegram.Bot.Types.InputFiles.InputOnlineFile(outputDoc, "combinedStretchedCards.pdf")
                    );
                    listOfStreatchedImages.ForEach(x => x.Dispose());
                    downloadedImages.ForEach(x => x.Dispose());
                    outputDoc.Dispose();
                }


                FlushUrlFromMemory(e.CallbackQuery.Message.Chat.Id);

            }
        }
        private async void AskButtonWithCallBack(long chatId, string qustionText, List<string> options)
        {
            var keyboard = new InlineKeyboardMarkup(options.Select(x => new[] { new InlineKeyboardButton() { Text = x, CallbackData = x } }).ToArray());

            await _botClient.SendTextMessageAsync(chatId, qustionText,
                replyMarkup: keyboard);
        }
        void SaveUrlToMemory(long id, string text)
        {
            if (_chatMessages.ContainsKey(id))
            {
                _chatMessages[id].Add(text);
            }
            else
            {
                List<string> previousMessages;
                previousMessages = new List<string> { text };
                _chatMessages.Add(id, previousMessages);
            }
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
            if (e.Message.Text != null)
            {
                Console.WriteLine($"Received a text message in chat {e.Message.Chat.Id}.");

                //Validate the send text is a URL to DDB
                if (ValidateAndSaveDdbUrl(e.Message.Chat.Id, e.Message.Text))
                {

                }
                else
                {
                    await _botClient.SendTextMessageAsync(
                     chatId: e.Message.Chat,
                     text: $"You sending:\n{e.Message.Text}\n which is not a valid Shareable link from DDB. The right link looks like ```https://ddb.ac/characters/20536107/VuZtzz``` and is accesable via character portrait dropdown menu"
                   );
                }

                AskButtonWithCallBack(e.Message.Chat.Id, "Generate pdf or send more links?", new List<string>() { "Generare Pdf" });
            }
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
