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
    public partial class UserControl_QuanLyKho : UserControl
    {
        public UserControl_QuanLyKho()
        {
            InitializeComponent();
            UserControl_QuanLyKho_TheoDoiTonKho user = new UserControl_QuanLyKho_TheoDoiTonKho();
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

        private void btTheoDoiTonKho_Click(object sender, EventArgs e)
        {
            RestButton();
            RestPanel();

            btTheoDoiTonKho.BackColor = Color.White;
            btTheoDoiTonKho.ForeColor = Color.MidnightBlue;

            pTheoDoiTonKho.BackColor = Color.MidnightBlue;

            UserControl_QuanLyKho_TheoDoiTonKho user = new UserControl_QuanLyKho_TheoDoiTonKho();
            Add_UserControl(user);
        }

        private void btKiemKe_Click(object sender, EventArgs e)
        {
            
        }

        private void btNhapXuatHang_Click(object sender, EventArgs e)
        {
            
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            //RestButton();
            //RestPanel();

            //btThongKe.BackColor = Color.White;
            //btThongKe.ForeColor = Color.MidnightBlue;

            //pThongKe.BackColor = Color.MidnightBlue;
        }

        private void btLichSu_Click(object sender, EventArgs e)
        {

        }
    }

}
