namespace psiz_p_zd5.DTO
{
    public class File
    {
        public File()
        {
            FileInfo = new FileInfo();
            PictureInfo = new PictureInfo();
            ColorsInfo = new ColorsInfo();
        }

        public FileInfo FileInfo { get; set; }
        public PictureInfo PictureInfo { get; set; }
        public ColorsInfo ColorsInfo { get; set; }
    }
}
