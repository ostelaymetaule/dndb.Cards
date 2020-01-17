using dndb.Cards.Parser;
using dndb.Cards.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dndb.Cards
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            // if (args.Any())
            //

            //{
            //var url = args.FirstOrDefault();
            var urlList = new List<string>()
            {
                "https://ddb.ac/characters/21830852/JroTgS",
                "https://ddb.ac/characters/20456033/JdxJk9",
                "https://ddb.ac/characters/20534054/y4UlXq",
                "https://ddb.ac/characters/20650459/LMArhd",
                "https://ddb.ac/characters/20483591/Q6XKZk"

            };
            var parser = new CharacterLoader("sampleCampaign");
            foreach (var url in urlList)
            {
                await parser.LoadSingleCharacterCardAsync(url);
            }

            var imgMod = new ImageModification();

            var listOfStreatchedImages = parser.GetDownloadedImagePaths()
                 .Select(x =>
                     imgMod.StretchCharCard(x)
                 ).ToList();

            var pdfCombiner = new PdfCombiner();

            pdfCombiner.Combine(listOfStreatchedImages);

            //}
            //else
            //{
            //    System.Console.WriteLine("please give a url to the character shareble link, f.Ex.: https://ddb.ac/characters/7577901/EwYJYR");
            //}
        }
    }
}
