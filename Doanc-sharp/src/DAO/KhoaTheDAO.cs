using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using Doanc_sharp.src.DTO;
using Doanc_sharp.src.Helpers;

namespace Doanc_sharp.src.DAO
{
    public class KhoaTheDAO
    {
        private DbConnection conn;

        public KhoaTheDAO()
        {
            conn = new DbConnection();
        }

        public List<KhoaTheDTO> GetAll()
        {
            List<KhoaTheDTO> list = new List<KhoaTheDTO>();
            try
            {
                string query = "SELECT * FROM khoathe WHERE is_delete = 0";
                DataTable dt = conn.ExecuteQuery(query);
                foreach (DataRow row in dt.Rows)
                {
                    KhoaTheDTO khoaThe = new KhoaTheDTO(
                        Convert.ToInt32(row["idkhoathe"]),
                        Convert.ToInt32(row["Mathanhvien"]),
                        Convert.ToDateTime(row["thoigianmokhoa"]),
                        Convert.ToInt32(row["is_delete"])
                    );
                    list.Add(khoaThe);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách khóa thẻ: " + ex.Message);
            }
            return list;
        }

        public KhoaTheDTO GetById(int id)
        {
            KhoaTheDTO khoaThe = null;
            try
            {
                string query = $"SELECT * FROM khoathe WHERE idkhoathe = {id} AND is_delete = 0";
                DataTable dt = conn.ExecuteQuery(query);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    khoaThe = new KhoaTheDTO(
                        Convert.ToInt32(row["idkhoathe"]),
                        Convert.ToInt32(row["Mathanhvien"]),
                        Convert.ToDateTime(row["thoigianmokhoa"]),
                        Convert.ToInt32(row["is_delete"])
                    );
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thông tin khóa thẻ: " + ex.Message);
            }
            return khoaThe;
        }

        public bool Insert(KhoaTheDTO khoaThe)
        {
            try
            {
                string formattedTime = khoaThe.ThoiGianMoKhoa.ToString("yyyy-MM-dd HH:mm:ss");
                string query = $"INSERT INTO khoathe (Mathanhvien, thoigianmokhoa, is_delete) " +
                             $"VALUES ('{khoaThe.MaThanhVien}', '{formattedTime}', '{khoaThe.IsDelete}')";
                return conn.ExecuteNonQuery(query) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm khóa thẻ: " + ex.Message);
            }
        }

        public bool Update(KhoaTheDTO khoaThe)
        {
            try
            {
                string formattedTime = khoaThe.ThoiGianMoKhoa.ToString("yyyy-MM-dd HH:mm:ss");
                string query = $"UPDATE khoathe SET Mathanhvien = '{khoaThe.MaThanhVien}', " +
                             $"thoigianmokhoa = '{formattedTime}', is_delete = '{khoaThe.IsDelete}' " +
                             $"WHERE idkhoathe = '{khoaThe.IdKhoaThe}'";
                return conn.ExecuteNonQuery(query) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật khóa thẻ: " + ex.Message);
            }
        }

        public bool Delete(int id)
        {
            try
            {
                string query = $"UPDATE khoathe SET is_delete = 1 WHERE idkhoathe = '{id}'";
                return conn.ExecuteNonQuery(query) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa khóa thẻ: " + ex.Message);
            }
        }
    }
} 