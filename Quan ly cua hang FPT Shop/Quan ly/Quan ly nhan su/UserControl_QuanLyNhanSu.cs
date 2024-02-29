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
    public partial class UserControl_QuanLyNhanSu : UserControl
    {
        public UserControl_QuanLyNhanSu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        void Add_UserControl(UserControl user)
        {
            user.Dock = DockStyle.Fill;
            panelChinh.Controls.Clear();
            panelChinh.Controls.Add(user);
            user.BringToFront();
        }

        void RestPanel()
        {
            foreach (Control cn in panel1.Controls)
            {
                if (cn is Panel)
                {
                    Panel bt = cn as Panel;
                    bt.BackColor = Color.Transparent;
                    bt.ForeColor = Color.White;
                }
            }
            panelChinh.Controls.Clear();
        }

        void RestButton()
        {
            foreach (Control cn in panel1.Controls)
            {
                if (cn is Button)
                {
                    Button bt = cn as Button;
                    bt.BackColor = Color.White;
                    bt.ForeColor = Color.DimGray;
                }
            }

        }

        private void btNhanSu_Click(object sender, EventArgs e)
        {
            RestButton();
            RestPanel();

            btThongTinNhanVien.BackColor = Color.White;
            btThongTinNhanVien.ForeColor = Color.MidnightBlue;

            pThongTinNhanVien.BackColor = Color.MidnightBlue;

            UserControl_QuanLyNhanSu_ThongTinNhanVien user = new UserControl_QuanLyNhanSu_ThongTinNhanVien();
            Add_UserControl(user);
        }

        private void btLichLamViec_Click(object sender, EventArgs e)
        {
            RestButton();
            RestPanel();

            //btLichLamViec.BackColor = Color.White;
           // btLichLamViec.ForeColor = Color.MidnightBlue;

            //pLichLamViec.BackColor = Color.MidnightBlue;
        }

        private void btTangCa_Click(object sender, EventArgs e)
        {
            
        }

        private void btThuongPhat_Click(object sender, EventArgs e)
        {
            
        }

        private void btLuong_Click(object sender, EventArgs e)
        {
            
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            RestButton();
            RestPanel();

            btQanLyTaiKhoan.BackColor = Color.White;
            btQanLyTaiKhoan.ForeColor = Color.MidnightBlue;

            pQuanLyTaiKhoan.BackColor = Color.MidnightBlue;

            UserControl_QuanLyNhanSu_QuanLyTaiKhoan user = new UserControl_QuanLyNhanSu_QuanLyTaiKhoan();
            Add_UserControl(user);
        }

        private void panelChinh_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pQuanLyTaiKhoan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pLuong_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pThuongPhat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pTangCa_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pLichLamViec_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pThongTinNhanVien_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControl_QuanLyNhanSu_Load(object sender, EventArgs e)
        {
            UserControl_QuanLyNhanSu_ThongTinNhanVien user = new UserControl_QuanLyNhanSu_ThongTinNhanVien();
            Add_UserControl(user);
        }
    }
}
