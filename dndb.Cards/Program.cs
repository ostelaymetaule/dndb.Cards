using dndb.Cards.Parser;
using System;

namespace dndb.Cards
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
           
            
            string url = @"https://ddb.ac/characters/7577901/EwYJYR";
            var parser = new CharacterLoader("sampleCampaign");
            await parser.LoadSingleCharacterCardAsync(url);

 
        }
    }
}
