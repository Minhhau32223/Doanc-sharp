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
            string query = "SELECT tvvp.Mavipham, tv.HoTen, vp.Tenvipham, vp.Mota, tvvp.Ngayvp, tvvp.Trangthai " +
                          "FROM Thanhvienvipham tvvp " +
                          "LEFT JOIN thanhvien tv ON tvvp.MaThanhVien = tv.Mathanhvien " +
                          "LEFT JOIN vipham vp ON tvvp.Mavipham = vp.Mavipham";
            return dbConnection.ExecuteQuery(query);
        }

        public List<ViPhamDTO> GetAllViPhamNotTvvp()
        {
            string query = "SELECT * FROM vipham WHERE is_delete=0";
            DataTable dataTable = dbConnection.ExecuteQuery(query);

            List<ViPhamDTO> viPhamList = new List<ViPhamDTO>();
            foreach (DataRow row in dataTable.Rows)
            {
                ViPhamDTO viPham = new ViPhamDTO
                {
                    MaViPham = row["Mavipham"].ToString(),
                    TenViPham = row["Tenvipham"].ToString(),
                    MoTa = row["Mota"].ToString()
                };
                viPhamList.Add(viPham);
            }

            return viPhamList;
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

        public Boolean InsertViPham(NhanVienDTO nv, ViPhamDTO viPham)
        {
            string query = $"INSERT INTO vipham (Manhanvien, Mavipham, Tenvipham, Mota, is_delete) VALUES ('{nv.Manhanvien}' ,'{viPham.MaViPham}', '{viPham.TenViPham}', '{viPham.MoTa}', '0')";
            return dbConnection.ExecuteNonQuery(query) > 0;
        }

        public Boolean InsertTVVP(ThanhVienDTO tv, ViPhamDTO viPham, DateTime time)
        {
            string formattedTime = time.ToString("yyyy-MM-dd HH:mm:ss"); // Định dạng chuẩn cho MariaDB
            string query = $"INSERT INTO thanhvienvipham (Mathanhvien, Mavipham, Ngayvp, Trangthai, is_delete) " +
                           $"VALUES ('{tv.Mathanhvien}', '{viPham.MaViPham}', '{formattedTime}', 'Chua xu ly', '0')";
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
            string query = $"UPDATE thanhvienvipham SET Trangthai = 'Da xu ly' WHERE Mavipham = '{MaViPham}'";
            return dbConnection.ExecuteNonQuery(query) > 0;
        }
    }
}
