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
    internal class CtDatChoDAO
    {
        private DbConnection db;

        public CtDatChoDAO()
        {
            db = new DbConnection();
        }

   
        public bool Add(CtDatChoDTO ct)
        {
            string query = $"INSERT INTO chitietdatcho (Madatcho, Mathanhvien, Soluong) VALUES " +
                           $"({ct.Madatcho}, {ct.Mathanhvien}, {ct.Soluong})";
            return db.ExecuteNonQuery(query) > 0;
        }

 
        public bool Update(CtDatChoDTO ct)
        {
            string query = $"UPDATE chitietdatcho SET " +
                           $"Soluong = {ct.Soluong} " +
                           $"WHERE Madatcho = {ct.Madatcho} AND Mathanhvien = {ct.Mathanhvien}";
            return db.ExecuteNonQuery(query) > 0;
        }

  
        public bool Delete(int madatcho, int mathanhvien)
        {
            string query = $"DELETE FROM chitietdatcho WHERE Madatcho = {madatcho} AND Mathanhvien = {mathanhvien}";
            return db.ExecuteNonQuery(query) > 0;
        }


        public DataTable LayChiTietTheoMaDatCho(int madatcho)
        {
            string query = $"SELECT  ctdc.Mathietbi , tb.Tenthietbi, ctdc.Soluong FROM chitietdatcho  ctdc JOIN thietbi tb on ctdc.Mathietbi= tb.Mathietbi WHERE Madatcho = {madatcho}";
           return db.ExecuteQuery(query);
            
        }

    }
}
