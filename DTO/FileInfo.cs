using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psiz_p_zd5.DTO
{
    public class FileInfo
    {
        public int Type { get; set; }
        public int Size { get; set; }
        public int ReservedOne { get; set; }
        public int ReservedTwo { get; set; }
        public int Offset { get; set; }
    }
}
