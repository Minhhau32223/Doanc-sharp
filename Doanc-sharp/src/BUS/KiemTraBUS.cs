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

        public Dictionary<int, string> KiemTraTruocKhiVao(int MaThanhVien)
        {
            LSHoatDongBUS ls = new LSHoatDongBUS();
            KhoaTheBUS khoaTheBUS = new KhoaTheBUS();
            if (MaThanhVien <= 0)
            {
                return new Dictionary<int, string> { { 404, "Mã thành viên không hợp lệ" } }; // Mã thành viên không hợp lệ
            }

            List<KhoaTheDTO> khoaTheList = khoaTheBUS.GetAll();
            foreach (KhoaTheDTO khoaThe in khoaTheList)
            {
                if (khoaThe.MaThanhVien == MaThanhVien && khoaThe.ThoiGianMoKhoa > DateTime.Now)
                {
                    ls.themLichSuHD(MaThanhVien, "Vào thư quán thất bại do thành viên vi phạm");
                    return new Dictionary<int, string> { { 403, "Thành viên đã bị khóa thẻ\nNgày mở khóa: " + khoaThe.ThoiGianMoKhoa.ToString() } }; // Thành viên đã bị khóa
                }
            }

            // kiem tra thanh vien vi pham chua duoc xu ly
            DataTable dt = kiemTraDAO.GetViPhamByThanhVien(MaThanhVien);
            List<ThanhVienViPhamDTO> viPhamList = new List<ThanhVienViPhamDTO>();
            if (tvBUS.TimThanhVienTheoMa(MaThanhVien) == null) return new Dictionary<int, string> { { 404, "Mã thành viên không hợp lệ" } };
            foreach (DataRow row in dt.Rows)
            {
                if (row["trangthai"].ToString().Equals("Chua xử lý") || row["trangthai"].ToString().Equals("Chua xu ly"))
                {
                    ls.themLichSuHD(MaThanhVien, "Vào thư quán thất bại do thành viên vi phạm chưa được xử lý");
                    return new Dictionary<int, string> { { 402, "Thành viên vi phạm chưa được xử lý" } };
                }
            }


            // // xu ly kiem tra thanh vien vi pham
            // DataTable dt = kiemTraDAO.GetViPhamByThanhVien(MaThanhVien);
            // List<ThanhVienViPhamDTO> viPhamList = new List<ThanhVienViPhamDTO>();
            // if (tvBUS.TimThanhVienTheoMa(MaThanhVien) == null) return -2;
            // foreach (DataRow row in dt.Rows)
            // {
            //     if (row["trangthai"].ToString().Equals("Chua xử lý") || row["trangthai"].ToString().Equals("Chua xu ly")) return -1;
            // }
            ls.themLichSuHD(MaThanhVien, "Vào thư quán thành công");
            return new Dictionary<int, string> { { 200, "Kiểm tra thành công" } };
        }
    }
}
