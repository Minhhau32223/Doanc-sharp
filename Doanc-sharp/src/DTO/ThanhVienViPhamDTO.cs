using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doanc_sharp.src.DTO
{
    internal class ThanhVienViPhamDTO
    {
        public ThanhVienViPhamDTO()
        {
        }

        //public ThanhVienDTO ThanhVien { get; set; } = new ThanhVienDTO();
        public ViPhamDTO ViPham { get; set; } = new ViPhamDTO();
        public DateTime NgayViPham { get; set; } = new DateTime();
        public string? TrangThai { get; set; }

        //public ThanhVienViPhamDTO(ThanhVienDTO thanhVien, ViPhamDTO viPham, DateTime ngayViPham, string trangThai)
        //{
        //    ThanhVien = thanhVien;
        //    ViPham = viPham;
        //    NgayViPham = ngayViPham;
        //    TrangThai = trangThai;
        //}
    }
}
