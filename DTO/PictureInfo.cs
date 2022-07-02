using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psiz_p_zd5.DTO
{
    public class PictureInfo
    {
        public uint Size { get; set; }
        public uint Width { get; set; }
        public uint Height { get; set; }
        public ushort Planes { get; set; }
        public ushort BitCount { get; set; }
        public uint Compression { get; set; }
        public uint ImageSize { get; set; }
        public uint HorizontalResolution { get; set; }
        public uint VerticalResolution { get; set; }
        public uint UsedColors { get; set; }
        public byte ImportantColors { get; set; }
        public byte Rotation { get; set; }
    }
}
