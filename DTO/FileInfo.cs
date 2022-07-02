using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psiz_p_zd5.DTO
{
    public class FileInfo
    {
        public string? Type { get; set; }
        public uint Size { get; set; }
        public ushort ReservedOne { get; set; }
        public ushort ReservedTwo { get; set; }
        public uint Offset { get; set; }
    }
}
