using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doanc_sharp.src.DTO
{
    internal class CtDatChoDTO
    {
        public int Madatcho { get; set; }
        public int Mathanhvien { get; set; }
        public int Masoluong {  get; set; }
       public int Soluong {  get; set; }
        public CtDatChoDTO() { }
        public CtDatChoDTO(int madatcho, int mathanhvien, int soluong)
        {
            Madatcho = madatcho;
            Mathanhvien = mathanhvien;
            Soluong = soluong;

        }
    }
}
