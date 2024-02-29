using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_cua_hang_FPT_Shop.NV_Ban_hang.Khuyen_mai_Qua_tang
{
    public partial class UserControl_NVBanHang_KhachHang_KhuyenMaiQuaTang : UserControl
    {
        public UserControl_NVBanHang_KhachHang_KhuyenMaiQuaTang()
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

        private void UserControl_NVBanHang_KhachHang_KhuyenMaiQuaTang_Load(object sender, EventArgs e)
        {
            UserControl_NVBanHang_KhachHang_KhuyenMaiQuaTang_ThongTinKhuyenMai user = new UserControl_NVBanHang_KhachHang_KhuyenMaiQuaTang_ThongTinKhuyenMai();
            Add_UserControl(user);
        }
    }
}
