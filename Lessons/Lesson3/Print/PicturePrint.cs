using System.Drawing;

namespace Print
{
    public class PicturePrint : IPrinter
    {
        public void Print()
        {// Load the original image
            var bmp = new Bitmap(80, 80);

            // Create a rectangle for the entire bitmap
            var rectf = new RectangleF(0, 0, bmp.Width, bmp.Height);

            // Create graphic object that will draw onto the bitmap
            var g = Graphics.FromImage(bmp);

            var format = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            // Draw the text onto the image
            g.DrawString("This is the text", new Font("Tahoma", 14), Brushes.Black, rectf, format);

            // Flush all graphics changes to the bitmap
            g.Flush();

            // Now save or use the bitmap
            bmp.Save("textInPicture.bmp");
        }
    }
}