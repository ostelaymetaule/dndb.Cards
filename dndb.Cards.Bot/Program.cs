using System;

namespace dndb.Cards.Bot
{
    class Program
    {

        static void Main(string[] args)
        {
            
            Console.WriteLine("starting bot!");
            string token = "1004803078:AAF-GFggKCPeVxIyUS94L3mbP3xohkPxiFU";
            var myBotListner = new CardParserBot(token);


           
            Console.WriteLine("ending bot");

        }

       
    }
}
