using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Doanc_sharp.src.DTO;
using Doanc_sharp.src.DAO;
using Org.BouncyCastle.Asn1.Mozilla;
using System.Windows.Forms;
namespace Doanc_sharp.src.BUS
{
    internal class ThanhVienBUS
    {
        private ThanhVienDAO thanhVienDAO;
        public ThanhVienBUS()
        {
            thanhVienDAO = new ThanhVienDAO();
        }
        public List<ThanhVienDTO> LayTatcaThanhVien()
        {
            return thanhVienDAO.LayDanhSachThanhVien();
        }
        //thêm thành viên
        public bool ThemThanhVien (ThanhVienDTO tv)
        {
            if (string.IsNullOrWhiteSpace(tv.Hoten) || string.IsNullOrWhiteSpace(tv.Taikhoan))
            {
                throw new ArgumentException("Họ tên và tài khoản không được để trống.");
            }
            return thanhVienDAO.ThemThanhVien(tv);
        }
        //cập nhật thông tin thành viên
        public bool CapNhatThanhVien(ThanhVienDTO tv)
        {
            if (tv.Mathanhvien < 0)
            {
                throw new ArgumentException("Mã thành viên không hợp lệ");
            }
            return thanhVienDAO.CapNhatThanhVien(tv);
        }

        public bool XoaThanhVien(int mathanhvien)
        {
            if (mathanhvien <= 0)
            {
                throw new ArgumentException("Mã thành viên không hợp lệ.");
            }
            return thanhVienDAO.XoaThanhVien(mathanhvien);
        }

        public int XoaThanhVienTheoNam(int nam)
        {
            if (nam < 2000 || nam > DateTime.Now.Year)
            {
                throw new ArgumentException("Năm không hợp lệ.");
            }
            return thanhVienDAO.XoaNhieuThanhVienTheoNam(nam);

        }
        public ThanhVienDTO TimThanhVienTheoMa(int maThanhVien)
        {
            return thanhVienDAO.TimThanhVienTheoMa(maThanhVien);
        }
    }
}
