using dndb.Cards.Parser;
using System;
using System.Linq;

namespace dndb.Cards
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            if (args.Any())
            {
                var url = args.FirstOrDefault();
                var parser = new CharacterLoader("sampleCampaign");
                await parser.LoadSingleCharacterCardAsync(url);

                var imgMod = new ImageModification();

                parser.GetDownloadedImagePaths()
                    .ForEach(x =>
                        imgMod.StretchCharCard(x)
                    );
            }
            else
            {
                System.Console.WriteLine("please give a url to the character shareble link, f.Ex.: https://ddb.ac/characters/7577901/EwYJYR");
            }
        }
    }
}
