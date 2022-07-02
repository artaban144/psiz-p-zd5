using PictureInfo = psiz_p_zd5.DTO.PictureInfo;

namespace psiz_p_zd5
{
    public class BitmapPictureHeaderReader
    {
        public static PictureInfo Read(string filePath)
        {
            StreamReader InputFileOne = new StreamReader(filePath);
            Stream FirstBaseInputFile = InputFileOne.BaseStream;
            BinaryReader binaryReader = new BinaryReader(FirstBaseInputFile);

            binaryReader.BaseStream.Seek(14, SeekOrigin.Begin);
            PictureInfo pictureInfo = new PictureInfo();

            pictureInfo.Size = binaryReader.ReadUInt32();
            pictureInfo.Width = binaryReader.ReadUInt32();
            pictureInfo.Height = binaryReader.ReadUInt32();
            pictureInfo.Planes = binaryReader.ReadUInt16();
            pictureInfo.BitCount = binaryReader.ReadUInt16();
            pictureInfo.Compression = binaryReader.ReadUInt32();
            pictureInfo.ImageSize = binaryReader.ReadUInt32();
            pictureInfo.HorizontalResolution = binaryReader.ReadUInt32();
            pictureInfo.VerticalResolution = binaryReader.ReadUInt32();
            pictureInfo.UsedColors = binaryReader.ReadUInt32();
            pictureInfo.ImportantColors = binaryReader.ReadByte();
            pictureInfo.Rotation = binaryReader.ReadByte();

            return pictureInfo;
        }
    }
}
