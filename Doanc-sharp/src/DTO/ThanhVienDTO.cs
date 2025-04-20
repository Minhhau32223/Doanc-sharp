using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Doanc_sharp.src.DTO
{
    public class ThanhVienDTO
    {
        public int Mathanhvien { get; set; }
        public string Hoten { get; set; }
        public string Taikhoan { get; set; }
        public string Matkhau { get; set; }
        public string Diachi { get; set; }
        public int Sdt { get; set; }
        public DateTime Ngaydangky { get; set; }
        public string Trangthai { get; set; }
        public string Email { get; set; }

        public ThanhVienDTO() { }


        public ThanhVienDTO(int matv, string hoten, string taikhoan, string matkhau, string diachi, int sdt, DateTime ngaydangky, string trangthai, string email)
        {
            Mathanhvien = matv;
            Hoten = hoten;
            Taikhoan = taikhoan;
            Matkhau = matkhau;
            Diachi = diachi;
            Sdt = sdt;
            Ngaydangky = ngaydangky;
            Trangthai = trangthai;
            Email = email;

        }
        public override string ToString()
        {
            return $"{Mathanhvien} - {Hoten}";
        }
        public string SdtFormatted
        {
            get => Sdt.ToString("0000 000 000");
        }
    }

}
