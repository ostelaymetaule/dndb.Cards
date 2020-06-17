using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace dndb.Cards.Pdf
{
    public class PdfCombiner
    {

        public Stream Combine(List<Stream> cardStreams, List<Stream> tokenStreams = null)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var ret = "";
            var document = new PdfDocument();
            var page = document.AddPage();
            var gfx = XGraphics.FromPdfPage(page);
            int imageWidth = 180;
            int imageHeight = 2 * imageWidth;
            int maxHorizontalImages = 3;
            int maxImagesPerPage = 6;
            int previousPageNumber = 0;
            int i = 0;
            int j = 0;
            int pageNumber = 0;
            int onPageIndex = 0;
            if (tokenStreams != null)
            {
                for (; i < cardStreams.Count; i++)
                {
                    pageNumber = i / maxImagesPerPage;
                    onPageIndex = i % maxImagesPerPage;
                    j = onPageIndex / maxHorizontalImages;

                    if (pageNumber > previousPageNumber)
                    {
                        previousPageNumber = pageNumber;
                        page = document.AddPage();
                        gfx = XGraphics.FromPdfPage(page);
                        j = 0;
                        onPageIndex = 0;
                    }
                    XImage image = XImage.FromStream(cardStreams[i]);
                    double x = 20 + (imageWidth + 10) * (onPageIndex - j * maxHorizontalImages);
                    double y = 20 + (imageHeight + 10) * j;
                    gfx.DrawImage(image, x, y, imageWidth, imageHeight);
                }
            }
            if (tokenStreams != null)
            {
                maxHorizontalImages = 10;
                maxImagesPerPage = 30;
                for (int tokenIndex = 0; i < tokenStreams.Count; tokenIndex++, i++)
                {
                    pageNumber = i / maxImagesPerPage;
                    onPageIndex = i % maxImagesPerPage;
                    j = onPageIndex / maxHorizontalImages;

                    if (pageNumber > previousPageNumber)
                    {
                        previousPageNumber = pageNumber;
                        page = document.AddPage();
                        gfx = XGraphics.FromPdfPage(page);
                        j = 0;
                        onPageIndex = 0;
                    }
                    XImage image = XImage.FromStream(tokenStreams[tokenIndex]);
                    imageWidth = 200 * image.PixelWidth / image.PixelHeight; //1/6
                    imageHeight = 200;
                    double x = 20 + (imageWidth + 10) * (onPageIndex - j * maxHorizontalImages);
                    double y = 20 + (imageHeight + 10) * j;
                    gfx.DrawImage(image, x, y, imageWidth, imageHeight);
                }
            }


            var ms = new MemoryStream();
            document.Save(ms);
            return ms;
        }

    }
}
