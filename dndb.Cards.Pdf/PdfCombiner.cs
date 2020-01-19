using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Text;

namespace dndb.Cards.Pdf
{
    public class PdfCombiner
    {

        public string Combine(List<string> cardPaths)
        {

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var ret = "";
            var document = new PdfDocument();
            var page = document.AddPage();
            var gfx = XGraphics.FromPdfPage(page);
            int imageWight = 180;
            int imageHeight = 2 * imageWight;
            int maxHorizontalImages = 3;
            int maxImagesPerPage = 6; 
            int previousPageNumber = 0;
            for (int i = 0, j = 0, pageNumber = 0, onPageIndex = 0; i < cardPaths.Count; i++)
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

                XImage image = XImage.FromFile(cardPaths[i]);
                double x = 20 + (imageWight+10) * (onPageIndex - j * maxHorizontalImages);
                double y = 20 + (imageHeight + 10) * j;
                gfx.DrawImage(image, x, y, imageWight, imageHeight);
            }
            document.Save("CardsPdf.pdf");
            return ret;
        }

    }
}
