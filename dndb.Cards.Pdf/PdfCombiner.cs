using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;

namespace dndb.Cards.Pdf
{
    public class PdfCombiner
    {

        public string Combine(List<string> cardPaths)
        {
            var ret = "";
            var document = new PdfDocument();
            var page = document.AddPage();
            var gfx = XGraphics.FromPdfPage(page);
            for (int i = 0, j = 0; i < cardPaths.Count; i++, j = i / 3)
            {

                XImage image = XImage.FromFile(cardPaths[i]);
                double x = 20 + 155 * (i-j*3);
                double y = 20 + 305 * j;
                gfx.DrawImage(image, x, y, 150, 300);
            }
            document.Save("CardsPdf.pdf");


            return ret;
        }

    }
}
