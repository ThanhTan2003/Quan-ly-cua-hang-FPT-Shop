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
    public partial class UserControl_QuanLyNhanSu_QuanLyTaiKhoan : UserControl
    {
        public UserControl_QuanLyNhanSu_QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void listView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            // Tô màu nền
            e.Graphics.FillRectangle(Brushes.RoyalBlue, e.Bounds);
            // vẽ lại dòng tiêu đề với font in đậm và màu trắng
            e.Graphics.DrawString(e.Header.Text, new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold), Brushes.White, e.Bounds);
        }

        private void listView1_DrawItem(object sender, DrawListViewItemEventArgs e)
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

        void LayDanhSachTaiKhoan()
        {
            string sql = "select TAIKHOAN.MaNV, HoTen, NHANVIEN.ViTri, TAIKHOAN.TenHienThi, TK from TAIKHOAN, NHANVIEN where NHANVIEN.MaNV = TAIKHOAN.MaNV";
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            listDS.Items.Clear();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                listDS.Items.Add(dt.Rows[i][0].ToString());
                listDS.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                listDS.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                listDS.Items[i].SubItems.Add(dt.Rows[i][3].ToString());
                listDS.Items[i].SubItems.Add(dt.Rows[i][4].ToString());
            }
        }

        private void UserControl_QuanLyNhanSu_QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            
            //cbLoaiTK.Enabled = false;
            LayDanhSachTaiKhoan();
            cbLoaiTK.Items.Clear();
            string sql = "select distinct LoaiTK from TAIKHOAN";
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
                cbLoaiTK.Items.Add(dt.Rows[i][0].ToString());
        }
        void LayThongTinTaiKhoan(string TK)
        {
            string sql = $"select TAIKHOAN.MaNV, HoTen, NgaySinh, NHANVIEN.ViTri, LoaiTK, TAIKHOAN.TenHienThi, TK, MK from TAIKHOAN, NHANVIEN where NHANVIEN.MaNV = TAIKHOAN.MaNV and TK = '{TK}'";
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            if(dt.Rows.Count > 0)
            {
                lbMaNV.Text = dt.Rows[0][0].ToString();
                lbHoTen.Text = dt.Rows[0][1].ToString();
                lbNgaySinh.Text = Convert.ToDateTime(dt.Rows[0][2].ToString()).ToString("dd/MM/yyyy");
                lbViTri.Text = dt.Rows[0][3].ToString();
                cbLoaiTK.Text = dt.Rows[0][4].ToString();
                tbTenHienThi.Text = dt.Rows[0][5].ToString();
                tbTK.Text = dt.Rows[0][6].ToString();
                tbMK.Text = dt.Rows[0][7].ToString();
            }
        }

        private void listDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listDS.SelectedItems.Count > 0)
            {
                LayThongTinTaiKhoan(listDS.SelectedItems[0].SubItems[4].Text);
            }
        }
        void LayTaiKhoan(string MaNV)
        {
            string sql = $"select LoaiTK, TenHienThi, TK, MK from TAIKHOAN where MaNV = '{MaNV}'";
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            if(dt.Rows.Count > 0)
            {
                cbLoaiTK.Text = dt.Rows[0][0].ToString();
                tbTenHienThi.Text = dt.Rows[0][1].ToString();
                tbTK.Text = dt.Rows[0][2].ToString();
                tbMK.Text = dt.Rows[0][3].ToString();
            }
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            if(tbTim.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            lbMaNV.Text = "...";
            lbHoTen.Text = "...";
            lbNgaySinh.Text = ".../.../...";
            string sql = $"select MaNV, HoTen, NgaySinh, ViTri from NHANVIEN where MaNV = '{tbTim.Text}'";
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            if(dt.Rows.Count > 0)
            {
                lbMaNV.Text = dt.Rows[0][0].ToString();
                lbHoTen.Text = dt.Rows[0][1].ToString();
                lbNgaySinh.Text = Convert.ToDateTime(dt.Rows[0][2].ToString()).ToString("dd/MM/yyyy");
                lbViTri.Text = dt.Rows[0][3].ToString();
                LayTaiKhoan(lbMaNV.Text);
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên phù hợp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (lbMaNV.Text == "" && tbTK.Text == "")
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }

            string delete = "DELETE FROM TAIKHOAN";
            string whereClause = $" WHERE TK = '{tbTK.Text}'";

            DialogResult result = MessageBox.Show($"Bạn thật sự muốn xóa nhân viên {tbTK.Text}?", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string sql = delete + whereClause;
                    CSDL.CSDL.XuLy(sql);
                    LayDanhSachTaiKhoan();
                    MessageBox.Show("Đã xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                catch
                {
                    MessageBox.Show("Không thể xóa tài khoản. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (lbMaNV.Text == "" && tbTK.Text == "" || cbLoaiTK.Text == "" || tbMK.Text == "" || tbTenHienThi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            string sql = $"insert into dbo.TAIKHOAN(MaNV,TK,MK,LoaiTK,TenHienThi,TinhTrang) values ('{lbMaNV.Text}', '{tbTK.Text}', '{tbMK.Text}', N'{cbLoaiTK.Text}', N'{tbTenHienThi.Text}', N'Đang sử dụng')";
            try
            {
                CSDL.CSDL.XuLy(sql);
                LayDanhSachTaiKhoan();
                MessageBox.Show("Đã thêm tài khoản mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Không thể thêm mới tài khoản. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbMaNV.Text == "" && tbTK.Text == "" || cbLoaiTK.Text == "" || tbMK.Text == "" || tbTenHienThi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            string sql = $"UPDATE dbo.TAIKHOAN SET TK = '{tbTK.Text}', MK = '{tbMK.Text}', LoaiTK = N'{cbLoaiTK.Text}', TenHienThi = N'{tbTenHienThi.Text}', TinhTrang = N'Đang sử dụng' WHERE MaNV = '{lbMaNV.Text}'";
            try
            {
                CSDL.CSDL.XuLy(sql);
                LayDanhSachTaiKhoan();
                MessageBox.Show("Đã cập nhật thông tin tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Không thể cập nhật thông tin tài khoản. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
