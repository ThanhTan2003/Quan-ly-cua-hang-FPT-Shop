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

namespace Quan_ly_cua_hang_FPT_Shop.NV_Ban_hang.Khach_hang
{
    public partial class UserControl_NVBanHang_KhachHang : UserControl
    {
        public UserControl_NVBanHang_KhachHang()
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

        private void UserControl_NVBanHang_KhachHang_Load(object sender, EventArgs e)
        {
            UserControl_KhachHang_ThongTinKhachHang user = new UserControl_KhachHang_ThongTinKhachHang();
            Add_UserControl(user);
        }

        private void btThongTinKhachHang_Click(object sender, EventArgs e)
        {

        }
    }
}
