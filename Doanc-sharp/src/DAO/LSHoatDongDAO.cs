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
            string query = $"SELECT * FROM lichsuhoatdong WHERE Mathanhvien = {maThanhVien} AND Mahoatdong = {maHoatDong}";
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
            string query = $"INSERT INTO lichsuhoatdong (MaThanhVien, Mahoatdong, Loai, Chitiet, Thoigian) VALUES ({lsHoatDong.MaThanhVien}, {lsHoatDong.MaHoatDong}, '{lsHoatDong.Loai}', '{lsHoatDong.ChiTiet}', '{lsHoatDong.ThoiGian:yyyy-MM-dd HH:mm:ss}')";
            return dbConnection.ExecuteNonQuery(query);
        }

        public int UpdateLSHoatDong(LSHoatDongDTO lsHoatDong)
        {
            string query = $"UPDATE lichsuhoatdong SET Loai = '{lsHoatDong.Loai}', ChiTiet = '{lsHoatDong.ChiTiet}', ThoiGian = '{lsHoatDong.ThoiGian:yyyy-MM-dd HH:mm:ss}' WHERE MaThanhVien = {lsHoatDong.MaThanhVien} AND Mahoatdong = {lsHoatDong.MaHoatDong}";
            return dbConnection.ExecuteNonQuery(query);
        }

        public int DeleteLSHoatDong(int maThanhVien, int maHoatDong)
        {
            string query = $"DELETE FROM lichsuhoatdong WHERE MaThanhVien = {maThanhVien} AND MaHoatDong = {maHoatDong}";
            return dbConnection.ExecuteNonQuery(query);
        }

        //// Lấy dữ liệu để thống kê lượt vào
        //public List<Tuple<DateTime, int>> LayDuLieuLuotVao(DateTime tuNgay, DateTime denNgay)
        //{// GROUP BY Thoigian ORDER BY Thoigian
        //    List<Tuple<DateTime, int>> data = new List<Tuple<DateTime, int>>();
        //    string query = "SELECT DATE_FORMAT(Thoigian, '%Y-%m') as Thang, COUNT(*) as SoLuot from lichsuhoatdong WHERE Loai='Vào thư quán' AND is_delete=0 AND Thoigian BETWEEN @tuNgay AND @denNgay GROUP BY DATE_FORMAT(Thoigian, '%Y-%m') ORDER BY Thang"; 
        //    MySqlConnection conn = dbConnection.GetConnection();
        //    conn.Open();
        //    MySqlCommand cmd = new MySqlCommand(query, conn);
        //    cmd.Parameters.AddWithValue("@tuNgay", tuNgay.ToString("yyyy-MM-dd"));
        //    cmd.Parameters.AddWithValue("@denNgay", denNgay.ToString("yyyy-MM-dd"));
        //    MySqlDataReader reader = cmd.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        //DateTime ngay = reader.GetDateTime("Thoigian");
        //        DateTime thang = DateTime.ParseExact(reader.GetString("Thang"), "yyyy-MM", null);
        //        int soLuot = reader.GetInt32("SoLuot");
        //        data.Add(Tuple.Create(thang, soLuot));
        //    }
        //    //reader.Close(); 
        //    conn.Close();
        //    return data;
        //}

        public List<Tuple<int, string, string, string, DateTime, int>> layDuLieuLuotVao(DateTime tuNgay, DateTime denNgay)
        {
            string query = "SELECT tv.Mathanhvien, tv.Hoten, ls.Loai, ls.Chitiet, ls.Thoigian, COUNT(*) AS SoLuong " +
                "FROM lichsuhoatdong ls, thanhvien tv" +
                " WHERE tv.Mathanhvien=ls.Mathanhvien " +
                "AND ls.Loai COLLATE utf8mb4_general_ci = \"Vao thu quan\" " +
                "AND ls.is_delete = 0 AND ls.Thoigian BETWEEN @tuNgay AND @denNgay " +
                "GROUP BY  tv.Mathanhvien, tv.Hoten, ls.Loai, ls.Chitiet, ls.Thoigian " +
                "ORDER BY ls.Thoigian";
            List<Tuple<int, string, string, string, DateTime, int >> data = new List<Tuple<int, string, string, string, DateTime, int>>();
            MySqlConnection conn = dbConnection.GetConnection();    
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@tuNgay", tuNgay.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@denNgay", denNgay.ToString("yyyy-MM-dd"));
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int maThanhVien = reader.GetInt32("Mathanhvien");
                string hoTen = reader.GetString("Hoten");
                string loai = reader.GetString("Loai");
                string chiTiet = reader.GetString("Chitiet");
                DateTime thoiGian = reader.GetDateTime("Thoigian");
                int soLuong = reader.GetInt32("SoLuong");
                data.Add(Tuple.Create(maThanhVien, hoTen, loai, chiTiet, thoiGian, soLuong));
            }
            conn.Close();
            return data;
        }
    }
}
