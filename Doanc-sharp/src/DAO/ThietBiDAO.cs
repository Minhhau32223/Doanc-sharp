using System;
using System.Collections.Generic;
using System.Data;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Doanc_sharp.src.Helpers;

using Doanc_sharp.src.DTO;
namespace Doanc_sharp.src.DAO
{
    internal class ThietBiDAO
    {
        private DbConnection db;

        public ThietBiDAO()
        {
            db = new DbConnection();
        }

        public List<ThietBiDTO> LayDanhSachThietBi()
        {
            List<ThietBiDTO> list = new List<ThietBiDTO>();
            string query = "SELECT * FROM thietbi";

            DataTable table = db.ExecuteQuery(query);
            foreach (DataRow row in table.Rows)
            {
                ThietBiDTO thietbi = new ThietBiDTO
                {
                    Mathietbi = Convert.ToInt32(row["Mathietbi"]),
                    Tenthietbi = row["Tenthietbi"].ToString(),
                    Madanhmuc = row["Madanhmuc"].ToString(),
                    Giathue = Convert.ToInt32(row["Giathue"]),
                    Trangthai = row["Trangthai"].ToString(),
                };
                list.Add(thietbi);
            }
            return list;
        }
        public bool ThemThietBi(ThietBiDTO tb)
        {
            string query = $"INSERT INTO thietbi (Tenthietbi, Madanhmuc, Trangthai, Giathue) " +
                           $"VALUES (N'{tb.Tenthietbi}', N'{tb.Madanhmuc}', N'{tb.Trangthai}', {tb.Giathue})";
            return db.ExecuteNonQuery(query)>0;
        }

        public bool CapNhatThietBi(ThietBiDTO tb)
        {
            string query = $"UPDATE thietbi SET " +
                           $"Tenthietbi = N'{tb.Tenthietbi}', " +
                           $"Madanhmuc = N'{tb.Madanhmuc}', " +
                           $"Trangthai = N'{tb.Trangthai}', " +
                           $"Giathue = {tb.Giathue} " +
                           $"WHERE Mathietbi = {tb.Mathietbi}";
            return db.ExecuteNonQuery(query)>0;
        }

        public bool XoaThietBi(int mathietbi)
        {
            string query = $"DELETE FROM thietbi WHERE Mathietbi = {mathietbi}";
            return db.ExecuteNonQuery(query)>0;
        }

        public bool XoaTheoMaDanhMuc(string madanhmuc)
        {
            string query = $"DELETE FROM thietbi WHERE Madanhmuc = N'{madanhmuc}'";
            return db.ExecuteNonQuery(query)>0;
        }
        public DataTable TimKiemTheoMa(int mathietbi)
        {
          
            string query = $"SELECT * FROM thietbi WHERE Mathietbi={mathietbi}";

            return db.ExecuteQuery(query);
        }
    }
}
