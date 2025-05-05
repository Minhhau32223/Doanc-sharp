using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Doanc_sharp.src.DAO;
using Doanc_sharp.src.DTO;

namespace Doanc_sharp.src.BUS
{
    internal class PhieuMuonBUS
    {
        private PhieuMuonDAO phieuMuonDAO;

        public PhieuMuonBUS()
        {
            phieuMuonDAO = new PhieuMuonDAO();
        }

        public bool ThemPhieuMuon(PhieuMuonDTO pm)
        {
            return phieuMuonDAO.Add(pm);
        }

        public bool CapNhatPhieuMuon(PhieuMuonDTO pm)
        {
            return phieuMuonDAO.Update(pm);
        }

        public bool XoaPhieuMuon(int maphieumuon)
        {
            return phieuMuonDAO.Delete(maphieumuon);
        }

        public List<PhieuMuonDTO> LayDanhSachPhieuMuon()
        {
            return phieuMuonDAO.LayDanhSachPhieuMuon();
        }
        public List<PhieuMuonDTO> LayDanhSachPhieuTra()
        {
            return phieuMuonDAO.LayDanhSachPhieuTra();
        }
        public PhieuMuonDTO Timkiemtheoma(int maphieumuon) {
            return phieuMuonDAO.Timkiemtheoma(maphieumuon);
        }
        
    }
}
