using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Doanc_sharp.src.DTO;
using Doanc_sharp.src.Helpers;

namespace Doanc_sharp.src.DAO
{
    internal class DatChoDAO
    {
        private DbConnection db;

        public DatChoDAO()
        {
            db = new DbConnection();
        }

        // Thêm đặt chỗ
        public bool ADD(DatChoDTO datCho)
        {
            string query = $"INSERT INTO datcho (Madatcho, Mathanhvien, Thoigiandat, Trangthai) VALUES " +
                           $"({datCho.Madatcho}, {datCho.Mathanhvien}, '{datCho.Thoigiandat:yyyy-MM-dd HH:mm:ss}', '{datCho.Trangthai}')";
            return db.ExecuteNonQuery(query) > 0;
        }

        // Sửa đặt chỗ
        public bool Update(DatChoDTO datCho)
        {
            string query = $"UPDATE datcho SET " +
                           $"Mathanhvien = {datCho.Mathanhvien}, " +
                           $"Mhoigiandat = '{datCho.Thoigiandat:yyyy-MM-dd HH:mm:ss}', " +
                           $"Trangthai = '{datCho.Trangthai}' " +
                           $"WHERE madatcho = {datCho.Madatcho}";
            return db.ExecuteNonQuery(query) > 0;
        }

        // Xóa đặt chỗ theo mã
        public bool Delete(int madatcho)
        {
            string query = $"DELETE FROM datcho WHERE madatcho = {madatcho}";
            return db.ExecuteNonQuery(query) > 0;
        }

        // Lấy toàn bộ danh sách đặt chỗ (nếu cần)
        public List<DatChoDTO> LayDanhSachDatCho()
        {
            string query = "SELECT * FROM datcho";
            DataTable dt = db.ExecuteQuery(query);
            List<DatChoDTO> danhSach = new List<DatChoDTO>();

            foreach (DataRow row in dt.Rows)
            {
                danhSach.Add(new DatChoDTO(
                    Convert.ToInt32(row["Mathanhvien"]),
                    Convert.ToInt32(row["Madatcho"]),
                    Convert.ToDateTime(row["Thoigiandat"]),
                    row["Trangthai"].ToString()
                ));
            }
            return danhSach;
        }
    }
}
