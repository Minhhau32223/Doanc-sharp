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
            string query = $"SELECT tv.*, vp.*, tvvp.NgayViPham, tvvp.TrangThai " +
                          $"FROM ThanhVienViPham tvvp " +
                          $"JOIN ThanhVien tv ON tvvp.MaThanhVien = tv.MaThanhVien " +
                          $"JOIN ViPham vp ON tvvp.MaViPham = vp.MaViPham " +
                          $"WHERE tvvp.MaThanhVien = {maThanhVien}";
            return dbConnection.ExecuteQuery(query);
        }
    }
}
