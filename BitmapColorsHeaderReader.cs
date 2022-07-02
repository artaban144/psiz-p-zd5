using ColorsInfo = psiz_p_zd5.DTO.ColorsInfo;

namespace psiz_p_zd5
{
    public class BitmapColorsHeaderReader
    {
        public static ColorsInfo Read(string filePath)
        {
            StreamReader InputFileOne = new StreamReader(filePath);
            Stream FirstBaseInputFile = InputFileOne.BaseStream;
            BinaryReader binaryReader = new BinaryReader(FirstBaseInputFile);

            binaryReader.BaseStream.Seek(54, SeekOrigin.Begin);
            ColorsInfo colorsInfo = new ColorsInfo();

            colorsInfo.Red = binaryReader.ReadByte();
            colorsInfo.Green = binaryReader.ReadByte();
            colorsInfo.Blue = binaryReader.ReadByte();

            return colorsInfo;
        }
    }
}
