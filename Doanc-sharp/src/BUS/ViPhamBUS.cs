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
    internal class ViPhamBUS
    {
        private ViPhamDAO viPhamDAO = new ViPhamDAO();
        private KhoaTheBUS khoaTheBUS = new KhoaTheBUS();

        public DataTable GetAllViPham()
        {
            return viPhamDAO.GetAllViPham();
        }

        public List<ViPhamDTO> GetAllViPhamNotTvvp()
        {
            return viPhamDAO.GetAllViPhamNotTvvp();
        }

        public ViPhamDTO GetViPhamById(int id)
        {
            return viPhamDAO.GetViPhamById(id);
        }

        public Boolean InsertViPham(NhanVienDTO nv, ViPhamDTO viPham)
        {
            return viPhamDAO.InsertViPham(nv, viPham);
        }

        public Boolean InsertTVVP(ThanhVienDTO tv, ViPhamDTO viPham, DateTime time)
        {
            return viPhamDAO.InsertTVVP(tv, viPham, time);
        }

        public void UpdateViPham(ViPhamDTO viPham)
        {
            viPhamDAO.UpdateViPham(viPham);
        }

        public void DeleteViPham(string maViPham)
        {
            viPhamDAO.DeleteViPham(maViPham);
        }
        public Boolean XulyViPham(string maViPham, int maThanhVien, DateTime thoiGianKhoa)
        {
            if (maViPham == null)
                return false;
            KhoaTheDTO khoaThe = new KhoaTheDTO() {
                MaThanhVien = maThanhVien,
                ThoiGianMoKhoa = thoiGianKhoa
            };
            return khoaTheBUS.Insert(khoaThe) && viPhamDAO.XulyViPham(maViPham);
        }
    }
}
