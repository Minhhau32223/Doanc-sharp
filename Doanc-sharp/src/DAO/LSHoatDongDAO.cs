using Doanc_sharp.src.DTO;
using Doanc_sharp.src.Helpers;
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
            string query = "SELECT * FROM LSHoatDong";
            return dbConnection.ExecuteQuery(query);
        }

        public LSHoatDongDTO GetLSHoatDongById(int maThanhVien, int maHoatDong)
        {
            string query = $"SELECT * FROM LSHoatDong WHERE MaThanhVien = {maThanhVien} AND MaHoatDong = {maHoatDong}";
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
            string query = $"INSERT INTO LSHoatDong (MaThanhVien, MaHoatDong, Loai, ChiTiet, ThoiGian) VALUES ({lsHoatDong.MaThanhVien}, {lsHoatDong.MaHoatDong}, '{lsHoatDong.Loai}', '{lsHoatDong.ChiTiet}', '{lsHoatDong.ThoiGian:yyyy-MM-dd HH:mm:ss}')";
            return dbConnection.ExecuteNonQuery(query);
        }

        public int UpdateLSHoatDong(LSHoatDongDTO lsHoatDong)
        {
            string query = $"UPDATE LSHoatDong SET Loai = '{lsHoatDong.Loai}', ChiTiet = '{lsHoatDong.ChiTiet}', ThoiGian = '{lsHoatDong.ThoiGian:yyyy-MM-dd HH:mm:ss}' WHERE MaThanhVien = {lsHoatDong.MaThanhVien} AND MaHoatDong = {lsHoatDong.MaHoatDong}";
            return dbConnection.ExecuteNonQuery(query);
        }

        public int DeleteLSHoatDong(int maThanhVien, int maHoatDong)
        {
            string query = $"DELETE FROM LSHoatDong WHERE MaThanhVien = {maThanhVien} AND MaHoatDong = {maHoatDong}";
            return dbConnection.ExecuteNonQuery(query);
        }
    }
}
