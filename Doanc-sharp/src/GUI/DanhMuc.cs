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
    public partial class DanhMuc : UserControl
    {
        private DanhMucBUS DanhMucBus;
        public DanhMuc()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            DanhMucBus = new DanhMucBUS();
            List<DanhMucDTO> list = DanhMucBus.LayDSDM();
            DataDanhMuc.AutoGenerateColumns = false;
            DataDanhMuc.DataSource = list;

        }

        private void DanhMuc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (DataDanhMuc.SelectedRows.Count > 0)
            {
                DataGridViewRow row = DataDanhMuc.SelectedRows[0];
                Suadanhmuc suadanhmuc = new Suadanhmuc(row);
                suadanhmuc.FormClosed += (s, args) =>
                {
                    LoadData();
                };
                suadanhmuc.ShowDialog();


            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!!!");

            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Themdanhmuc themdanhmuc = new Themdanhmuc();
            themdanhmuc.FormClosed += (s, args) =>
            {
                LoadData();
            };
            themdanhmuc.ShowDialog();
            //LoadData();
        }
    }
}
