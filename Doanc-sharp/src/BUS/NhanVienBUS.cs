using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Doanc_sharp.src.DAO;
using Doanc_sharp.src.DTO;

namespace Doanc_sharp.src.BUS
{
    internal class NhanVienBUS
    { private List<NhanVienDTO> dsnv { get; set; }
      private NhanVienDAO dao { get; set; }

        public NhanVienBUS()
        { 
            dao = new NhanVienDAO();
        }
        public List<NhanVienDTO> docDsnv()
        {
            try
            {
                dao = new NhanVienDAO();
                List<NhanVienDTO> temp = new List<NhanVienDTO>();

                temp=dao.LayDanhSachNhanVien();
                if (temp != null)
                {
                    dsnv = temp;
                }
               
                    
               
            }
            catch (Exception ex)
            {

            }


            return dsnv;
        }
        public bool ThemNhanVien(NhanVienDTO nv)
        {
            if (string.IsNullOrWhiteSpace(nv.Hoten) || string.IsNullOrWhiteSpace(nv.Taikhoan))
            {
                throw new ArgumentException("Họ tên và tài khoản không được để trống.");
            }
            return dao.ThemNhanVien(nv);
        }
        public NhanVienDTO DangNhap(string taikhoan, string matkhau)
        {
            return dao.DangNhap(taikhoan, matkhau);
        }

    }
}
