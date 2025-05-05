using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Doanc_sharp.src.Helpers;

using Doanc_sharp.src.DTO;

using System.Data;
namespace Doanc_sharp.src.DAO
{
    internal class ThanhVienDAO
{
    private DbConnection db;
    public ThanhVienDAO()
    {
        db = new DbConnection();
    }
    public List<ThanhVienDTO> LayDanhSachThanhVien()
    {
        List<ThanhVienDTO> list = new List<ThanhVienDTO>();
        string query = "SELECT * FROM thanhvien WHERE is_delete=0";

        DataTable table = db.ExecuteQuery(query);
        foreach (DataRow row in table.Rows)
        {
            ThanhVienDTO thanhvien = new ThanhVienDTO
            {
                Mathanhvien = Convert.ToInt32(row["Mathanhvien"]),
                Hoten = row["Hoten"].ToString(),
                Taikhoan = row["Taikhoan"].ToString(),
                Matkhau = row["Matkhau"].ToString(),
                Diachi = row["Diachi"].ToString(),
                Sdt = Convert.ToInt32(row["Sdt"]),
                Ngaydangky = Convert.ToDateTime(row["Ngaydangky"]),
                Trangthai = row["Trangthai"].ToString(),
                Email = row["Email"].ToString(),
            };
            list.Add(thanhvien);
        }
        return list;
    }
    public bool ThemThanhVien(ThanhVienDTO thanhVien)
    {
        try
        {
            string query = $"INSERT INTO thanhvien (Mathanhvien, Hoten, Taikhoan, Matkhau, Diachi, Sdt, Ngaydangky, Trangthai, Email) " +
            $"VALUES ('{thanhVien.Mathanhvien}',N'{thanhVien.Hoten}', '{thanhVien.Taikhoan}', '{thanhVien.Matkhau}', " +
            $"N'{thanhVien.Diachi}', {thanhVien.Sdt}, '{thanhVien.Ngaydangky:yyyy-MM-dd HH:mm:ss}', " +
            $"'{thanhVien.Trangthai}', '{thanhVien.Email}')";

            int result = db.ExecuteNonQuery(query);
            return result > 0;
        }
        catch (Exception ex)
        {
            throw new Exception("Lỗi khi thêm thành viên: " + ex.Message);
        }
    }
    public bool CapNhatThanhVien(ThanhVienDTO thanhVien)
    {
        try
        {
            string query = $"UPDATE thanhvien SET " +
                         $"Hoten = N'{thanhVien.Hoten}', " +
                         $"Taikhoan = '{thanhVien.Taikhoan}', " +
                         $"Matkhau = '{thanhVien.Matkhau}', " +
                         $"Diachi = N'{thanhVien.Diachi}', " +
                         $"Sdt = {thanhVien.Sdt}, " +
                         $"Ngaydangky = '{thanhVien.Ngaydangky:yyyy-MM-dd HH:mm:ss}', " +
                         $"Trangthai = '{thanhVien.Trangthai}', " +
                         $"Email = '{thanhVien.Email}' " +
                         $"WHERE Mathanhvien = {thanhVien.Mathanhvien}";

            int result = db.ExecuteNonQuery(query);
            return result > 0;
        }
        catch (Exception ex)
        {
            throw new Exception("Lỗi khi cập nhật thành viên: " + ex.Message);
        }
    }
        public bool XoaThanhVien (int Mathanhvien)
        {
            try
            {
                string query = "UPDATE thanhvien SET is_delete = @IsDelete WHERE Mathanhvien = @Mathanhvien ";
                var parameters = new Dictionary<string, object>
                {
                    {"@IsDelete", true },
                    {"@Mathanhvien", Mathanhvien }
                };
                int result = db.ExecuteNonQuery(query);
                if (result == 0)
                {
                    throw new KeyNotFoundException($"Không tìm thấy thành viên có mã {Mathanhvien}");
                }
                return true;
            }
            catch (KeyNotFoundException)
            {
                throw; // Re-throw exception đặc biệt này
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi cập nhật trạng thái xóa cho thành viên {Mathanhvien}: {ex.Message}");
            }
        }
        public bool CapNhatTrangThaiXoa(int maThanhVien, bool isDeleted)
        {
            string query = string.Format(
                "UPDATE thanhvien SET is_delete = {0} WHERE Mathanhvien = {1}",
                isDeleted ? 1 : 0,
                maThanhVien);

            int result = db.ExecuteNonQuery(query); 
            return result > 0;
        }
        public int XoaNhieuThanhVienTheoNam(int nam)
        {
            try
            {
                string query = $"UPDATE thanhvien SET is_delete = 1 WHERE YEAR(Ngaydangky) = {nam}";
                return db.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa nhiều thành viên: " + ex.Message);
            }
        }
        public ThanhVienDTO TimThanhVienTheoMa(int maThanhVien)
        {
            try
            {
                string query = $"SELECT * FROM thanhvien WHERE Mathanhvien = {maThanhVien} ";
                DataTable table = db.ExecuteQuery(query);

                if (table.Rows.Count == 0)
                {
                    return null; // Không tìm thấy
                }

                DataRow row = table.Rows[0];
                return new ThanhVienDTO
                {
                    Mathanhvien = Convert.ToInt32(row["Mathanhvien"]),
                    Hoten = row["Hoten"].ToString(),
                    Taikhoan = row["Taikhoan"].ToString(),
                    Matkhau = row["Matkhau"].ToString(),
                    Diachi = row["Diachi"].ToString(),
                    Sdt = Convert.ToInt32(row["Sdt"]),
                    Ngaydangky = Convert.ToDateTime(row["Ngaydangky"]),
                    Trangthai = row["Trangthai"].ToString(),
                    Email = row["Email"].ToString()
                };
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm thành viên theo mã: " + ex.Message);
            }
        }

    }
}
