using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doanc_sharp.src.DTO
{
    internal class ChiTietPhieuMuonDTO
    {
        public int Maphieumuon { get; set; }
        public int Mathietbi { get; set; }
        public int Soluong { get; set; }
  
        public ChiTietPhieuMuonDTO() { }

        public ChiTietPhieuMuonDTO(int maphieumuon, int mathietbi, int soluong)
        {
            Maphieumuon = maphieumuon;
            Mathietbi = mathietbi;
            Soluong = soluong;
       
        }
    }
}
