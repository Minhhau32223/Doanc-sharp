using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doanc_sharp.src.DTO
{
    internal class NhanVienDTO
    {
        public int Manhanvien { get; set; }
        public string Hoten { get; set; }
        public string Taikhoan { get; set; }
        public string Matkhau { get; set; }
        public string Diachi { get; set; }
        public int Sdt { get; set; }
        public string Chucvu { get; set; }
        public string Trangthai { get; set; }
        public string Email { get; set; }

        public NhanVienDTO() { }

        public NhanVienDTO(int manv, string hoten, string taikhoan, string matkhau, string diachi, int sdt, string chucvu, string trangthai, string email)
        {
            Manhanvien = manv;
            Hoten = hoten;
            Taikhoan = taikhoan;
            Matkhau = matkhau;
            Diachi = diachi;
            Sdt = sdt;
            Chucvu = chucvu;
            Trangthai = trangthai;
            Email = email;
        }
    }
}
