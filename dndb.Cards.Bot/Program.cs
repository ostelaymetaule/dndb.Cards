using System;

namespace dndb.Cards.Bot
{
    class Program
    {

        static void Main(string[] args)
        {
            var token = Environment.GetEnvironmentVariable("BotToken");
            if (string.IsNullOrEmpty(token))
            {
                Console.WriteLine("Token cant be null or empty, please set BotToken env variable");
                return;
            }
            Console.WriteLine("starting bot!");
            var myBotListner = new CardParserBot(token);

            Console.WriteLine("ending bot");
        }
    }
}
