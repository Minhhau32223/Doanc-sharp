using System;
using Doanc_sharp.src.DTO;

namespace Doanc_sharp.src.DTO
{
    internal class KiemTraDTO
    {
        public required List<ThanhVienViPhamDTO> ViPham { get; set; }

        public KiemTraDTO() { }

        public KiemTraDTO(List<ThanhVienViPhamDTO> viPham)
        {
            ViPham = viPham;
        }


        public Boolean kiemTraTruocKhiVao()
        {
            foreach (var item in ViPham)
            {
                if(item.TrangThai == "Chua xu ly") return false;   
            }
            return true;
        }
    }
}
