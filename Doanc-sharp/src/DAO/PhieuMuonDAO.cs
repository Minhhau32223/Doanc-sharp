using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Doanc_sharp.src.DTO;
using Doanc_sharp.src.Helpers;
using MySql.Data.MySqlClient;

namespace Doanc_sharp.src.DAO
{
    internal class PhieuMuonDAO
    {
        private DbConnection db;

        public PhieuMuonDAO()
        {
            db = new DbConnection();
        }

        public bool Add(PhieuMuonDTO pm)
        {
            string query = $"INSERT INTO phieumuon (Maphieumuon,Ngaymuon, Ngaytra, Trangthai, Mathanhvien) VALUES " +
                           $"('{pm.Maphieumuon}','{pm.Ngaymuon:yyyy-MM-dd HH:mm:ss}', '{pm.Ngaytra}', '{pm.Trangthai}', {pm.Mathanhvien})";
            return db.ExecuteNonQuery(query) > 0;
        }

        public bool Update(PhieuMuonDTO pm)
        {
            string query = $"UPDATE phieumuon SET " +
                           $"Ngaymuon = '{pm.Ngaymuon:yyyy-MM-dd HH:mm:ss}', " +
                           $"Ngaytra = '{pm.Ngaytra:yyyy-MM-dd HH:mm:ss}', " +
                           $"Trangthai = '{pm.Trangthai}', " +
                           $"Mathanhvien = {pm.Mathanhvien} " +
                           $"WHERE Maphieumuon = {pm.Maphieumuon}";
            return db.ExecuteNonQuery(query) > 0;
        }

        public bool Delete(int maphieumuon)
        {
            string query = $"DELETE FROM phieumuon WHERE Maphieumuon = {maphieumuon}";
            return db.ExecuteNonQuery(query) > 0;
        }

        public List<PhieuMuonDTO> LayDanhSachPhieuMuon()
        {
            string query = "SELECT * FROM phieumuon";
            DataTable dt = db.ExecuteQuery(query);
            List<PhieuMuonDTO> list = new List<PhieuMuonDTO>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new PhieuMuonDTO(
                    Convert.ToInt32(row["Maphieumuon"]),
                    Convert.ToDateTime(row["Ngaymuon"]),
                    Convert.ToDateTime(row["Ngaytra"]),
                    row["Trangthai"].ToString(),
                    Convert.ToInt32(row["Mathanhvien"])
                ));
            }

            return list;
        }
        public PhieuMuonDTO Timkiemtheoma(int maphieumuon)
        {
            string query = $"SELECT * FROM phieumuon WHERE Maphieumuon = {maphieumuon}";
            DataTable dt = db.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                PhieuMuonDTO pm = new PhieuMuonDTO(
                    Convert.ToInt32(row["Maphieumuon"]),
                    Convert.ToDateTime(row["Ngaymuon"]),
                    Convert.ToDateTime(row["Ngaytra"]),
                    row["Trangthai"].ToString(),
                    Convert.ToInt32(row["Mathanhvien"])
                    );
                return pm;
            }
            else
            {
                // Không tìm thấy => trả về null
                return null;
            }
        }


        public List<PhieuMuonDTO> LayDanhSachPhieuTra()
        {
            string query = "SELECT * FROM phieumuon WHERE Trangthai='Đã trả'";
            DataTable dt = db.ExecuteQuery(query);
            List<PhieuMuonDTO> list = new List<PhieuMuonDTO>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new PhieuMuonDTO(
                    Convert.ToInt32(row["Maphieumuon"]),
                    Convert.ToDateTime(row["Ngaymuon"]),
                    Convert.ToDateTime(row["Ngaytra"]),
                    row["Trangthai"].ToString(),
                    Convert.ToInt32(row["Mathanhvien"])
                ));
            }

            return list;
        }

        public List<Tuple<DateTime, int>> LayDuLieuLuotMuon(DateTime tuNgay, DateTime denNgay)
        {
            List<Tuple<DateTime, int>> data = new List<Tuple<DateTime, int>>();
            string query = "SELECT DATE(Ngaymuon) AS Ngaymuon, COUNT(*) as SoLuot FROM phieumuon WHERE is_delete=0 AND Ngaymuon >= @tuNgay AND Ngaymuon <= @denNgay GROUP BY DATE(Ngaymuon) ORDER BY Ngaymuon";
            MySqlConnection conn = db.GetConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@tuNgay", tuNgay);
            cmd.Parameters.AddWithValue("@denNgay", denNgay.AddDays(1).AddSeconds(-1));
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DateTime ngay = reader.GetDateTime("Ngaymuon");
                int soLuot = reader.GetInt32("SoLuot");
                data.Add(Tuple.Create(ngay, soLuot));
            }
            conn.Close();   
            return data;
        }

        public List<Tuple<DateTime,decimal>>LayDuLieuDoanhThu(DateTime tuNgay, DateTime denNgay)
        {
            List<Tuple<DateTime, decimal>> data = new List<Tuple<DateTime, decimal>>();
            string query = "SELECT pm.Ngaymuon, SUM(tb.Giathue * ct.Soluong * " +
                "CASE WHEN DATEDIFF(pm.Ngaytra, pm.Ngaymuon) <= 0 THEN 1 " +
                "     ELSE DATEDIFF(pm.Ngaytra, pm.Ngaymuon) " +
                "END) AS DoanhThu  " +
                "FROM phieumuon pm " +
                "JOIN chitietphieumuon ct ON ct.Maphieumuon=pm.Maphieumuon " +
                "JOIN thietbi tb ON tb.Mathietbi=ct.Mathietbi " +
                "WHERE pm.Ngaymuon BETWEEN @tuNgay AND @denNgay " +
                "AND pm.is_delete=0 AND tb.is_delete=0 " +
                "GROUP BY pm.Ngaymuon " +
                "ORDER BY pm.Ngaymuon";
            MySqlConnection conn = db.GetConnection(); conn.Open();
            MySqlCommand cmd = new MySqlCommand( query, conn);
            cmd.Parameters.AddWithValue("@tuNgay", tuNgay);
            cmd.Parameters.AddWithValue("@denNgay", denNgay.AddDays(1).AddSeconds(-1));
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DateTime ngay = reader.GetDateTime("Ngaymuon");
                decimal doanhThu = reader.GetDecimal("DoanhThu");
                data.Add(Tuple.Create(ngay, doanhThu));
            }
            conn.Close();
            return data;
        }
    }
}
