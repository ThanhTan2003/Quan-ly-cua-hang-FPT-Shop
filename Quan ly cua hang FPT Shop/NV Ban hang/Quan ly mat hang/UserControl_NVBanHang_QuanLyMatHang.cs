using Quan_ly_cua_hang_FPT_Shop.NV_Ban_hang.Quan_ly_mat_hang;
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
    public partial class UserControl_NVBanHang_QuanLyMatHang : UserControl
    {
        public UserControl_NVBanHang_QuanLyMatHang()
        {
            InitializeComponent();
        }

        private void UserControl_NVBanHang_QuanLyMatHang_Load(object sender, EventArgs e)
        {
            RestButton();
            RestPanel();

            btMatHang.BackColor = Color.White;
            btMatHang.ForeColor = Color.MidnightBlue;

            pMatHang.BackColor = Color.MidnightBlue;

            UserControl_NVBanHang_QuanLyMatHang_MatHang user = new UserControl_NVBanHang_QuanLyMatHang_MatHang();
            Add_UserControl(user);
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

        private void btMatHang_Click(object sender, EventArgs e)
        {
            RestButton();
            RestPanel();

            btMatHang.BackColor = Color.White;
            btMatHang.ForeColor = Color.MidnightBlue;

            pMatHang.BackColor = Color.MidnightBlue;

            UserControl_NVBanHang_QuanLyMatHang_MatHang user = new UserControl_NVBanHang_QuanLyMatHang_MatHang();
            Add_UserControl(user);
        }

        private void btBanHang_Click(object sender, EventArgs e)
        {
            RestButton();
            RestPanel();

            btBanHang.BackColor = Color.White;
            btBanHang.ForeColor = Color.MidnightBlue;

            pBanHang.BackColor = Color.MidnightBlue;

            UserControl_NVBanHang_QuanLyMatHang_BanHang user = new UserControl_NVBanHang_QuanLyMatHang_BanHang();
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
    }
}
