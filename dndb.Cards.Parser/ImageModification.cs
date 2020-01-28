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
        public Stream StretchCharCard(Stream charCardStream)
        {
            var memstream = charCardStream as MemoryStream;
            var data = memstream.ToArray();
           
            using (Image image = Image.Load(data))
            {
                //get parts ready to rearrange
                var portrait = image.Clone(ctx => ctx.Crop(200, 200));
                var strDexon = image.Clone(ctx => ctx.Crop(new Rectangle(0, 200, 600, 200)));
                var intWisCha = image.Clone(ctx => ctx.Crop(new Rectangle(600, 200, 600, 200)));
                var armorHitpoints = image.Clone(ctx => ctx.Crop(new Rectangle(0, 400, 600, 200)));
                var dndbeyondLogo = image.Clone(ctx => ctx.Crop(new Rectangle(600, 400, 600, 200)).Rotate(180));
                var nameStrip = image.Clone(ctx => ctx.Crop(new Rectangle(200, 0, 4 * 200, 200)).Resize(400, 100));
                var nameStripRotated = image.Clone(ctx => ctx.Crop(new Rectangle(200, 0, 4 * 200, 200)).Rotate(180).Resize(400, 100));

                var rotatedPortrait = portrait.Clone(k => k.Rotate(180));

                //Pack all the parts in a vertical alighned column
                var assembly = new Image<Rgba32>(600, 1200);

                var options = new GraphicsOptions { ColorBlendingMode = PixelColorBlendingMode.Normal };
                assembly.Mutate(x => x.DrawImage(rotatedPortrait, new Point(0, 0), options));
                assembly.Mutate(x => x.DrawImage(nameStripRotated, new Point(200, 100), options));
                assembly.Mutate(x => x.DrawImage(nameStrip, new Point(200, 500), options));

                assembly.Mutate(x => x.DrawImage(dndbeyondLogo, new Point(0, 200), options));

                assembly.Mutate(x => x.DrawImage(portrait, new Point(0, 400), options));
                assembly.Mutate(x => x.DrawImage(strDexon, new Point(0, 600), options));
                assembly.Mutate(x => x.DrawImage(intWisCha, new Point(0, 800), options));
                assembly.Mutate(x => x.DrawImage(armorHitpoints, new Point(0, 1000), options));
                MemoryStream ms = new MemoryStream();
                assembly.Save(ms, new SixLabors.ImageSharp.Formats.Png.PngEncoder()); // Automatic encoder selected based on extension.
                System.Console.WriteLine("Successifully generated a initiative cards");
                return ms;
            }
        }
    }
}
