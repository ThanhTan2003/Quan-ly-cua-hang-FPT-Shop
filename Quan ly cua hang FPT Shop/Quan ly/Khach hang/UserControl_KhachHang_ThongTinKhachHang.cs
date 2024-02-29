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

namespace Quan_ly_cua_hang_FPT_Shop
{
    public partial class UserControl_KhachHang_ThongTinKhachHang : UserControl
    {
        void layDSKhachHang()
        {
            string sql = "select * from KHACHHANG";
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            listDS.Items.Clear();
            for(int i = 0;  i < dt.Rows.Count; i++)
            {
                listDS.Items.Add(dt.Rows[i][0].ToString());
                listDS.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                listDS.Items[i].SubItems.Add(dt.Rows[i][3].ToString());
            }
        }
        public UserControl_KhachHang_ThongTinKhachHang()
        {
            InitializeComponent();
        }

        private void UserControl_KhachHang_ThongTinKhachHang_Load(object sender, EventArgs e)
        {
            layDSKhachHang();
        }

        private void listDS_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            // Tô màu nền
            e.Graphics.FillRectangle(Brushes.RoyalBlue, e.Bounds);
            // vẽ lại dòng tiêu đề với font in đậm và màu trắng
            e.Graphics.DrawString(e.Header.Text, new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold), Brushes.White, e.Bounds);

        }

        private void listDS_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
            if (e.Item != null)
            {
                if (e.ItemIndex == 0) // Nếu là dòng tiêu đề
                {
                }
                else // Nếu là các dòng dữ liệu
                {
                    // Vẽ các dòng dữ liệu với màu chữ đen và font size nhỏ hơn
                    e.Graphics.DrawString(listDS.Name, new Font(FontFamily.GenericSansSerif, 12), Brushes.Black, e.Bounds.Left, e.Bounds.Top);
                }
            }

        }

        private void listDS_DrawColumnHeader_1(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            // Tô màu nền
            e.Graphics.FillRectangle(Brushes.RoyalBlue, e.Bounds);
            // vẽ lại dòng tiêu đề với font in đậm và màu trắng
            e.Graphics.DrawString(e.Header.Text, new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold), Brushes.White, e.Bounds);

        }

        private void listDS_DrawItem_1(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
            if (e.Item != null)
            {
                if (e.ItemIndex == 0) // Nếu là dòng tiêu đề
                {
                }
                else // Nếu là các dòng dữ liệu
                {
                    // Vẽ các dòng dữ liệu với màu chữ đen và font size nhỏ hơn
                    e.Graphics.DrawString(listDS.Name, new Font(FontFamily.GenericSansSerif, 12), Brushes.Black, e.Bounds.Left, e.Bounds.Top);
                }
            }
        }

        private void listDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listDS.SelectedItems.Count > 0)
            {
                string sql = "select * from KHACHHANG where SoDT = '" + listDS.SelectedItems[0].SubItems[0].Text +"'";
                DataTable dt = CSDL.CSDL.LayDuLieu(sql);
                if(dt != null)
                {
                    tbTen.Text = dt.Rows[0][1].ToString();
                    tbSDT.Text = dt.Rows[0][0].ToString();
                    tbEmail.Text = dt.Rows[0][2].ToString();
                    tbDiaChi.Text = dt.Rows[0][3].ToString();
                    tbGhiChu.Text = dt.Rows[0][4].ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(rdSoDT.Checked == false && rdTen.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn loại tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            listDS.Items.Clear();
            if(rdSoDT.Checked)
            {
                string sql = "select * from KHACHHANG where SoDT like '%"+tbTK.Text+"%'";
                DataTable dt = CSDL.CSDL.LayDuLieu(sql);
                if(dt.Rows.Count > 0)
                {
                    for(int i = 0;  i < dt.Rows.Count; i++)
                    {
                        listDS.Items.Add(dt.Rows[i][0].ToString());
                        listDS.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                        listDS.Items[i].SubItems.Add(dt.Rows[i][3].ToString());
                    }
                    return;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (rdTen.Checked)
            {
                string sql = "select * from KHACHHANG where HoTen like '%" + tbTK.Text + "%'";
                DataTable dt = CSDL.CSDL.LayDuLieu(sql);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        listDS.Items.Add(dt.Rows[i][0].ToString());
                        listDS.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                        listDS.Items[i].SubItems.Add(dt.Rows[i][3].ToString());
                    }
                    return;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(tbTen.Text == "" || tbSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if(tbSDT.Text.Length != 10)
            {
                MessageBox.Show("Vui lòng nhập chính xác số điện thoại (đủ 10 chữ số)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sql = "insert into KHACHHANG(HoTen, SoDT, Email, DiaChi, GhiChu) values (N'"+tbTen.Text+"', '"+tbSDT.Text+"', '"+tbEmail.Text+"', N'"+tbDiaChi.Text+"', N'"+tbGhiChu.Text+"')";
            try
            {
                CSDL.CSDL.XuLy(sql);
                layDSKhachHang();
                MessageBox.Show("Đã thêm thông tin khách hàng mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            catch
            {
                MessageBox.Show("Thêm không thành công. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
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

            string sql = "update KHACHHANG set HoTen = N'"+tbTen.Text+"', Email = '"+tbEmail.Text+"', DiaChi = N'"+tbDiaChi.Text+"', GhiChu = N'"+tbGhiChu.Text+"' where SoDT = '"+tbSDT.Text+"'";
            try
            {
                CSDL.CSDL.XuLy(sql);
                layDSKhachHang();
                MessageBox.Show("Đã cập nhật thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            catch
            {
                MessageBox.Show("Cập nhật không thành công. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tbTen.Text == "" || tbSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            DialogResult result =  MessageBox.Show("Bạn thật sự muốn xóa thông tin khách hàng " + tbTen.Text +"?", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        string sql = "delete KHACHHANG where SoDT = '" + tbSDT.Text + "'";
                        try
                        {
                            CSDL.CSDL.XuLy(sql);
                            layDSKhachHang();
                            MessageBox.Show("Đã xóa thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        catch
                        {
                            MessageBox.Show("Xóa thông tin khách hàng không thành công. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
            }
            
        }
    }
}
