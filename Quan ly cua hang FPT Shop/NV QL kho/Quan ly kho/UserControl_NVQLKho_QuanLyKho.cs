using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_cua_hang_FPT_Shop.NV_QL_kho.Quan_ly_kho
{
    public partial class UserControl_NVQLKho_QuanLyKho : UserControl
    {
        public UserControl_NVQLKho_QuanLyKho()
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
            RestButton();
            RestPanel();

            btKiemKe.BackColor = Color.White;
            btKiemKe.ForeColor = Color.MidnightBlue;

            pKiemKe.BackColor = Color.MidnightBlue;

            UserControl_NVQLKho_QuanLyKho_KiemKe user = new UserControl_NVQLKho_QuanLyKho_KiemKe();
            Add_UserControl(user);
        }

        private void btNhapHang_Click(object sender, EventArgs e)
        {
            RestButton();
            RestPanel();

            btNhapHang.BackColor = Color.White;
            btNhapHang.ForeColor = Color.MidnightBlue;

            pNhapHang.BackColor = Color.MidnightBlue;

            UserControl_NVQLKho_QuanLyKho_NhapKho user = new UserControl_NVQLKho_QuanLyKho_NhapKho();
            Add_UserControl(user);
        }

        private void btXuatHang_Click(object sender, EventArgs e)
        {
            RestButton();
            RestPanel();

            btXuatHang.BackColor = Color.White;
            btXuatHang.ForeColor = Color.MidnightBlue;

            pXuatHang.BackColor = Color.MidnightBlue;

            UserControl_NVQLKho_QuanLyKho_XuatKho user = new UserControl_NVQLKho_QuanLyKho_XuatKho();
            Add_UserControl(user);
        }

        private void UserControl_NVQLKho_QuanLyKho_Load(object sender, EventArgs e)
        {
            UserControl_QuanLyKho_TheoDoiTonKho user = new UserControl_QuanLyKho_TheoDoiTonKho();
            Add_UserControl(user);
        }
    }
}
