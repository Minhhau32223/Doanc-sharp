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

        
    }

}
