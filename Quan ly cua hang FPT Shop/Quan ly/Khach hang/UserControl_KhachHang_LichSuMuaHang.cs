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
    public partial class UserControl_KhachHang_LichSuMuaHang : UserControl
    {
        public UserControl_KhachHang_LichSuMuaHang()
        {
            InitializeComponent();
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

        private void listDonHang_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            // Tô màu nền
            e.Graphics.FillRectangle(Brushes.RoyalBlue, e.Bounds);
            // vẽ lại dòng tiêu đề với font in đậm và màu trắng
            e.Graphics.DrawString(e.Header.Text, new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold), Brushes.White, e.Bounds);

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
                    e.Graphics.DrawString(listDonHang.Name, new Font(FontFamily.GenericSansSerif, 12), Brushes.Black, e.Bounds.Left, e.Bounds.Top);
                }
            }

        }
        void LayDSKhachHang()
        {
            string sql = "select SoDT, HoTen, GhiChu FROM KHACHHANG";
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            listDS.Items.Clear();
            for(int i = 0;  i < dt.Rows.Count; i++)
            {
                listDS.Items.Add(dt.Rows[i][0].ToString());
                listDS.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                listDS.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
            }
        }

        private void UserControl_KhachHang_LichSuMuaHang_Load(object sender, EventArgs e)
        {
            LayDSKhachHang();
        }

        void LayDSDonHang(string SoDT)
        {
            string sql = $"select MaDH, NgayMuaHang from DONHANG, KHACHHANG where SoDTKhachHang = SoDT and SoDT = '{SoDT}'";
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            listDonHang.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listDonHang.Items.Add(dt.Rows[i][0].ToString());
                listDonHang.Items[i].SubItems.Add(Convert.ToDateTime(dt.Rows[i][1].ToString()).ToString("dd/MM/yyyy"));
            }
        }

        private void listDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listDS.SelectedItems.Count > 0)
            {
                LayDSDonHang(listDS.SelectedItems[0].SubItems[0].Text);
            }
        }
        void LayDSMatHang(string MaDH)
        {
            string sql = $"select MATHANG.TenMH, DANHSACHMATHANGBAN.SL from DANHSACHMATHANGBAN, MATHANG where MATHANG.MaMH = DANHSACHMATHANGBAN.MaMH and MaDH = '{MaDH}'";
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            listMatHang.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listMatHang.Items.Add(dt.Rows[i][0].ToString());
                listMatHang.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
            }
            LayTrangThai(MaDH);
            //MessageBox.Show(MaDH);
        }
        void LayTrangThai(string MaDH)
        {
            string sql = $"select TongCong, TrangThaiDonHang from DONHANG where MaDH = '{MaDH}'";
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lbSoTien.Text = String.Format("{0:#,##0}", dt.Rows[i][0]);
                lbTrangThai.Text = dt.Rows[i][1].ToString();
            }
        }

        private void listDonHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listDonHang.SelectedItems.Count > 0)
            {
                LayDSMatHang(listDonHang.SelectedItems[0].SubItems[0].Text);
                
            }
        }
    }
}
