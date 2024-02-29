using Quan_ly_cua_hang_FPT_Shop.CSDL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_cua_hang_FPT_Shop.NV_Ban_hang.Quan_ly_mat_hang
{
    public partial class ThemKhachHangMoi : Form
    {
        public ThemKhachHangMoi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbTen.Text == "" || tbSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (tbSDT.Text.Length != 10)
            {
                MessageBox.Show("Vui lòng nhập chính xác số điện thoại (đủ 10 chữ số)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sql = "insert into KHACHHANG(HoTen, SoDT, Email, DiaChi, GhiChu) values (N'" + tbTen.Text + "', '" + tbSDT.Text + "', '" + tbEmail.Text + "', N'" + tbDiaChi.Text + "', N'" + tbGhiChu.Text + "')";
            try
            {
                CSDL.CSDL.XuLy(sql);
                MessageBox.Show("Đã thêm thông tin khách hàng mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            catch
            {
                MessageBox.Show("Thêm không thành công. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Close();
        }
    }
}
