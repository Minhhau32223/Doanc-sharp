using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Doanc_sharp.src.BUS;
using Doanc_sharp.src.DTO;

namespace Doanc_sharp
{
    public partial class DatCho : UserControl
    {
        private DatChoBUS bus;
        public DatCho()
        {
            InitializeComponent();
        }

        private void tblDatCho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void load_data()
        {
            bus = new DatChoBUS();

            List<DatChoDTO> list = bus.docDsdc();
            tblDatCho.AutoGenerateColumns = false;
            tblDatCho.DataSource = list;
        }

        private void DatCho_Load(object sender, EventArgs e)
        {
            load_data();

        }

        private void btnXemct_Click(object sender, EventArgs e)
        {
            if (tblDatCho.CurrentRow != null)
            {   
                string madatcho = Convert.ToString(tblDatCho.CurrentRow.Cells["Madatcho"].Value.ToString());
                string mathanhvien = Convert.ToString(tblDatCho.CurrentRow.Cells["Mathanhvien"].Value.ToString());
                string ngaydat = Convert.ToString(tblDatCho.CurrentRow.Cells["Thoigiandat"].Value.ToString());
                string trangthai = Convert.ToString(tblDatCho.CurrentRow.Cells["Trangthai"].Value.ToString());
                ChiTietDatCho chiTietDatCho = new ChiTietDatCho();
                chiTietDatCho.loadct(madatcho, mathanhvien, ngaydat, trangthai);

                chiTietDatCho.ShowDialog();
            }


        }
    }
}
