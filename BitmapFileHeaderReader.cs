using FileInfo = psiz_p_zd5.DTO.FileInfo;


namespace psiz_p_zd5
{
    public class BitmapFileHeaderReader
    {
        public static FileInfo Read(string filePath)
        {
            StreamReader InputFileOne = new StreamReader(filePath);
            Stream FirstBaseInputFile = InputFileOne.BaseStream;
            BinaryReader binaryReader = new BinaryReader(FirstBaseInputFile);

            binaryReader.BaseStream.Seek(0, SeekOrigin.Begin);
            FileInfo fileInfo = new FileInfo();

            fileInfo.Type = new string(binaryReader.ReadChars(2));
            fileInfo.Size = binaryReader.ReadUInt32();
            fileInfo.ReservedOne = binaryReader.ReadUInt16();
            fileInfo.ReservedTwo = binaryReader.ReadUInt16();
            fileInfo.Offset = binaryReader.ReadUInt32();

            return fileInfo;
        }
    }
}
