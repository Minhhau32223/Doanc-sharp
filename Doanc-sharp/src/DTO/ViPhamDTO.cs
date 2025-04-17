using System;
using System.Data;
using Doanc_sharp.src.DTO;

namespace Doanc_sharp.src.DTO
{
    internal class ViPhamDTO
    {
        public int MaThanhVien { get; set; }
        public string? MaViPham { get; set; }
        public string? TenViPham { get; set; }
        public string? MoTa { get; set; }

        public ViPhamDTO() { }

        public ViPhamDTO(int MaThanhVien, string MaViPham, string TenViPham, string MoTa)
        {
            this.MaThanhVien = MaThanhVien;
            this.MaViPham = MaViPham;
            this.TenViPham = TenViPham;
            this.MoTa = MoTa;
        }

        public static explicit operator ViPhamDTO(DataTable v)
        {
            throw new NotImplementedException();
        }
    }
}