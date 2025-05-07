using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Doanc_sharp.src.DAO;
using Doanc_sharp.src.DTO;

namespace Doanc_sharp.src.BUS
{
    internal class ThietBiBUS
    {
       
        private ThietBiDAO thietBiDAO;

        public ThietBiBUS()
        {
            thietBiDAO = new ThietBiDAO();
        }

        public List<ThietBiDTO> LayDanhSachThietBi()
        {
            return thietBiDAO.LayDanhSachThietBi();
        }

        public bool ThemThietBi(ThietBiDTO tb)
        {
            return thietBiDAO.ThemThietBi(tb);
        }

        public bool CapNhatThietBi(ThietBiDTO tb)
        {
            return thietBiDAO.CapNhatThietBi(tb);
        }

        public bool XoaThietBi(int mathietbi)
        {
            return thietBiDAO.XoaThietBi(mathietbi);
        }

        public bool XoaTheoMaDanhMuc(string madanhmuc)
        {
            return thietBiDAO.XoaTheoMaDanhMuc(madanhmuc);
        }
        public DataTable Timkiemtheoma(int mathietbi)
        {
            return thietBiDAO.TimKiemTheoMa(mathietbi);
        }
        public int countThietBi()
        {
            return thietBiDAO.count();
        }
        public int countThietBiDaThue()
        {
            return thietBiDAO.countDaThue();
        }
    }
}
