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

        public KiemTraDTO KiemTraThanhVien(int maThanhVien)
        {
            DataTable dt = GetViPhamByThanhVien(maThanhVien);
            List<ThanhVienViPhamDTO> viPhamList = new List<ThanhVienViPhamDTO>();

            foreach (DataRow row in dt.Rows)
            {
                ThanhVienDTO thanhVien = new ThanhVienDTO
                {
                    MaThanhVien = Convert.ToInt32(row["MaThanhVien"]),
                    HoTen = row["HoTen"].ToString(),
                    SoDienThoai = row["SoDienThoai"].ToString(),
                    DiaChi = row["DiaChi"].ToString(),
                    Email = row["Email"].ToString(),
                    NgayDangKy = Convert.ToDateTime(row["NgayDangKy"]),
                    TrangThai = row["TrangThai"].ToString()
                };

                ViPhamDTO viPham = new ViPhamDTO
                {
                    MaViPham = row["MaViPham"].ToString(),
                    TenViPham = row["TenViPham"].ToString(),
                    MoTa = row["MoTa"].ToString()
                };

                ThanhVienViPhamDTO tvvp = new ThanhVienViPhamDTO(
                    thanhVien,
                    viPham,
                    Convert.ToDateTime(row["NgayViPham"]),
                    row["TrangThai"].ToString()
                );

                viPhamList.Add(tvvp);
            }

            KiemTraDTO kiemTra = new KiemTraDTO
            {
                ViPham = viPhamList
            };
            return kiemTra;
        }
    }
}
