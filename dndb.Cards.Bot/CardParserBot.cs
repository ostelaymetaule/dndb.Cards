using System;
using System.Threading;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace dndb.Cards.Bot
{
    public class CardParserBot
    {
        private ITelegramBotClient _botClient;


        public CardParserBot(string token)
        {
            _botClient = new TelegramBotClient(token);

            var me = _botClient.GetMeAsync().Result;
            Console.WriteLine(
              $"Hello, World! I am user {me.Id} and my name is {me.FirstName}."
            );

            _botClient.OnMessage += Bot_OnMessage;
            _botClient.StartReceiving();
            Thread.Sleep(int.MaxValue);


        }

        private async void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            if (e.Message.Text != null)
            {
                Console.WriteLine($"Received a text message in chat {e.Message.Chat.Id}.");

                await _botClient.SendTextMessageAsync(
                  chatId: e.Message.Chat,
                  text: "You said:\n" + e.Message.Text
                );
            }
        }
    }
}
