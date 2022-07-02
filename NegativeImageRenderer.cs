using System;
using System.Drawing;

namespace psiz_p_zd5
{
    public class NegativeImageRenderer
    {
        public static void Render(string sourceFilePath, string targetFilePath)
        {
            Bitmap bitmap = new Bitmap(sourceFilePath);
            int imageWidth = bitmap.Width;
            int imageHeight = bitmap.Height;

            for (int y = 0; y < imageHeight; y++)
            {
                for (int x = 0; x < imageWidth; x++)
                {
                    Color pixel = bitmap.GetPixel(x, y);

                    int negativeRed = 255 - pixel.R;
                    int negativeGreen = 255 - pixel.G;
                    int negativeBlue = 255 - pixel.B;

                    bitmap.SetPixel(x, y, Color.FromArgb(255, negativeRed, negativeGreen, negativeBlue));
                }
            }

            bitmap.Save(targetFilePath);
        }
    }
}
