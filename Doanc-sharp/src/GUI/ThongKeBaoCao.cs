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
using System.Windows.Forms.DataVisualization.Charting;
namespace Doanc_sharp
{
    public partial class ThongKeBaoCao : UserControl
    {
        DatChoBUS datChoBus;
        PhieuMuonBUS phieuMuonBus;
        ViPhamBUS viPhamBus;
        LSHoatDongBUS lsHoatDongBus;
        NhanVienBUS nhanVienBus;
        ThanhVienBUS thanhVienBus;
        ThietBiBUS thietBiBus;
        private Chart chartLuotVao, chartLuotMuon, chartDoanhThu;
        public ThongKeBaoCao()
        {
            InitializeComponent();
            InitializeChart();
        }

        private void cmbNgayTuanThang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime tuNgay = time1LuotVao.Value.Date;
            DateTime denNgay = time2LuotVao.Value.Date;
            veBieuDoLuotVao(tuNgay, denNgay);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void load_data()
        {
            datChoBus = new DatChoBUS();
            List<DatChoDTO> list = datChoBus.docDsdc();
            tblDatCho.AutoGenerateColumns = false;
            tblDatCho.DataSource = list;


            phieuMuonBus = new PhieuMuonBUS();
            tblMuonTra.DataSource = phieuMuonBus.LayDanhSachPhieuMuon();
            tblMuonTra.DataSource = phieuMuonBus.LayDanhSachPhieuTra();
            tblMuonTra.Columns["Maphieumuon"].Visible = false;


            viPhamBus = new ViPhamBUS();
            DataTable dt = viPhamBus.GetAllViPham();
            tblViPham.DataSource = dt;
            tblViPham.Columns["Mota"].Visible = false;


            lsHoatDongBus = new LSHoatDongBUS();
            DataTable dtLS = lsHoatDongBus.GetAllLSHoatDong();
            tblLichSu.DataSource = dtLS;
            tblLichSu.Columns["Mahoatdong"].Visible = false;
            tblLichSu.Columns["Chitiet"].Visible = false;
            tblLichSu.Columns["is_delete"].Visible = false;

            nhanVienBus = new NhanVienBUS();
            lblNhanVien.Text = nhanVienBus.countNhanVien().ToString();

            thanhVienBus = new ThanhVienBUS();
            lblThanhVien.Text = thanhVienBus.countThanhVien().ToString();

            thietBiBus = new ThietBiBUS();
            lblThietBi.Text = (thietBiBus.countThietBiDaThue() + "/" + thietBiBus.countThietBi());

            lblViPham.Text = (viPhamBus.countViPham() + "/" + thanhVienBus.countThanhVien());


        }
        private void tblDatCho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ThongKeBaoCao_Load(object sender, EventArgs e)
        {
            load_data();
            //taoChart();
            DateTime tuNgayLuotVao = time1LuotVao.Value.Date;
            DateTime denNgayLuotVao = time2LuotVao.Value.Date;
            veBieuDoLuotVao(tuNgayLuotVao, denNgayLuotVao);

            DateTime tuNgayLuotMuon = time1MuonThietBi.Value.Date;
            DateTime denNgayLuotMuon = time2MuonThietBi.Value.Date;
            veBieuDoLuotMuon(tuNgayLuotMuon, denNgayLuotMuon);

            DateTime tuNgayDoanhThu = time1DoanhThu.Value.Date;
            DateTime denNgayDoanhThu = time2DoanhThu.Value.Date;
            veBieuDoDoanhThu(tuNgayDoanhThu, denNgayDoanhThu);

        }
        private void InitializeChart()
        {
            // Tạo mới chart nếu chưa tồn tại
            if (chartLuotVao == null)
            {
                chartLuotVao = new Chart();
                chartLuotVao.Dock = DockStyle.Fill;
                chartLuotVao.Name = "chartLuotVao";

                // Tạo ChartArea
                ChartArea chartArea = new ChartArea("MainArea");
                chartArea.AxisX.Title = "Ngày";
                chartArea.AxisY.Title = "Lượt vào";
                chartArea.AxisX.LabelStyle.Format = "dd/MM";
                chartArea.AxisX.Interval = 1;
                chartArea.AxisX.LabelStyle.Angle = -45;

                // Thêm ChartArea vào chart
                chartLuotVao.ChartAreas.Add(chartArea);

                // Thêm chart vào tab
                tabLuotVao.Controls.Add(chartLuotVao);
            }
            if (chartLuotMuon == null)
            {
                chartLuotMuon = new Chart();
                chartLuotMuon.Dock = DockStyle.Fill;
                chartLuotMuon.Name = "chartLuotMuon";

                ChartArea chartArea = new ChartArea("MainArea");
                chartArea.AxisX.Title = "Ngày";
                chartArea.AxisY.Title = "Lượt mượn";
                chartArea.AxisX.LabelStyle.Format = "dd/MM";
                chartArea.AxisX.Interval = 1;
                chartArea.AxisX.LabelStyle.Angle = -45;

                chartLuotMuon.ChartAreas.Add(chartArea);
                tabMuonThietBi.Controls.Add(chartLuotMuon);
            }
            if (chartDoanhThu == null)
            {
                chartDoanhThu = new Chart();
                chartDoanhThu.Dock = DockStyle.Fill;
                chartDoanhThu.Name = "chartDoanhThu";

                ChartArea chartArea = new ChartArea("MainArea");
                chartArea.AxisX.Title = "Ngày";
                chartArea.AxisY.Title = "Doanh thu";
                chartArea.AxisX.LabelStyle.Format = "dd/MM";
                chartArea.AxisX.Interval = 1;
                chartArea.AxisX.LabelStyle.Angle = -45;

                chartDoanhThu.ChartAreas.Add(chartArea);
                tabDoanhThu.Controls.Add(chartDoanhThu);
            }
        }
        private void btnChiTietDatCho_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)(this.ParentForm);
            main.FakeMenuClick("datcho");
        }

        private void btnChiTietMuonTra_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)(this.ParentForm);
            main.FakeMenuClick("ban");
        }

        private void btnChiTietViPham_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)(this.ParentForm);
            main.FakeMenuClick("vipham");
        }

        private void btnChiTietLichSu_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)(this.ParentForm);
            main.FakeMenuClick("lshd");
        }

        public void taoChart()
        {
            chartLuotVao = new Chart();
            chartLuotVao.Dock = DockStyle.Fill;

            ChartArea chartArea = new ChartArea("MainArea");
            chartArea.AxisX.Title = "Ngày";
            chartArea.AxisY.Title = "Lượt vào";
            chartArea.AxisX.LabelStyle.Format = "dd/MM";

            chartLuotVao.ChartAreas.Add(chartArea);

            tabLuotVao.Controls.Add(chartLuotVao);
        }

        public void veBieuDoLuotVao(DateTime tuNgay, DateTime denNgay)
        {
            chartLuotVao.Series.Clear();

            Series series = new Series("Lượt vào");
            series.ChartType = SeriesChartType.Line;
            series.XValueType = ChartValueType.Date;
            series.Color = Color.DarkBlue;      // Màu đường
            series.BorderWidth = 3;             // Đường đậm
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 7;
            series.MarkerColor = Color.Red;
            var duLieu = lsHoatDongBus.LayDuLieuLuotVao(tuNgay, denNgay);
            foreach (var item in duLieu)
            {
                series.Points.AddXY(item.Item1, item.Item2);
            }// Ngày, số lượt
            chartLuotVao.Series.Add(series);
        }
        public void veBieuDoLuotMuon(DateTime tuNgay, DateTime denNgay)
        {
            chartLuotMuon.Series.Clear();

            Series series = new Series("Lượt mượn");
            series.ChartType = SeriesChartType.Line;
            series.XValueType = ChartValueType.Date;
            series.Color = Color.DarkBlue;      // Màu đường
            series.BorderWidth = 3;             // Đường đậm
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 7;
            series.MarkerColor = Color.Red;
            var duLieu = phieuMuonBus.LayDuLieuLuotMuon(tuNgay, denNgay);
            foreach (var item in duLieu)
            {
                series.Points.AddXY(item.Item1, item.Item2);
            }// Ngày, số lượt
            chartLuotMuon.Series.Add(series);
        }

        public void veBieuDoDoanhThu(DateTime tuNgay, DateTime denNgay)
        {
            chartDoanhThu.Series.Clear();

            Series series = new Series("Doanh thu");
            series.ChartType = SeriesChartType.Line;
            series.XValueType = ChartValueType.Date;
            series.Color = Color.Green;      // Màu đường
            series.BorderWidth = 3;             // Đường đậm
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 7;
            series.MarkerColor = Color.Red;
            series.IsValueShownAsLabel = true;
            series.LabelFormat = "#,##0 VND";
            var duLieu = phieuMuonBus.LayDuLieuDoanhThu(tuNgay, denNgay);
            foreach (var item in duLieu)
            {
                series.Points.AddXY(item.Item1, item.Item2);
            }// Ngày, số lượt
            chartDoanhThu.Series.Add(series);
        }

        private void time2LuotVao_ValueChanged(object sender, EventArgs e)
        {
            DateTime tuNgay = time1LuotVao.Value.Date;
            DateTime denNgay = time2LuotVao.Value.Date;
            veBieuDoLuotVao(tuNgay, denNgay);
        }

        private void time1MuonThietBi_ValueChanged(object sender, EventArgs e)
        {
            DateTime tuNgay = time1MuonThietBi.Value.Date;
            DateTime denNgay = time2MuonThietBi.Value.Date;
            veBieuDoLuotMuon(tuNgay, denNgay);
        }

        private void time2MuonThietBi_ValueChanged(object sender, EventArgs e)
        {
            DateTime tuNgay = time1MuonThietBi.Value.Date;
            DateTime denNgay = time2MuonThietBi.Value.Date;
            veBieuDoLuotMuon(tuNgay, denNgay);
        }

        private void time1DoanhThu_ValueChanged(object sender, EventArgs e)
        {
            DateTime tuNgayDoanhThu = time1DoanhThu.Value.Date;
            DateTime denNgayDoanhThu = time2DoanhThu.Value.Date;
            veBieuDoDoanhThu(tuNgayDoanhThu, denNgayDoanhThu);
        }

        private void time2DoanhThu_ValueChanged(object sender, EventArgs e)
        {
            DateTime tuNgayDoanhThu = time1DoanhThu.Value.Date;
            DateTime denNgayDoanhThu = time2DoanhThu.Value.Date;
            veBieuDoDoanhThu(tuNgayDoanhThu, denNgayDoanhThu);
        }
    }
}
