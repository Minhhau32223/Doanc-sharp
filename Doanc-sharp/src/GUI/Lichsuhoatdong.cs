using Doanc_sharp.src.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doanc_sharp
{
    public partial class Lichsuhoatdong : UserControl
    {
        private LSHoatDongBUS lshdBUS = new LSHoatDongBUS();
        public Lichsuhoatdong()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            DataTable dt = lshdBUS.GetAllLSHoatDong();
            dataGridView1.DataSource = dt;
        }
    }
}
