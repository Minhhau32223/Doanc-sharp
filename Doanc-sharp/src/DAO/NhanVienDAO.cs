using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Doanc_sharp.src.Helpers;

using Doanc_sharp.src.DTO;

using System.Data;
namespace Doanc_sharp.src.DAO
{
    internal class NhanVienDAO
    {
        private DbConnection db;

        public NhanVienDAO()
        {
            db = new DbConnection();
        }

        public List<NhanVienDTO> LayDanhSachNhanVien()
        {
            List<NhanVienDTO> list = new List<NhanVienDTO>();
            string query = "SELECT * FROM nhanvien";

            DataTable dt = db.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                NhanVienDTO nv = new NhanVienDTO
                {
                    Manhanvien = Convert.ToInt32(row["Manhanvien"]),
                    Hoten = row["Hoten"].ToString(),
                    Taikhoan = row["Taikhoan"].ToString(),
                    Matkhau = row["Matkhau"].ToString(),
                    Diachi = row["Diachi"].ToString(),
                    Sdt = Convert.ToInt32(row["Sdt"]),
                    Chucvu = row["Chucvu"].ToString(),
                    Trangthai = row["Trangthai"].ToString(),
                    Email = row["Email"].ToString()
                };

                list.Add(nv);
            }

            return list;
        }
        public bool ThemNhanVien(NhanVienDTO nhanvien)
        {
            try
            {
                string query = $"INSERT INTO thanhvien (Manhanvien, Hoten, Taikhoan, Matkhau, Diachi, Sdt, Chucvu, Trangthai, Email) " +
                $"VALUES ('{nhanvien.Manhanvien}',N'{nhanvien.Hoten}', '{nhanvien.Taikhoan}', '{nhanvien.Matkhau}', " +
                $"N'{nhanvien.Diachi}', {nhanvien.Sdt}, '{nhanvien.Chucvu}', " +
                $"'{nhanvien.Trangthai}', '{nhanvien.Email}')";

                int result = db.ExecuteNonQuery(query);
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm thành viên: " + ex.Message);
            }
        }
        public NhanVienDTO DangNhap(string taikhoan, string matkhau)
        {
            string query = $"SELECT * FROM nhanvien WHERE Taikhoan = '{taikhoan}' AND Matkhau = '{matkhau}'";

            DataTable dt = db.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new NhanVienDTO
                {
                    Manhanvien = Convert.ToInt32(row["Manhanvien"]),
                    Hoten = row["Hoten"].ToString(),
                    Taikhoan = row["Taikhoan"].ToString(),
                    Matkhau = row["Matkhau"].ToString(),
                    Diachi = row["Diachi"].ToString(),
                    Sdt = Convert.ToInt32(row["Sdt"]),
                    Chucvu = row["Chucvu"].ToString(),
                    Trangthai = row["Trangthai"].ToString(),
                    Email = row["Email"].ToString()
                };
            }

            return null;
        }




    }

}
