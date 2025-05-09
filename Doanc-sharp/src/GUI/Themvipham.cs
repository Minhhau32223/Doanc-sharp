using Doanc_sharp.src.BUS;
using Doanc_sharp.src.DTO;
using Doanc_sharp.src.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Doanc_sharp
{
    public partial class Themvipham : Form
    {
        ViPhamBUS viPhamBUS = new ViPhamBUS();
        ThanhVienBUS thanhVienBUS = new ThanhVienBUS();
        List<ViPhamDTO> viPhamList = new List<ViPhamDTO>();
        List<ThanhVienDTO> thanhVienList = new List<ThanhVienDTO>();
        public Themvipham()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            viPhamList = viPhamBUS.GetAllViPhamNotTvvp();
            thanhVienList = thanhVienBUS.LayTatcaThanhVien();


            TvvpCbx.DataSource = getMaTen();
            TvvpCbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TvvpCbx.AutoCompleteSource = AutoCompleteSource.ListItems;

            ViPhamCbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ViPhamCbx.AutoCompleteSource = AutoCompleteSource.ListItems;

            ViPhamCbx.DataSource = getVP();
        }

        public List<string> getMaTen()
        {
            List<string> maTen = new List<string>();
            foreach (var item in thanhVienList)
            {
                maTen.Add(item.Mathanhvien + " - " + item.Hoten);
            }
            return maTen;
        }

        public List<string> getVP()
        {
            List<string> VP = new List<string>();
            foreach (ViPhamDTO data in viPhamList)
            {
                VP.Add(data.MaViPham+ " - " + data.TenViPham);
            }
            return VP;
        }


        private void ThoatBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XacnhanBtn_Click(object sender, EventArgs e)
        {
            Tools tools = new Tools();
            ViPhamDTO viPham = viPhamList[ViPhamCbx.SelectedIndex];
            ThanhVienDTO thanhVien = thanhVienList[TvvpCbx.SelectedIndex];

            

            if (TVPChb.Checked)
            {
                //validate data
                if (tools.IsNotEmpty(tenVPTbx.Text, "tên vi phạm") == false || tools.IsNotEmpty(moTaTbx.Text, "mô tả") == false)
                {
                    return;
                }
                int maViPham = tools.GenerateUniqueNumber("thanhvienvipham", "Mavipham");
                ViPhamDTO newViPham = new ViPhamDTO();
                newViPham.MaViPham = "VP" + maViPham.ToString();
                newViPham.TenViPham = tenVPTbx.Text;
                newViPham.MoTa = moTaTbx.Text;
                viPhamBUS.InsertViPham(new NhanVienDTO() { Manhanvien = 1}, newViPham); //set cứng vì chưa lấy được tk nhân viên đăng nhập
                if (viPhamBUS.InsertTVVP(thanhVien, newViPham, DateTime.Now))
                {
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                    this.Close();
                }
            }
            else
            {
                if(viPhamBUS.InsertTVVP(thanhVien, viPham, DateTime.Now))
                {
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                    this.Close();
                }
            }

        }

        private void onChange(object sender, EventArgs e)
        {
            
        }

        private void onCheck(object sender, EventArgs e)
        {
            if (TVPChb.Checked)
            {
                ViPhamCbx.Enabled = false;
                tenVPTbx.Enabled = true;
                moTaTbx.Enabled = true;
            }
            else
            {
                ViPhamCbx.Enabled = true;
                tenVPTbx.Enabled = false;
                moTaTbx.Enabled = false;
            }
        }
    }
}
