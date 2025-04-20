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
    internal class PhieuMuonDAO
    {
        private DbConnection db;

        public PhieuMuonDAO()
        {
            db = new DbConnection();
        }

        public bool Add(PhieuMuonDTO pm)
        {
            string query = $"INSERT INTO phieumuon (Ngaymuon, Ngaytra, Trangthai, Mathanhvien) VALUES " +
                           $"('{pm.Ngaymuon:yyyy-MM-dd HH:mm:ss}', '{pm.Ngaytra}', '{pm.Trangthai}', {pm.Mathanhvien})";
            return db.ExecuteNonQuery(query) > 0;
        }

        public bool Update(PhieuMuonDTO pm)
        {
            string query = $"UPDATE phieumuon SET " +
                           $"Ngaymuon = '{pm.Ngaymuon:yyyy-MM-dd HH:mm:ss}', " +
                           $"Ngaytra = '{pm.Ngaytra}', " +
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
                    row["Ngaytra"].ToString(),
                    row["Trangthai"].ToString(),
                    Convert.ToInt32(row["Mathanhvien"])
                ));
            }

            return list;
        }
    }
}
