using System;
using System.Collections.Generic;
using System.Text;
using SixLabors.ImageSharp;
using SixLabors.Primitives;

using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.PixelFormats;
using System.IO;

namespace dndb.Cards.Parser
{
    public class ImageModification
    {

        /// <summary>
        /// rearanges the open graph image to be used as initiative tracker
        /// </summary>
        /// <param name="charCardUrl"></param>
        public string StretchCharCard(string charCardUrl)
        {
            FileInfo fileInfo = new FileInfo(charCardUrl);
            var parentDir = fileInfo.Directory;
            var subdir = parentDir.CreateSubdirectory("vertical");
            string readyImagePath = "";


            using (Image image = Image.Load(charCardUrl))
            {
                //get parts ready to rearrange
                var portraitAndName = image.Clone(ctx => ctx.Crop(600, 200));
                var strDexon = image.Clone(ctx => ctx.Crop(new Rectangle(0, 200, 600, 200)));
                var intWisCha = image.Clone(ctx => ctx.Crop(new Rectangle(600, 200, 600, 200)));
                var armorHitpoints = image.Clone(ctx => ctx.Crop(new Rectangle(0, 400, 600, 200)));
                var dndbeyondLogo = image.Clone(ctx => ctx.Crop(new Rectangle(600, 400, 600, 200)).Rotate(180));


                var rotatedPortrait = portraitAndName.Clone(k => k.Rotate(180));

                //Pack all the parts in a vertical alighned column
                var assembly = new Image<Rgba32>(600, 1200);

                var options = new GraphicsOptions { ColorBlendingMode = PixelColorBlendingMode.Normal };
                assembly.Mutate(x => x.DrawImage(rotatedPortrait, new Point(0, 0), options));
                assembly.Mutate(x => x.DrawImage(dndbeyondLogo, new Point(0, 200), options));

                assembly.Mutate(x => x.DrawImage(portraitAndName, new Point(0, 400), options));
                assembly.Mutate(x => x.DrawImage(strDexon, new Point(0, 600), options));
                assembly.Mutate(x => x.DrawImage(intWisCha, new Point(0, 800), options));
                assembly.Mutate(x => x.DrawImage(armorHitpoints, new Point(0, 1000), options));


                var savePath = Path.Combine(subdir.FullName, "_vertical_" + fileInfo.Name);
                assembly.Save(savePath); // Automatic encoder selected based on extension.
                readyImagePath = savePath;
                System.Console.WriteLine("Successifully generated a initiative card: " + savePath);
            }
            return readyImagePath;
        }
    }
}
