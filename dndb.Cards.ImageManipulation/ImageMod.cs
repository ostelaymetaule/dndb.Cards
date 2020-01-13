using ImageProcessor;
using ImageProcessor.Imaging.Formats;
using ImageProcessor.Imaging;
using ImageProcessor.Processors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace dndb.Cards.Parser
{
    public class ImageMod
    {
        public ImageMod()
        {

        }

        public void StretchCharCard(string charCardUrl)
        {
            byte[] photoBytes = File.ReadAllBytes(charCardUrl); //1200x634
            // Format is automatically detected though can be changed.
            ISupportedImageFormat format = new JpegFormat { Quality = 70 };
            Size size = new Size(600, 317*3);

            using (MemoryStream inStream = new MemoryStream(photoBytes))
            {
                using (MemoryStream outStream = new MemoryStream())
                {
                    // Initialize the ImageFactory using the overload to preserve EXIF metadata.
                    using (ImageFactory imageFactory = new ImageFactory(preserveExifData: true))
                    {
                        // Load, resize, set the format and quality and save an image.
                        imageFactory.Load(inStream)
                                                .Crop(new CropLayer(0,0,600,390,CropMode.Pixels))
                                                .Resize(new ResizeLayer(size, ResizeMode.BoxPad, AnchorPosition.TopLeft))
                                                .Format(format)
                                                .Save(outStream);
                    }
                    // Do something with the stream.

                    using (var fs = new FileStream(charCardUrl+"_crop.png", FileMode.OpenOrCreate))
                    {
                        fs.Flush();
                        outStream.CopyTo(fs);
                        fs.Flush();
                    }
                }
            }




        }
    }
}
