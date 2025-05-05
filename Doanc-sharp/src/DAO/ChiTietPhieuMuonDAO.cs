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
            string query = $"INSERT INTO chitietphieumuon (Maphieumuon, Mathietbi, Soluong) VALUES " +
                           $"({ct.Maphieumuon}, {ct.Mathietbi}, {ct.Soluong})";
            return db.ExecuteNonQuery(query) > 0;
        }

        public bool Update(ChiTietPhieuMuonDTO ct)
        {
            string query = $"UPDATE chitietphieumuon SET " +
                           $"Soluong = {ct.Soluong}, " +
                       
                           $"WHERE Maphieumuon = {ct.Maphieumuon} AND Mathietbi = {ct.Mathietbi}";
            return db.ExecuteNonQuery(query) > 0;
        }

        public bool Delete(int maphieumuon)
        {
            string query = $"DELETE FROM chitietphieumuon WHERE Maphieumuon = {maphieumuon} ";
            return db.ExecuteNonQuery(query) > 0;
        }

        public DataTable LayChiTietPhieuMuon(int maphieumuon)
        {
            string query = $"SELECT ctpm.Mathietbi , tb.Tenthietbi, ctpm.Soluong FROM chitietphieumuon ctpm JOIN thietbi tb ON tb.Mathietbi=ctpm.Mathietbi WHERE Maphieumuon = {maphieumuon}";
            return db.ExecuteQuery(query);
           }
    }
}
