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
    public partial class UserControl_TrangChu_NVQuanLy : UserControl
    {
        public UserControl_TrangChu_NVQuanLy()
        {
            InitializeComponent();
        }

        private void UserControl_TrangChu_NVQuanLy_Load(object sender, EventArgs e)
        {
            tbTenNguoiDung.Text = CSDL.CSDL.TenHienThi;
            tbViTri.Text = CSDL.CSDL.LoaiTK;
            tbTenDN.Text = CSDL.CSDL.TenDN;
        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            if(!cb1.Checked)
            {
                tbMKHientai.UseSystemPasswordChar = true;
            }
            else
                tbMKHientai.UseSystemPasswordChar = false;
        }

        private void cb2_CheckedChanged(object sender, EventArgs e)
        {
            if (!cb2.Checked)
            {
                tbMKMoi.UseSystemPasswordChar = true;
            }
            else
                tbMKMoi.UseSystemPasswordChar = false;
        }

        private void cb3_CheckedChanged(object sender, EventArgs e)
        {
            if (!cb3.Checked)
            {
                tbMKNhacLai.UseSystemPasswordChar = true;
            }
            else
                tbMKNhacLai.UseSystemPasswordChar = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbMKHientai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if(tbMKMoi.Text == "" || tbMKNhacLai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if(tbMKNhacLai.Text != tbMKMoi.Text)
            {
                MessageBox.Show("Mật khẩu nhập không trùng khớp. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(tbMKHientai.Text != CSDL.CSDL.MK)
            {
                MessageBox.Show("Mật khẩu nhập không chính xác. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sql = $"update TAIKHOAN set MK = '{tbMKMoi.Text}' where TK = '{tbTenDN.Text}'";
            try
            {
                CSDL.CSDL.XuLy(sql);
                MessageBox.Show("Đã thay đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Không thể thay đổi mật khẩu. Vui lòng thử lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
