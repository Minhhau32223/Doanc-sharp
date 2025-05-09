using Doanc_sharp.src.DAO;
using Doanc_sharp.src.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doanc_sharp.src.BUS
{
    internal class KiemTraBUS
    {
        private KiemTraDAO kiemTraDAO = new KiemTraDAO();
        private ThanhVienBUS tvBUS = new ThanhVienBUS();

        public int KiemTraTruocKhiVao(int MaThanhVien)
        {
            if (MaThanhVien <= 0)
            {
                return -2; // Mã thành viên không hợp lệ
            }


            // xu ly kiem tra thanh vien co ton tai.



            // xu ly kiem tra thanh vien vi pham
            DataTable dt = kiemTraDAO.GetViPhamByThanhVien(MaThanhVien);
            List<ThanhVienViPhamDTO> viPhamList = new List<ThanhVienViPhamDTO>();
            if (tvBUS.TimThanhVienTheoMa(MaThanhVien) == null) return -2;
            foreach (DataRow row in dt.Rows)
            {
                if (row["trangthai"].ToString().Equals("Chua xử lý") || row["trangthai"].ToString().Equals("Chua xu ly")) return -1;
            }
            return 1;
        }
    }
}
