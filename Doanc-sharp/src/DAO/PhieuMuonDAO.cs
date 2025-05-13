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
                           $"('{pm.Maphieumuon}','{pm.Ngaymuon:yyyy-MM-dd HH:mm:ss}', '{pm.Ngaytra:yyyyy--MM-dd HH:mm:ss}', '{pm.Trangthai}', {pm.Mathanhvien})";
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

        public DataTable layDuLieuThietBiDuocMuon(DateTime tuNgay, DateTime denNgay, string tuKhoa)
        {
            string query = "SELECT tv.Hoten, tb.Tenthietbi, pm.Ngaymuon, pm.Ngaytra, pm.Trangthai, ctpm.Soluong FROM phieumuon pm " +
                "JOIN chitietphieumuon ctpm ON pm.Maphieumuon=ctpm.Maphieumuon " +
                "JOIN thietbi tb ON tb.Mathietbi=ctpm.Mathietbi " +
                "JOIN thanhvien tv ON tv.Mathanhvien=pm.Mathanhvien " +
                "WHERE pm.Ngaymuon BETWEEN @tuNgay AND @denNgay ";
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                query += "AND tb.Tenthietbi LIKE @tuKhoa ";
            }
            MySqlConnection conn = db.GetConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@tuNgay", tuNgay);
            cmd.Parameters.AddWithValue("@denNgay", denNgay);
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                cmd.Parameters.AddWithValue("@tuKhoa", "%" + tuKhoa + "%");
            }

            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        public DataTable layDuLieuThietBiDangDuocMuon(DateTime tuNgay, DateTime denNgay, string tuKhoa)
        {
            string query = "SELECT tv.Hoten, tb.Tenthietbi, pm.Ngaymuon, pm.Ngaytra, pm.Trangthai, ctpm.Soluong FROM phieumuon pm " +
                "JOIN chitietphieumuon ctpm ON pm.Maphieumuon=ctpm.Maphieumuon " +
                "JOIN thietbi tb ON tb.Mathietbi=ctpm.Mathietbi " +
                "JOIN thanhvien tv ON tv.Mathanhvien=pm.Mathanhvien " +
                "WHERE pm.Trangthai='Đang mượn' " +
                "AND pm.Ngaymuon <= @denNgay AND pm.Ngaytra >= @tuNgay ";
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                query += "AND tb.Tenthietbi LIKE @tuKhoa ";
            }
            MySqlConnection conn = db.GetConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@tuNgay", tuNgay);
            cmd.Parameters.AddWithValue("@denNgay", denNgay);
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                cmd.Parameters.AddWithValue("@tuKhoa", "%" + tuKhoa + "%");
            }

            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
    }
}
