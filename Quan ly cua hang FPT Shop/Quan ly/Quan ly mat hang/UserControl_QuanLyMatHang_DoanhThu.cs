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
    public partial class UserControl_QuanLyMatHang_DoanhThu : UserControl
    {
        public UserControl_QuanLyMatHang_DoanhThu()
        {
            InitializeComponent();
        }

        private void listDoanhThu_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            // Tô màu nền
            e.Graphics.FillRectangle(Brushes.RoyalBlue, e.Bounds);
            // vẽ lại dòng tiêu đề với font in đậm và màu trắng
            e.Graphics.DrawString(e.Header.Text, new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold), Brushes.White, e.Bounds);


        }

        private void listDonHang_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            // Tô màu nền
            e.Graphics.FillRectangle(Brushes.RoyalBlue, e.Bounds);
            // vẽ lại dòng tiêu đề với font in đậm và màu trắng
            e.Graphics.DrawString(e.Header.Text, new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold), Brushes.White, e.Bounds);

        }

        private void listDoanhThu_DrawItem(object sender, DrawListViewItemEventArgs e)
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
                    e.Graphics.DrawString(listDoanhThu.Name, new Font(FontFamily.GenericSansSerif, 12), Brushes.Black, e.Bounds.Left, e.Bounds.Top);
                }
            }

        }

        private void listDonHang_DrawItem(object sender, DrawListViewItemEventArgs e)
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
                    e.Graphics.DrawString(listDonHang.Name, new Font(FontFamily.GenericSansSerif, 12), Brushes.Black, e.Bounds.Left, e.Bounds.Top);
                }
            }
        }

        void LayNam()
        {
            string sql = "select distinct year(NgayMuaHang) from DONHANG";
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            cbNam.Items.Clear();
            for(int i = 0; i < dt.Rows.Count; i++)
                cbNam.Items.Add(dt.Rows[i][0].ToString());
        }

        private void UserControl_QuanLyMatHang_DoanhThu_Load(object sender, EventArgs e)
        {
            LayNam();
        }

        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbThang.Items.Clear();
            string sql = $"select distinct month(NgayMuaHang) from DONHANG where YEAR(NgayMuaHang) = {cbNam.Text}";
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
                cbThang.Items.Add(dt.Rows[i][0].ToString());
        }

        void LayDSThongKe()
        {
            string sql = $"SELECT convert(varchar(10),NgayMuaHang, 103) as NgayMuaHang, SUM(TongCong) AS TongCongNgay, NgayMuaHang FROM DONHANG where year(NgayMuaHang) = {cbNam.Text} and Month(NgayMuaHang) = {cbThang.Text} GROUP BY NgayMuaHang";
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            listDoanhThu.Items.Clear();
            long Tong = 0;
            for(int i = 0; i < dt.Rows.Count;i++)
            {
                listDoanhThu.Items.Add((i + 1).ToString());
                listDoanhThu.Items[i].SubItems.Add(dt.Rows[i][0].ToString());
                listDoanhThu.Items[i].SubItems.Add(String.Format("{0:#,##0}", dt.Rows[i][1]));
                Tong += Convert.ToInt32(dt.Rows[i][1]);
                listDoanhThu.Items[i].Tag = Convert.ToDateTime(dt.Rows[i][2]).ToString("yyyy/MM/dd");
            }
            lbTongDoanhThu.Text = String.Format("{0:#,##0}", Tong);
        }

        private void listDoanhThu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listDoanhThu.SelectedItems.Count > 0)
            {
                string sql = $"select MaDH, HoTen, TongCong from DONHANG, KHACHHANG where DONHANG.SoDTKhachHang = KHACHHANG.SoDT and NgayMuaHang = '{listDoanhThu.SelectedItems[0].Tag}'";
                DataTable dt = CSDL.CSDL.LayDuLieu(sql);
                listDonHang.Items.Clear();
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    listDonHang.Items.Add((i+1).ToString());
                    listDonHang.Items[i].SubItems.Add(dt.Rows[i][0].ToString());
                    listDonHang.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                    listDonHang.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                }
                lbTongDon.Text = listDonHang.Items.Count.ToString();
            }
        }

        private void cbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LayDSThongKe();
        }
    }
}
