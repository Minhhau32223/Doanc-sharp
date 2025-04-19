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

        public DataTable GetAllLSHoatDong()
        {
            return lsHoatDongDAO.GetAllLSHoatDong();
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
            string query = $"SELECT * FROM lichsuhoatdong WHERE MaThanhVien LIKE '%{findData}%' OR MaHoatDong LIKE '%{findData}%' OR Loai LIKE '%{findData}%' OR ChiTiet LIKE '%{findData}%' OR ThoiGian LIKE '%{findData}%'";
            return lsHoatDongDAO.customExecuteQuery(query);
        }

    }
}
