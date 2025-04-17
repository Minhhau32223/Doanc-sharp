using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doanc_sharp.src.DTO
{
    internal class DatChoDTO
    {
        public int Mathanhvien { get; set; }
        public int Madatcho { get; set; }
        public int Mathietbi { get; set; }
        public DateTime Thoigiandat { get; set; }
        public string Trangthai { get; set; }

        public DatChoDTO() { }

        public DatChoDTO(int mathanhvien, int madatcho, int mathietbi, DateTime thoigiandat, string trangthai)
        {
            Mathanhvien = mathanhvien;
            Madatcho = madatcho;
            Mathietbi = mathietbi;
            Thoigiandat = thoigiandat;
            Trangthai = trangthai;
        }
    }
}
