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
    internal class CtDatChoBUS
    {
        private CtDatChoDAO ctDatChoDAO;

        public CtDatChoBUS()
        {
            ctDatChoDAO = new CtDatChoDAO();
        }

        public bool ThemCtDatCho(CtDatChoDTO ct)
        {
            return ctDatChoDAO.Add(ct);
        }

        public bool CapNhatCtDatCho(CtDatChoDTO ct)
        {
            return ctDatChoDAO.Update(ct);
        }

        public bool XoaCtDatCho(int madatcho, int mathanhvien)
        {
            return ctDatChoDAO.Delete(madatcho, mathanhvien);
        }

        public DataTable LayDanhSachChiTietTheoMaDatCho(int madatcho)
        {
            return ctDatChoDAO.LayChiTietTheoMaDatCho(madatcho);
        }
    }
}

