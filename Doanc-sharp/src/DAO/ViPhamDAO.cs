using Doanc_sharp.src.DTO;
using Doanc_sharp.src.Helpers;
using System.Data;

namespace Doanc_sharp.src.DAO
{
    internal class ViPhamDAO
    {
        private DbConnection dbConnection;
        public ViPhamDAO()
        {
            dbConnection = new DbConnection();
        }

        public DataTable GetAllViPham()
        {
            string query = "SELECT tvvp.Mavipham, tv.HoTen, vp.Tenvipham, vp.Mota, tvvp.Trangthai " +
                          "FROM Thanhvienvipham tvvp " +
                          "LEFT JOIN thanhvien tv ON tvvp.MaThanhVien = tv.Mathanhvien " +
                          "LEFT JOIN vipham vp ON tvvp.Mavipham = vp.Mavipham";
            return dbConnection.ExecuteQuery(query);
        }

        public ViPhamDTO GetViPhamById(int id)
        {
            string query = $"SELECT * FROM ViPham WHERE Mavipham = {id}";
            DataRow row = dbConnection.ExecuteQuery(query).Rows[0];
            return new ViPhamDTO
            {
                MaViPham = row["Mavipham"].ToString(),
                TenViPham = row["Tenvipham"].ToString(),
                MoTa = row["Mota"].ToString()
            };
        }

        public Boolean InsertViPham(ViPhamDTO viPham)
        {
            string query = $"INSERT INTO vipham (Mavipham, Tenvipham, Mota) VALUES ('{viPham.MaViPham}', '{viPham.TenViPham}', '{viPham.MoTa}')";
            return dbConnection.ExecuteNonQuery(query) > 0;
        }

        public Boolean UpdateViPham(ViPhamDTO viPham)
        {
            string query = $"UPDATE vipham SET Tenvipham = '{viPham.TenViPham}', Mota = '{viPham.MoTa}' WHERE Mavipham = '{viPham.MaViPham}'";
            return dbConnection.ExecuteNonQuery(query) > 0;
        }

        public Boolean DeleteViPham(string MaViPham)
        {
            string query = $"DELETE FROM vipham WHERE Mavipham = '{MaViPham}'";
            return dbConnection.ExecuteNonQuery(query) > 0;
        }

        public Boolean XulyViPham(string MaViPham)
        {
            string query = $"UPDATE thanhvienvipham SET Trangthai = 'Đã xử lý' WHERE Mavipham = '{MaViPham}'";
            return dbConnection.ExecuteNonQuery(query) > 0;
        }
    }
}
