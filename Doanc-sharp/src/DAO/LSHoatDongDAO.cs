using Doanc_sharp.src.DTO;
using Doanc_sharp.src.Helpers;
using MySql.Data.MySqlClient;
using System.Data;

namespace Doanc_sharp.src.DAO
{
    internal class LSHoatDongDAO
    {
        private DbConnection dbConnection;
        public LSHoatDongDAO() 
        {
            dbConnection = new DbConnection();
        }

        public DataTable GetAllLSHoatDong()
        {
            string query = "SELECT * FROM lichsuhoatdong";
            return dbConnection.ExecuteQuery(query);
        }
        public DataTable customExecuteQuery(string query)
        {
            return dbConnection.ExecuteQuery(query);
        }

        public LSHoatDongDTO GetLSHoatDongById(int maThanhVien, int maHoatDong)
        {
            string query = $"SELECT * FROM lichsuhoatdong WHERE MaThanhVien = {maThanhVien} AND MaHoatDong = {maHoatDong}";
            DataRow row = dbConnection.ExecuteQuery(query).Rows[0];
            return new LSHoatDongDTO
            {
                MaThanhVien = Convert.ToInt32(row["MaThanhVien"]),
                MaHoatDong = Convert.ToInt32(row["MaHoatDong"]),
                Loai = row["Loai"].ToString(),
                ChiTiet = row["ChiTiet"].ToString(),
                ThoiGian = Convert.ToDateTime(row["ThoiGian"])
            };
        }

        public int InsertLSHoatDong(LSHoatDongDTO lsHoatDong)
        {
            string query = $"INSERT INTO lichsuhoatdong (MaThanhVien, MaHoatDong, Loai, ChiTiet, ThoiGian) VALUES ({lsHoatDong.MaThanhVien}, {lsHoatDong.MaHoatDong}, '{lsHoatDong.Loai}', '{lsHoatDong.ChiTiet}', '{lsHoatDong.ThoiGian:yyyy-MM-dd HH:mm:ss}')";
            return dbConnection.ExecuteNonQuery(query);
        }

        public int UpdateLSHoatDong(LSHoatDongDTO lsHoatDong)
        {
            string query = $"UPDATE lichsuhoatdong SET Loai = '{lsHoatDong.Loai}', ChiTiet = '{lsHoatDong.ChiTiet}', ThoiGian = '{lsHoatDong.ThoiGian:yyyy-MM-dd HH:mm:ss}' WHERE MaThanhVien = {lsHoatDong.MaThanhVien} AND MaHoatDong = {lsHoatDong.MaHoatDong}";
            return dbConnection.ExecuteNonQuery(query);
        }

        public int DeleteLSHoatDong(int maThanhVien, int maHoatDong)
        {
            string query = $"DELETE FROM lichsuhoatdong WHERE MaThanhVien = {maThanhVien} AND MaHoatDong = {maHoatDong}";
            return dbConnection.ExecuteNonQuery(query);
        }

        // Lấy dữ liệu để thống kê lượt vào
        public List<Tuple<DateTime, int>> LayDuLieuLuotVao(DateTime tuNgay, DateTime denNgay)
        {
            List<Tuple<DateTime, int>> data = new List<Tuple<DateTime, int>>();
            string query = "SELECT Thoigian, COUNT(*) as SoLuot from lichsuhoatdong WHERE Loai='Vào thư quán' AND is_delete=0 AND Thoigian BETWEEN @tuNgay AND @denNgay GROUP BY Thoigian ORDER BY Thoigian";
            MySqlConnection conn = dbConnection.GetConnection();    
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@tuNgay", tuNgay.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@denNgay", denNgay.ToString("yyyy-MM-dd"));
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DateTime ngay = reader.GetDateTime("Thoigian");
                int soLuot = reader.GetInt32("SoLuot");
                data.Add(Tuple.Create(ngay, soLuot));
            }
            conn.Close();
            return data;
        }
    }
}
