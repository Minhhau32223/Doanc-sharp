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

        public DataTable GetAllViPham()
        {
            return viPhamDAO.GetAllViPham();
        }

        public ViPhamDTO GetViPhamById(int id)
        {
            return viPhamDAO.GetViPhamById(id);
        }

        public void InsertViPham(ViPhamDTO viPham)
        {
            viPhamDAO.InsertViPham(viPham);
        }

        public void UpdateViPham(ViPhamDTO viPham)
        {
            viPhamDAO.UpdateViPham(viPham);
        }

        public void DeleteViPham(string maViPham)
        {
            viPhamDAO.DeleteViPham(maViPham);
        }
        public int countViPham()
        {
            return viPhamDAO.countViPham();
        }
    }
}
