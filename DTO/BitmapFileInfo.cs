namespace psiz_p_zd5.DTO
{
    public class BitmapFileInfo
    {
        public BitmapFileInfo(FileInfo fileInfo, PictureInfo pictureInfo, ColorsInfo colorsInfo)
        {
            FileInfo = fileInfo;
            PictureInfo = pictureInfo;
            ColorsInfo = colorsInfo;
        }

        public FileInfo FileInfo { get; }
        public PictureInfo PictureInfo { get; }
        public ColorsInfo ColorsInfo { get; }
    }
}
