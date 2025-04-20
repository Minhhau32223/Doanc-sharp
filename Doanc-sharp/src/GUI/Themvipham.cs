using Doanc_sharp.src.BUS;
using Doanc_sharp.src.DTO;
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
    public partial class Themvipham : Form
    {
        ViPhamBUS viPhamBUS = new ViPhamBUS();
        public Themvipham()
        {
            InitializeComponent();
        }

        private void ThoatBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void XacnhanBtn_Click(object sender, EventArgs e)
        {
            ViPhamDTO viPham = new ViPhamDTO();
            //viPham. = MaviphamTxt.Text;
            //viPham.Tenvipham = TenviphamTxt.Text;
            
        }
    }
}
