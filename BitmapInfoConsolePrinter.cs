using System;

using BitmapFileInfo = psiz_p_zd5.DTO.BitmapFileInfo;

namespace psiz_p_zd5
{
    public class BitmapInfoConsolePrinter
    {
        public static void Print(BitmapFileInfo bitmapFileInfo)
        {

            Console.WriteLine("File: ");

            Console.WriteLine("Type: " + bitmapFileInfo.FileInfo.Type.ToString());
            Console.WriteLine("Size: " + bitmapFileInfo.FileInfo.Size);
            Console.WriteLine("Reserved One: " + bitmapFileInfo.FileInfo.ReservedOne);
            Console.WriteLine("Reserved Two: " + bitmapFileInfo.FileInfo.ReservedTwo);
            Console.WriteLine("Offset: " + bitmapFileInfo.FileInfo.Offset);

            Console.WriteLine();
            Console.WriteLine("Picture: ");

            Console.WriteLine("biSize: " + bitmapFileInfo.PictureInfo.Size);
            Console.WriteLine("biWidth: " + bitmapFileInfo.PictureInfo.Width);
            Console.WriteLine("biHeight: " + bitmapFileInfo.PictureInfo.Height);
            Console.WriteLine("biPlanes: " + bitmapFileInfo.PictureInfo.Planes);
            Console.WriteLine("biBitCount: " + bitmapFileInfo.PictureInfo.BitCount);
            Console.WriteLine("biCompression: " + bitmapFileInfo.PictureInfo.Compression);
            Console.WriteLine("biSizeImage: " + bitmapFileInfo.PictureInfo.ImageSize);
            Console.WriteLine("biXPelsPerMeter: " + bitmapFileInfo.PictureInfo.HorizontalResolution);
            Console.WriteLine("biYPelsPerMeter: " + bitmapFileInfo.PictureInfo.VerticalResolution);
            Console.WriteLine("biClrUsed: " + bitmapFileInfo.PictureInfo.UsedColors);
            Console.WriteLine("biClrImportant: " + bitmapFileInfo.PictureInfo.ImportantColors);
            Console.WriteLine("biClrRotation: " + bitmapFileInfo.PictureInfo.Rotation);

            Console.WriteLine();
            Console.WriteLine("Colors: ");

            Console.WriteLine("Red: " + bitmapFileInfo.ColorsInfo.Red);
            Console.WriteLine("Green: " + bitmapFileInfo.ColorsInfo.Green);
            Console.WriteLine("Blue: " + bitmapFileInfo.ColorsInfo.Blue);
        }
    }
}
