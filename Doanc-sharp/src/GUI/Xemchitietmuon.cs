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

namespace Doanc_sharp
{
    public partial class Xemchitietmuon : Form
    {
        private CtPhieuMuonBUS ctpmbus = new CtPhieuMuonBUS();
        public Xemchitietmuon()
        {
            InitializeComponent();
        }
        public void loadct(string mapm, string matv, string ngaymuon, string ngaytra, string trangthai)
        {
            txtMaphieumuon.Text = mapm;
            txtMathanhvien.Text = matv;
            txtNgaymuon.Text = ngaymuon;
            txtNgaytra.Text = ngaytra;
            if (comboBoxTrangthai.Items.Count == 0)
            {
                comboBoxTrangthai.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxTrangthai.Items.Clear();
                comboBoxTrangthai.Items.Add("Đang mượn");
                comboBoxTrangthai.Items.Add("Đã trả");
                comboBoxTrangthai.Items.Add("Đã hủy");
            }
            comboBoxTrangthai.SelectedItem = trangthai.Trim();
            DataThietbi.DataSource = ctpmbus.LayDanhSachChiTiet(Convert.ToInt32(mapm));


        }
        public void view()
        {
            txtMaphieumuon.ReadOnly = true;
            txtMathanhvien.ReadOnly = true;
            txtNgaymuon.ReadOnly = true;
            txtNgaytra.ReadOnly = true;
            comboBoxTrangthai.Enabled = false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Xemchitietmuon_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
