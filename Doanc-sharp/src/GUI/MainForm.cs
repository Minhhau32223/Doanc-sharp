using System.Runtime;
using Doanc_sharp.src.DAO;
using Doanc_sharp.src.DTO;
using Doanc_sharp.src.GUI;

namespace Doanc_sharp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            leftmenu1.ButtonClicked += Leftmenu1_ButtonClicked;
          
        }
        private void ShowControlInRightPanel(UserControl control)
        {
            Rightpanel.Controls.Clear(); // Xóa control cũ
            //control.Dock = DockStyle.Fill;
            control.Location = new Point(100, 100);// Để fill toàn panel
            Rightpanel.Controls.Add(control); // Thêm control mới
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void leftmenu1_Load(object sender, EventArgs e)
        {

        }

        private void leftmenu1_Load_1(object sender, EventArgs e)
        {

        }
        private void Leftmenu1_ButtonClicked(object sender, string action)
        {
            switch (action)
            {
                case "datcho":
                    ShowControlInRightPanel(new DatCho());
                    break;
                case "baotri":
                    ShowControlInRightPanel(new Baotri());
                    break;
                case "thanhvien":
                    ShowControlInRightPanel(new Thanhvien());
                    break;
                case "nhanvien":
                    ShowControlInRightPanel(new Nhanvien());
                    break;
                case "thietbi":
                    ShowControlInRightPanel(new Thietbi());
                    break;
                case "ban":
                    ShowControlInRightPanel(new Muontra());
                    break;
                case "danhmuc":
                    ShowControlInRightPanel(new DanhMuc());
                    break;
                case "vipham":
                    ShowControlInRightPanel(new Vipham());
                    break;
                case "lshd":
                    ShowControlInRightPanel(new Lichsuhoatdong());
                    break;
                case "baocao":
                    ShowControlInRightPanel(new ThongKeBaoCao());
                    break;
                case "check":
                    ShowControlInRightPanel(new KiemTra());
                    break;

            }
        }

        
    }
}
