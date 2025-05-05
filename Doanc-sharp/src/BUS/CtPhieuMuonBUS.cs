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
    internal class CtPhieuMuonBUS
    {
        private ChiTietPhieuMuonDAO chiTietPhieuMuonDAO;

        public CtPhieuMuonBUS()
        {
            chiTietPhieuMuonDAO = new ChiTietPhieuMuonDAO();
        }

        public bool ThemChiTiet(ChiTietPhieuMuonDTO ct)
        {
            return chiTietPhieuMuonDAO.Add(ct);
        }

        public bool CapNhatChiTiet(ChiTietPhieuMuonDTO ct)
        {
            return chiTietPhieuMuonDAO.Update(ct);
        }

        public bool XoaChiTiet(int maphieumuon)
        {
            return chiTietPhieuMuonDAO.Delete(maphieumuon);
        }

        public DataTable LayDanhSachChiTiet(int maphieumuon)
        {
            return chiTietPhieuMuonDAO.LayChiTietPhieuMuon(maphieumuon);
        }
    }
}
