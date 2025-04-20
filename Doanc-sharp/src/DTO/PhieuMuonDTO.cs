using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doanc_sharp.src.DTO
{
    internal class PhieuMuonDTO
    {
        public int Maphieumuon { get; set; }
        public DateTime Ngaymuon { get; set; }
        public string Ngaytra { get; set; }
        public string Trangthai { get; set; }
        public int Mathanhvien { get; set; }

        public PhieuMuonDTO() { }

        public PhieuMuonDTO(int maphieumuon, DateTime ngaymuon, string ngaytra, string trangthai, int mathanhvien)
        {
            Maphieumuon = maphieumuon;
            Ngaymuon = ngaymuon;
            Ngaytra = ngaytra;
            Trangthai = trangthai;
            Mathanhvien = mathanhvien;
        }
    }
}
