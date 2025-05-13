using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Doanc_sharp.src.DAO;
using Doanc_sharp.src.DTO;
using System.Data;

namespace Doanc_sharp.src.BUS
{
    internal class LSHoatDongBUS
    {
        private LSHoatDongDAO lsHoatDongDAO = new LSHoatDongDAO();
        private ThanhVienBUS thanhVienBUS = new ThanhVienBUS();

        public DataTable GetAllLSHoatDong()
        {
            DataTable dt = lsHoatDongDAO.GetAllLSHoatDong();
            List<LSHoatDongDTO> list = new List<LSHoatDongDTO>();
            foreach (DataRow row in dt.Rows)
            {
                LSHoatDongDTO LS = new LSHoatDongDTO
                {
                    MaThanhVien = Convert.ToInt32(row["MaThanhVien"]),
                    MaHoatDong = Convert.ToInt32(row["MaHoatDong"]),
                    Loai = row["Loai"].ToString(),
                    ChiTiet = row["ChiTiet"].ToString(),
                    ThoiGian = Convert.ToDateTime(row["ThoiGian"])
                };
                LS.thanhVienDTO = thanhVienBUS.TimThanhVienTheoMa(LS.MaThanhVien);
                //MessageBox.Show(LS.thanhVienDTO.ToString());
                list.Add(LS);
            }

            DataTable resultTable = new DataTable();
            resultTable.Columns.Add("MaHoatDong", typeof(int));
            resultTable.Columns.Add("MaThanhVien", typeof(int));
            resultTable.Columns.Add("TenThanhVien", typeof(string));
            resultTable.Columns.Add("Loai", typeof(string));
            resultTable.Columns.Add("ChiTiet", typeof(string));
            resultTable.Columns.Add("ThoiGian", typeof(DateTime));
            foreach (var item in list)
            {
                resultTable.Rows.Add(item.MaHoatDong, item.MaThanhVien, item.thanhVienDTO.Hoten, item.Loai, item.ChiTiet, item.ThoiGian);
            }
            return resultTable;
        }

        public LSHoatDongDTO GetLSHoatDongById(int maThanhVien, int maHoatDong)
        {
            return lsHoatDongDAO.GetLSHoatDongById(maThanhVien, maHoatDong);
        }

        public Boolean InsertLSHoatDong(LSHoatDongDTO lsHoatDong)
        {
            return lsHoatDongDAO.InsertLSHoatDong(lsHoatDong) > 0;
        }

        public Boolean UpdateLSHoatDong(LSHoatDongDTO lsHoatDong)
        {
            return lsHoatDongDAO.UpdateLSHoatDong(lsHoatDong) > 0;
        }

        public Boolean DeleteLSHoatDong(int maThanhVien, int maHoatDong)
        {
            return lsHoatDongDAO.DeleteLSHoatDong(maThanhVien, maHoatDong) > 0;
        }



        //others method
        public DataTable TimKiemLSHoatDong(string findData)
        {
            DataTable dt = lsHoatDongDAO.GetAllLSHoatDong();
            List<LSHoatDongDTO> list = new List<LSHoatDongDTO>();
            foreach (DataRow row in dt.Rows)
            {
                LSHoatDongDTO LS = new LSHoatDongDTO
                {
                    MaThanhVien = Convert.ToInt32(row["MaThanhVien"]),
                    MaHoatDong = Convert.ToInt32(row["MaHoatDong"]),
                    Loai = row["Loai"].ToString(),
                    ChiTiet = row["ChiTiet"].ToString(),
                    ThoiGian = Convert.ToDateTime(row["ThoiGian"])
                };
                LS.thanhVienDTO = thanhVienBUS.TimThanhVienTheoMa(LS.MaThanhVien);
                //MessageBox.Show(LS.thanhVienDTO.ToString());
                list.Add(LS);
            }

            DataTable resultTable = new DataTable();
            resultTable.Columns.Add("MaHoatDong", typeof(int));
            resultTable.Columns.Add("MaThanhVien", typeof(int));
            resultTable.Columns.Add("TenThanhVien", typeof(string));
            resultTable.Columns.Add("Loai", typeof(string));
            resultTable.Columns.Add("ChiTiet", typeof(string));
            resultTable.Columns.Add("ThoiGian", typeof(DateTime));
            foreach (var item in list)
            {
                if (item.thanhVienDTO.Hoten.ToLower().Contains(findData.ToLower()) 
                    || item.Loai.ToLower().Contains(findData.ToLower()) 
                    || item.ChiTiet.ToLower().Contains(findData.ToLower())
                    || item.ThoiGian.ToString().ToLower().Contains(findData.ToLower())
                    || item.MaHoatDong.ToString().ToLower().Contains(findData.ToLower())
                    || item.MaThanhVien.ToString().ToLower().Contains(findData.ToLower())
                    )
                    resultTable.Rows.Add(item.MaHoatDong, item.MaThanhVien, item.thanhVienDTO.Hoten, item.Loai, item.ChiTiet, item.ThoiGian);
            }
            return resultTable;
        }

        public DataTable filterLSHDByTime(DateTime timeStart)
        {
            DataTable dt = lsHoatDongDAO.GetAllLSHoatDong();
            List<LSHoatDongDTO> list = new List<LSHoatDongDTO>();
            foreach (DataRow row in dt.Rows)
            {
                LSHoatDongDTO LS = new LSHoatDongDTO
                {
                    MaThanhVien = Convert.ToInt32(row["MaThanhVien"]),
                    MaHoatDong = Convert.ToInt32(row["MaHoatDong"]),
                    Loai = row["Loai"].ToString(),
                    ChiTiet = row["ChiTiet"].ToString(),
                    ThoiGian = Convert.ToDateTime(row["ThoiGian"])
                };
                LS.thanhVienDTO = thanhVienBUS.TimThanhVienTheoMa(LS.MaThanhVien);
                list.Add(LS);
            }

            DataTable resultTable = new DataTable();
            resultTable.Columns.Add("MaHoatDong", typeof(int));
            resultTable.Columns.Add("MaThanhVien", typeof(int));
            resultTable.Columns.Add("TenThanhVien", typeof(string));
            resultTable.Columns.Add("Loai", typeof(string));
            resultTable.Columns.Add("ChiTiet", typeof(string));
            resultTable.Columns.Add("ThoiGian", typeof(DateTime));
            foreach (var item in list)
            {
                if (item.ThoiGian > timeStart)
                    resultTable.Rows.Add(item.MaHoatDong, item.MaThanhVien, item.thanhVienDTO.Hoten, item.Loai, item.ChiTiet, item.ThoiGian);
            }
            return resultTable;
        }
        //public List<Tuple<DateTime, int>> LayDuLieuLuotVao(DateTime tuNgay, DateTime denNgay)
        //{
        //    return lsHoatDongDAO.LayDuLieuLuotVao(tuNgay, denNgay);
        //}

        public List<Tuple<int, string, string, string, DateTime, int>> layDuLieuLuotVao(DateTime tuNgay, DateTime denNgay)
        {
            return lsHoatDongDAO.layDuLieuLuotVao(tuNgay, denNgay);
        }

    }
}
