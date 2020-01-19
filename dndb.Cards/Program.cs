using dndb.Cards.Parser;
using dndb.Cards.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace dndb.Cards
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            if (args.Any())


            {


                var fileUrl = args.FirstOrDefault();
                Console.WriteLine("File path given: " + fileUrl);
                if (!File.Exists(fileUrl))
                {
                    Console.WriteLine("File not found");
                    Console.ReadLine();
                    return;
                }
                
                var urlList = File.ReadAllLines(fileUrl).ToList();

                Console.WriteLine("found following links in the file:");
                urlList.ForEach(url => Console.WriteLine(url));
                
                var parser = new CharacterLoader("sampleCampaign");
                foreach (var url in urlList)
                {
                    Console.WriteLine("Downloading and parsing OG Card from " + url);

                    await parser.LoadSingleCharacterCardAsync(url);
                }

                var imgMod = new ImageModification();
                var listOfImages = parser.GetDownloadedImagePaths();

                var listOfStreatchedImages = listOfImages
                     .Select(x =>
                         imgMod.StretchCharCard(x)
                     ).ToList();

                var pdfCombiner = new PdfCombiner();

                var outputPath = pdfCombiner.Combine(listOfStreatchedImages);
                Console.WriteLine("Done. Check out " + outputPath);
                Console.ReadLine();

            }
            else
            {
                System.Console.WriteLine("please give a file with a list of the character shareble links one per line, f.Ex.: https://ddb.ac/characters/7577901/EwYJYR");
                Console.ReadLine();
            }
        }
    }
}
