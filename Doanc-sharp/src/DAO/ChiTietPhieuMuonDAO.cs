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
    internal class ChiTietPhieuMuonDAO
    {
        private DbConnection db;

        public ChiTietPhieuMuonDAO()
        {
            db = new DbConnection();
        }

        public bool Add(ChiTietPhieuMuonDTO ct)
        {
            string query = $"INSERT INTO chitietphieumuon (Maphieumuon, Mathietbi, Soluong, Trangthai) VALUES " +
                           $"({ct.Maphieumuon}, {ct.Mathietbi}, {ct.Soluong}, '{ct.Trangthai}')";
            return db.ExecuteNonQuery(query) > 0;
        }

        public bool Update(ChiTietPhieuMuonDTO ct)
        {
            string query = $"UPDATE chitietphieumuon SET " +
                           $"Soluong = {ct.Soluong}, " +
                           $"Trangthai = '{ct.Trangthai}' " +
                           $"WHERE Maphieumuon = {ct.Maphieumuon} AND Mathietbi = {ct.Mathietbi}";
            return db.ExecuteNonQuery(query) > 0;
        }

        public bool Delete(int maphieumuon, int mathietbi)
        {
            string query = $"DELETE FROM chitietphieumuon WHERE Maphieumuon = {maphieumuon} AND Mathietbi = {mathietbi}";
            return db.ExecuteNonQuery(query) > 0;
        }

        public List<ChiTietPhieuMuonDTO> LayChiTietPhieuMuon(int maphieumuon)
        {
            string query = $"SELECT * FROM chitietphieumuon WHERE Maphieumuon = {maphieumuon}";
            DataTable dt = db.ExecuteQuery(query);
            List<ChiTietPhieuMuonDTO> list = new List<ChiTietPhieuMuonDTO>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new ChiTietPhieuMuonDTO(
                    Convert.ToInt32(row["Maphieumuon"]),
                    Convert.ToInt32(row["Mathietbi"]),
                    Convert.ToInt32(row["Soluong"]),
                    row["Trangthai"].ToString()
                ));
            }

            return list;
        }
    }
}
