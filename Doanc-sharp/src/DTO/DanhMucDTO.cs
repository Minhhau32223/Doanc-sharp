using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doanc_sharp.src.DTO
{
    internal class DanhMucDTO
    {
        public string Madanhmuc { get; set; }
        public string Tendanhmuc { get; set; }
        public string Mota { get; set; }

        public DanhMucDTO() { }

        public DanhMucDTO(string madm, string tendm, string mota)
        {
            Madanhmuc = madm;
            Tendanhmuc = tendm;
            Mota = mota;
        }
    }
}
