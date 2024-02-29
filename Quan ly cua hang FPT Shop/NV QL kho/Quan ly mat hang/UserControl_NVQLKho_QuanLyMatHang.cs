using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_cua_hang_FPT_Shop.NV_QL_kho.Quan_ly_mat_hang
{
    public partial class UserControl_NVQLKho_QuanLyMatHang : UserControl
    {
        public UserControl_NVQLKho_QuanLyMatHang()
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

        private void UserControl_NVQLKho_QuanLyMatHang_Load(object sender, EventArgs e)
        {
            UserControl_QuanLyMatHang_MatHang user = new UserControl_QuanLyMatHang_MatHang();
            Add_UserControl(user);
        }
    }
}
