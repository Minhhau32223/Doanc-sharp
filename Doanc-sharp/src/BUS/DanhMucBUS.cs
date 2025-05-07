using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Doanc_sharp.src.DAO;
using Doanc_sharp.src.DTO;

namespace Doanc_sharp.src.BUS
{
    internal class DanhMucBUS
    {
        private List<DanhMucDTO> dsdm { get; set; }
        private DanhMucDAO dao { get; set; }

        public DanhMucBUS()
        {
        }
        public List<DanhMucDTO> LayDSDM()
        {
            try
            {
                dao = new DanhMucDAO();
                List<DanhMucDTO> temp = new List<DanhMucDTO>();

                temp = dao.LayDanhSachDanhMuc();
                if (temp != null)
                {
                    dsdm = temp;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            return dsdm;
        }

        public Boolean ThemDanhMuc(DanhMucDTO dm)
        {
            try
            {
                dao = new DanhMucDAO();
                if (dao.Insert(dm))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }

        public Boolean SuaDanhMuc(DanhMucDTO dm)
        {
            try
            {
                dao = new DanhMucDAO();
                if (dao.Edit(dm))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }
    }
}
