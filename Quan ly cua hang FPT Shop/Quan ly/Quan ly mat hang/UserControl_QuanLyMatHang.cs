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
    public partial class UserControl_QuanLyMatHang : UserControl
    {
        public UserControl_QuanLyMatHang()
        {
            InitializeComponent();
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
        private void btThongKe_Click(object sender, EventArgs e)
        {
            
        }

        private void btMatHang_Click(object sender, EventArgs e)
        {
            RestButton();
            RestPanel();

            btMatHang.BackColor = Color.White;
            btMatHang.ForeColor = Color.MidnightBlue;

            pMatHang.BackColor = Color.MidnightBlue;

            UserControl_QuanLyMatHang_MatHang user = new UserControl_QuanLyMatHang_MatHang();
            Add_UserControl(user);
        }

        private void btDonHang_Click(object sender, EventArgs e)
        {
            RestButton();
            RestPanel();

            btDonHang.BackColor = Color.White;
            btDonHang.ForeColor = Color.MidnightBlue;

            pDonHang.BackColor = Color.MidnightBlue;

            UserControl_QuanLyMatHang_TraCuuDonHang user = new UserControl_QuanLyMatHang_TraCuuDonHang();
            Add_UserControl(user);
        }

        private void btNhaCungCap_Click(object sender, EventArgs e)
        {
           
        }

        private void btDoanhThu_Click(object sender, EventArgs e)
        {
            RestButton();
            RestPanel();

            btDoanhThu.BackColor = Color.White;
            btDoanhThu.ForeColor = Color.MidnightBlue;

            pDoanhThu.BackColor = Color.MidnightBlue;

            UserControl_QuanLyMatHang_DoanhThu user = new UserControl_QuanLyMatHang_DoanhThu();
            Add_UserControl(user);
        }

        private void btLichSu_Click(object sender, EventArgs e)
        {
            
        }

        private void panelChinh_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControl_QuanLyMatHang_Load(object sender, EventArgs e)
        {
            UserControl_QuanLyMatHang_MatHang user = new UserControl_QuanLyMatHang_MatHang();
            Add_UserControl(user);
        }
    }
}
