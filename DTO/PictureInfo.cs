using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psiz_p_zd5.DTO
{
    public class PictureInfo
    {
        public int Size { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Planes { get; set; }
        public int BitCount { get; set; }
        public int Compression { get; set; }
        public int ImageSize { get; set; }
        public int HorizontalResolution { get; set; }
        public int VerticalResolution { get; set; }
        public int UsedColors { get; set; }
        public int ImportantColors { get; set; }
    }
}
