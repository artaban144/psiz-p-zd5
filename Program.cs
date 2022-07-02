using BitmapFileInfo = psiz_p_zd5.DTO.BitmapFileInfo;


namespace psiz_p_zd5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first file path: ");

            string fileName;
            fileName = Console.ReadLine();
            Console.WriteLine(Environment.NewLine + "Metadata: " + Environment.NewLine);

            BitmapFileInfo bitmapFileInfo = new BitmapFileInfo(
                BitmapFileHeaderReader.Read(fileName),
                BitmapPictureHeaderReader.Read(fileName),
                BitmapColorsHeaderReader.Read(fileName)
                );

            BitmapInfoConsolePrinter.Print(bitmapFileInfo);
            NegativeImageRenderer.Render(fileName, "negative.bmp");
        }
    }
}

