using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Doanc_sharp.src.DTO;
using Doanc_sharp.src.Helpers;
using System.Data;

namespace Doanc_sharp.src.DAO
{
    internal class KiemTraDAO
    {
        private DbConnection dbConnection;
        public KiemTraDAO() 
        {
            dbConnection = new DbConnection();
        }

        public DataTable GetViPhamByThanhVien(int maThanhVien)
        {
            string query = $"SELECT *" +
                          $"FROM thanhvienvipham tvvp " +
                          $"WHERE tvvp.Mathanhvien = {maThanhVien}";
            return dbConnection.ExecuteQuery(query);
        }
    }
}
