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
    internal class DanhMucDAO
    {
        private DbConnection db;

        public DanhMucDAO()
        {
            db = new DbConnection();
        }

        public List<DanhMucDTO> LayDanhSachDanhMuc()
        {
            List<DanhMucDTO> list = new List<DanhMucDTO>();
            string query = "SELECT * FROM danhmuc";

            DataTable dt = db.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                DanhMucDTO dm = new DanhMucDTO
                {
                    Madanhmuc = row["Madanhmuc"].ToString(),
                    Tendanhmuc = row["Tendanhmuc"].ToString(),
                    Mota = row["Mota"].ToString()
                };

                list.Add(dm);
            }

            return list;
        }

        public Boolean Insert(DanhMucDTO dm)
        {
            string count = "SELECT COUNT(Madanhmuc) FROM danhmuc";
            string MaDM = "dm" + Convert.ToInt32(db.ExecuteScalar(count));
            string query = "INSERT INTO danhmuc(Madanhmuc, Tendanhmuc, Mota) VALUES (@maDM, @ten, @mota)";
            MySqlConnection conn = db.GetConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ten", dm.Tendanhmuc);
            cmd.Parameters.AddWithValue("@mota", dm.Mota);
            cmd.Parameters.AddWithValue("@maDM", MaDM);
            int result = cmd.ExecuteNonQuery();

            if (result > 0)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }

        }

        public Boolean Edit(DanhMucDTO dm)
        {
            string query = "UPDATE danhmuc SET Tendanhmuc = @ten, Mota = @mota WHERE Madanhmuc = @maDM";
            MySqlConnection conn = db.GetConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query,conn);
            cmd.Parameters.AddWithValue("@ten", dm.Tendanhmuc);
            cmd.Parameters.AddWithValue("@mota", dm.Mota);
            cmd.Parameters.AddWithValue("@maDM", dm.Madanhmuc);
            int result = cmd.ExecuteNonQuery();

            if (result > 0)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }

        }
    }
}
