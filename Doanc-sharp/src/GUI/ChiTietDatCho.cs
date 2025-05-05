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
using Doanc_sharp.src.Helpers;

namespace Doanc_sharp
{
    public partial class ChiTietDatCho : Form
    {
        private CtDatChoBUS ctdatchobus;
        private PhieuMuonBUS phieuMuonbus;
        private CtPhieuMuonBUS ctPhieuMuonBUS;
        private DatChoBUS datchobus;
        private  Tools tools;
        public ChiTietDatCho()
        {
            InitializeComponent();

          

          



        }

        public void loadct(string id, string mathanhvien, string ngay, string trangthai)
        {
            ctdatchobus = new CtDatChoBUS();
            this.txtID.Text = id;
            this.dgvCTDC.DataSource = ctdatchobus.LayDanhSachChiTietTheoMaDatCho(Convert.ToInt32(id));
            this.txtThoiGianDatCho.Text = ngay;
            this.txtMaThanhVien.Text = mathanhvien;
            if (cmbTrangThai.Items.Count == 0)
            {
                cmbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbTrangThai.Items.Clear();
                cmbTrangThai.Items.Add("Đang chờ");
                cmbTrangThai.Items.Add("Đã xác nhận");
                cmbTrangThai.Items.Add("Đã hủy");
            }
            cmbTrangThai.SelectedItem= trangthai.Trim();






        }
        private void txtMaThanhVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Bạn có chắc chắn muốn thoát ?",
            "Xác nhận",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Dispose();
             
              
            }
            else
            {
                // Người dùng bấm No
                // Không làm gì cả
            }
            
        }

        private void pnTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChiTietDatCho_Load(object sender, EventArgs e)
        {

        }

        private void dgvCTDC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblMaThanhVien_Click(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
                DialogResult result = MessageBox.Show(
                        "Bạn có chắc chắn muốn xác nhận mượn thiết bị cho đặt chỗ này không?",
                        "Xác nhận",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                phieuMuonbus= new PhieuMuonBUS();
                ctPhieuMuonBUS = new CtPhieuMuonBUS();
                datchobus =new DatChoBUS();
                tools = new Tools();
                int matv = Convert.ToInt32(txtMaThanhVien.Text.ToString());
                int madatcho = Convert.ToInt32(txtID.Text.ToString());
                if (cmbTrangThai.SelectedItem.ToString().Contains("Đã xác nhận"))
                { int mapm = tools.GenerateUniqueNumber("phieumuon", "Maphieumuon");
                   
                    PhieuMuonDTO pm= new PhieuMuonDTO(
                        mapm,
                        DateTime.Now,
                        DateTime.MinValue,
                        "Đang mượn",
                        matv
                        );

                    phieuMuonbus.ThemPhieuMuon(pm);
                    foreach (DataGridViewRow row in dgvCTDC.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            
                            int mathietbi = Convert.ToInt32(row.Cells["IDTB"].Value.ToString());
                            int soluong = Convert.ToInt32(row.Cells["Soluong"].Value.ToString());

                            ChiTietPhieuMuonDTO temp = new ChiTietPhieuMuonDTO(mapm, mathietbi, soluong);
                            ctPhieuMuonBUS.ThemChiTiet(temp);
                            
                        }
                        
                    }

                    DatChoDTO datCho = new DatChoDTO();
                    datCho = datchobus.Timkiemtheoma(madatcho);
                    if (datCho != null) {
                        datCho.Trangthai = "Đã xác nhận";
                        datchobus.Update(datCho);
                    }

                    MessageBox.Show("Xác nhận mượn !");

                    this.Dispose();

                }
                else if(cmbTrangThai.SelectedItem.ToString().Contains("Đã hủy"))
                {
                    DatChoDTO datCho = new DatChoDTO();
                    datCho = datchobus.Timkiemtheoma(madatcho);
                    if (datCho != null)
                    {
                        datCho.Trangthai = "Đã hủy";
                        datchobus.Update(datCho);
                    }
                     MessageBox.Show("Xác nhận đã hủy !");
                    this.Dispose();
                }
                else
                {
                    this.Dispose(true);
                    return;

                } 

                
              
                
            }
            else
            {
                // Người dùng bấm No
                // Không làm gì cả
            }
        }
    }
}
