using Quan_ly_cua_hang_FPT_Shop.CSDL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_cua_hang_FPT_Shop
{
    public partial class TrangChu_QuanLy : Form
    {

        bool Thoat = true;

        public TrangChu_QuanLy()
        {
            InitializeComponent();
        }

        void Add_UserControl(UserControl user)
        {
            user.Dock = DockStyle.Fill;
            panelUS.Controls.Clear();
            panelUS.Controls.Add(user);
            user.BringToFront();
        }

        void RestPanel()
        {
            foreach (Control cn in panel1.Controls)
            {
                if (cn is Panel)
                {
                    Panel bt = cn as Panel;
                    bt.BackColor = Color.Teal;
                    bt.ForeColor = Color.White;
                }
            }

        }

        void RestButton()
        {
            foreach (Control cn in panel1.Controls)
            {
                if (cn is Button)
                {
                    Button bt = cn as Button;
                    bt.BackColor = Color.Teal;
                    bt.ForeColor = Color.White;
                }
            }

        }

        private void panelUserControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            UserControl_TrangChu_NVQuanLy user = new UserControl_TrangChu_NVQuanLy();
            Add_UserControl(user);
            RestButton();
            RestPanel();
            btTrangChu.BackColor = Color.WhiteSmoke;
            btTrangChu.ForeColor = Color.Black;
            lbHienThi.Text = CSDL.CSDL.TenHienThi;
            lbViTri.Text = CSDL.CSDL.LoaiTK;
        }

        private void panelUserControl_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbDate_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dn = new DangNhap();
            dn.Show();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        string LayThu()
        {
            DateTime now = DateTime.Now;
            string dayName = now.ToString("dddd");
            switch (dayName)
            {
                case "Monday":
                    return "Thứ Hai";
                case "Tuesday":
                    return "Thứ Ba";
                case "Wednesday":
                    return "Thứ Tư";
                case "Thursday":
                    return "Thứ Năm";
                case "Friday":
                    return "Thứ Sáu";
                case "Saturday":
                    return "Thứ Bảy";
                case "Sunday":
                    return "Chủ Nhật";
                default:
                    return "Không xác định";

            }
        }

        string LayThang()
        {
            DateTime now = DateTime.Now;
            string dayName = now.ToString("MMMM");
            switch (dayName)
            {
                case "January":
                    return "Tháng 1";
                case "February":
                    return "Tháng 1";
                case "March":
                    return "Tháng 1";
                case "April":
                    return "Tháng 1";
                case "May":
                    return "Tháng 1u";
                case "June":
                    return "Tháng 1";
                case "July":
                    return "Tháng 1";
                case "August":
                    return "Tháng 1";
                case "September":
                    return "Tháng 1";
                case "October":
                    return "Tháng 1";
                case "November":
                    return "Tháng 1";
                case "December":
                    return "Tháng 1";
                default:
                    return "Không xác định";

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string monthName = now.ToString("MMMM");
            string dayName = now.ToString("dddd");

            lbTime.Text = DateTime.Now.ToLongTimeString();
            lbDate.Text = String.Format("{0}, {1}", LayThu(), DateTime.Now.ToString(@"dd/MM/yyyy"));
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btTrangChu_Click(object sender, EventArgs e)
        {
            RestButton();
            RestPanel();

            btTrangChu.BackColor = Color.WhiteSmoke;
            btTrangChu.ForeColor = Color.Black;

            UserControl_TrangChu_NVQuanLy user = new UserControl_TrangChu_NVQuanLy();
            Add_UserControl(user);
        }

        private void btLop_Click(object sender, EventArgs e)
        {
            RestButton();
            RestPanel();

            btKhachHang.BackColor = Color.WhiteSmoke;
            btKhachHang.ForeColor = Color.Black;

            UserControl_KhachHang user = new UserControl_KhachHang();
            Add_UserControl(user);
        }

        private void btHocPhan_Click(object sender, EventArgs e)
        {
            RestButton();
            RestPanel();

            btKho.BackColor = Color.WhiteSmoke;
            btKho.ForeColor = Color.Black;

            UserControl_QuanLyKho user = new UserControl_QuanLyKho();
            Add_UserControl(user);
        }

        // button Quan ly nhan su
        private void btGiangDay_Click(object sender, EventArgs e) 
        {
            RestButton();
            RestPanel();

            btNhanSu.BackColor = Color.WhiteSmoke;
            btNhanSu.ForeColor = Color.Black;

            UserControl_QuanLyNhanSu user = new UserControl_QuanLyNhanSu();
            Add_UserControl(user);
        }

        private void btGiangVien_Click(object sender, EventArgs e)
        {
            RestButton();
            RestPanel();

            btMatHang.BackColor = Color.WhiteSmoke;
            btMatHang.ForeColor = Color.Black;

            UserControl_QuanLyMatHang user = new UserControl_QuanLyMatHang();
            Add_UserControl(user);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbTime_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dn = new DangNhap();
            dn.Show();
        }

        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RestButton();
            RestPanel();

            btKhuyenMai.BackColor = Color.WhiteSmoke;
            btKhuyenMai.ForeColor = Color.Black;

            UserControl_KhuyenMaiQuaTang user = new UserControl_KhuyenMaiQuaTang();
            Add_UserControl(user);
        }

        private void TrangChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Thoat)
                Application.Exit();
        }
    }
}
