using System;

namespace dndb.Cards.Bot
{
    class Program
    {

        static void Main(string[] args)
        {
            
            Console.WriteLine("starting bot!");
            string token = "";
            var myBotListner = new CardParserBot(token);


           
            Console.WriteLine("ending bot");

        }

       
    }
}
