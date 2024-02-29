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
    public partial class UserControl_KhachHang : UserControl
    {
        public UserControl_KhachHang()
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

            btThongTinKhachHang.BackColor = Color.White;
            btThongTinKhachHang.ForeColor = Color.MidnightBlue;

            pThongTinKhachHang.BackColor = Color.MidnightBlue;

            UserControl_KhachHang_ThongTinKhachHang user = new UserControl_KhachHang_ThongTinKhachHang();
            Add_UserControl(user);
        }

        private void btLichSuMuaHang_Click(object sender, EventArgs e)
        {
            RestButton();
            RestPanel();

            btLichSuMuaHang.BackColor = Color.White;
            btLichSuMuaHang.ForeColor = Color.MidnightBlue;

            pLichSuMuaHang.BackColor = Color.MidnightBlue;

            UserControl_KhachHang_LichSuMuaHang user = new UserControl_KhachHang_LichSuMuaHang();
            Add_UserControl(user);
        }

        private void btThietLap_Click(object sender, EventArgs e)
        {
            //RestButton();
            //RestPanel();

            //btThietLap.BackColor = Color.White;
            //btThietLap.ForeColor = Color.MidnightBlue;

            //pThietLap.BackColor = Color.MidnightBlue;

            //UserControl_KhachHang_ThietLap user = new UserControl_KhachHang_ThietLap();
            //Add_UserControl(user);
        }

        private void panelChinh_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void UserControl_KhachHang_Load(object sender, EventArgs e)
        {
            RestButton();
            RestPanel();

            btThongTinKhachHang.BackColor = Color.White;
            btThongTinKhachHang.ForeColor = Color.MidnightBlue;

            pThongTinKhachHang.BackColor = Color.MidnightBlue;

            UserControl_KhachHang_ThongTinKhachHang user = new UserControl_KhachHang_ThongTinKhachHang();
            Add_UserControl(user);
        }
    }
}
