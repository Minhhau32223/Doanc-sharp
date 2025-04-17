using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doanc_sharp.src.DTO
{
    internal class ThietBiDTO
    {
        public int Mathietbi { get; set; }
        public string Tenthietbi { get; set; }
        public string Madanhmuc { get; set; }
        public string Trangthai { get; set; }
        public int Giathue { get; set; }

        public ThietBiDTO() { }

        public ThietBiDTO(int ma, string ten, string madm, string trangthai, int giathue)
        {
            Mathietbi = ma;
            Tenthietbi = ten;
            Madanhmuc = madm;
            Trangthai = trangthai;
            Giathue = giathue;
        }
    }
}
