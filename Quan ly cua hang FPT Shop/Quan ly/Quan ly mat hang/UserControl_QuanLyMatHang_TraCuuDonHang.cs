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
    public partial class UserControl_QuanLyMatHang_TraCuuDonHang : UserControl
    {
        public UserControl_QuanLyMatHang_TraCuuDonHang()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        void LayTrangThaiDonHang()
        {
            string sql = "select distinct TrangThaiDonHang from DONHANG";
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            cbTrangThai.Items.Clear();
            
            for(int i = 0;  i < dt.Rows.Count; i++)
                cbTrangThai.Items.Add(dt.Rows[i][0].ToString());
        }
        void LayDanhSachDonHang()
        {
            listDS.Items.Clear();
            string sql = "select MaDH, KHACHHANG.HoTen, TrangThaiDonHang  from DONHANG, KHACHHANG where DONHANG.SoDTKhachHang = KHACHHANG.SoDT";
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            for(int i = 0; i < dt.Rows.Count;i++)
            {
                listDS.Items.Add(dt.Rows[i][0].ToString());
                listDS.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                listDS.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
            }
        }

        private void UserControl_QuanLyMatHang_TraCuuDonHang_Load(object sender, EventArgs e)
        {
            LayTrangThaiDonHang();
            LayDanhSachDonHang();
            //cbTrangThai.Text = "";
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

        private void listMatHang_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            // Tô màu nền
            e.Graphics.FillRectangle(Brushes.RoyalBlue, e.Bounds);
            // vẽ lại dòng tiêu đề với font in đậm và màu trắng
            e.Graphics.DrawString(e.Header.Text, new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold), Brushes.White, e.Bounds);
        }

        private void listMatHang_DrawItem(object sender, DrawListViewItemEventArgs e)
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
                   // e.Graphics.DrawString(listMatHang.Name, new Font(FontFamily.GenericSansSerif, 12), Brushes.Black, e.Bounds.Left, e.Bounds.Top);
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

        private void cbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            listDS.Items.Clear();
            string sql = $"select MaDH, KHACHHANG.HoTen, TrangThaiDonHang  from DONHANG, KHACHHANG where DONHANG.SoDTKhachHang = KHACHHANG.SoDT and TrangThaiDonHang = N'{cbTrangThai.Text}'";
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listDS.Items.Add(dt.Rows[i][0].ToString());
                listDS.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                listDS.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
            }
        }

        private void listDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listDS.SelectedItems.Count > 0)
            {
                string sql = $"select KHACHHANG.HoTen, SoDT, MaDH, ThuNgan, convert(varchar(10), NgayMuaHang, 103) as NgayMuaHang, TongTien, GiamGia, TongCong, NguoiGiaoHang, TrangThaiDonHang, DiaChiGiaoHang, DONHANG.GhiChu, SoDTNguoiNhan From DONHANG, KHACHHANG where DONHANG.SoDTKhachHang = KHACHHANG.SoDT and MaDH = '{listDS.SelectedItems[0].SubItems[0].Text}'";
                DataTable dt = CSDL.CSDL.LayDuLieu(sql);
                if(dt.Rows.Count > 0)
                {
                    tbTenKH.Text = dt.Rows[0][0].ToString();
                    tbSoDT.Text = dt.Rows[0][1].ToString();
                    tbMaDH.Text = dt.Rows[0][2].ToString();
                    tbThuNgan.Text = dt.Rows[0][3].ToString();
                    tbNgayMuaHang.Text = dt.Rows[0][4].ToString();
                    tbTongTien.Text = String.Format("{0:#,##0}", dt.Rows[0][5]);
                    tbGiamGia.Text = String.Format("{0:#,##0}", dt.Rows[0][6]);
                    tbTongCong.Text = String.Format("{0:#,##0}", dt.Rows[0][7]);
                    tbNguoiGH.Text = dt.Rows[0][8].ToString();
                    tbTrangThai.Text = dt.Rows[0][9].ToString();
                    tbDiaChi.Text = dt.Rows[0][10].ToString();
                    tbGhiChu.Text = dt.Rows[0][11].ToString();
                    tbSoDTNguoiNhan.Text = dt.Rows[0][12].ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbMaDH.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần tải lại hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                HoaDon1 f = new HoaDon1(tbMaDH.Text);
                f.ShowDialog();
            }
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            if(tbtuKhoa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập từ khóa cần tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            listDS.Items.Clear();
            cbTrangThai.Text = "";
            if(rdMaDH.Checked == true)
            {
                listDS.Items.Clear();
                string sql = $"select MaDH, KHACHHANG.HoTen, TrangThaiDonHang  from DONHANG, KHACHHANG where DONHANG.SoDTKhachHang = KHACHHANG.SoDT and MaDH like '%{tbtuKhoa.Text}%'";
                DataTable dt = CSDL.CSDL.LayDuLieu(sql);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    listDS.Items.Add(dt.Rows[i][0].ToString());
                    listDS.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                    listDS.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                }
            }
            else if (rdTenKH.Checked == true)
            {
                listDS.Items.Clear();
                string sql = $"select MaDH, KHACHHANG.HoTen, TrangThaiDonHang  from DONHANG, KHACHHANG where DONHANG.SoDTKhachHang = KHACHHANG.SoDT and HoTen like N'%{tbtuKhoa.Text}%'";
                DataTable dt = CSDL.CSDL.LayDuLieu(sql);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    listDS.Items.Add(dt.Rows[i][0].ToString());
                    listDS.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                    listDS.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                }
            }
            else if(rdSoDT.Checked == true)
            {
                listDS.Items.Clear();
                string sql = $"select MaDH, KHACHHANG.HoTen, TrangThaiDonHang  from DONHANG, KHACHHANG where DONHANG.SoDTKhachHang = KHACHHANG.SoDT and SoDT like N'%{tbtuKhoa.Text}%'";
                DataTable dt = CSDL.CSDL.LayDuLieu(sql);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    listDS.Items.Add(dt.Rows[i][0].ToString());
                    listDS.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                    listDS.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin phù hợp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
