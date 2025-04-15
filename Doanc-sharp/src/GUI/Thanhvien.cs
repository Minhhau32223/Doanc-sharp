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
    public partial class Thanhvien : UserControl
    {
        public Thanhvien()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            SuaThanhVien suaThanhVien = new SuaThanhVien();

        }

        private void Thanhvien_Load(object sender, EventArgs e)
        {

        }
    }
}
