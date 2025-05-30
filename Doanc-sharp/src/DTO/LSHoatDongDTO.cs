using Doanc_sharp.src.BUS;
using Doanc_sharp.src.DAO;
using System;

namespace Doanc_sharp.src.DTO
{
    internal class LSHoatDongDTO
    {
        public int MaThanhVien { get; set; }
        public ThanhVienDTO thanhVienDTO { get; set; }
        public int MaHoatDong { get; set; }
        public string? Loai { get; set; }
        public string? ChiTiet { get; set; }
        public DateTime ThoiGian { get; set; }

        public LSHoatDongDTO() { }

        public LSHoatDongDTO(int MaThanhVien,int MaHoatDong, string Loai, string ChiTiet, DateTime ThoiGian)
        {
            this.MaThanhVien = MaThanhVien;
            this.MaHoatDong = MaHoatDong; // auto increment
            this.Loai = Loai;
            this.ChiTiet = ChiTiet;
            this.ThoiGian = ThoiGian;
        }

    }
}