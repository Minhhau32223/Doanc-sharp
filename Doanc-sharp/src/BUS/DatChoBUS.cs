using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Doanc_sharp.src.DAO;

using Doanc_sharp.src.DTO;

namespace Doanc_sharp.src.BUS
{
    internal class DatChoBUS
    {
        private DatChoDAO dao { get; set; }
        private List<DatChoDTO> dsdc { get; set; } 

        public DatChoBUS() {
        }
        public List<DatChoDTO> docDsdc()
        {
            try
            {
                dao = new DatChoDAO();
                List<DatChoDTO> temp = new List<DatChoDTO>();

                temp = dao.LayDanhSachDatCho();
                if (temp != null)
                {
                    dsdc = temp;
                }



            }
            catch (Exception ex)
            {

            }


            return dsdc;
        }
        public bool Add(DatChoDTO dc)
        {
            return dao.ADD(dc);
        }
        public bool Update(DatChoDTO dc)
        {
            return dao.Update(dc);
        }
        public bool Delete(int madatcho) {
            return dao.Delete(madatcho);

        }
        public DatChoDTO Timkiemtheoma(int madatcho)
        {
            dao = new DatChoDAO();
            return dao.Timkiemtheoma(madatcho);
        }


    }
}
