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
    public partial class UserControl_QuanLyNhanSu_ThuongPhat : UserControl
    {
        public UserControl_QuanLyNhanSu_ThuongPhat()
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

        private void listThuong_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            // Tô màu nền
            e.Graphics.FillRectangle(Brushes.RoyalBlue, e.Bounds);
            // vẽ lại dòng tiêu đề với font in đậm và màu trắng
            e.Graphics.DrawString(e.Header.Text, new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold), Brushes.White, e.Bounds);
        }

        private void listThuong_DrawItem(object sender, DrawListViewItemEventArgs e)
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
                    e.Graphics.DrawString(listThuong.Name, new Font(FontFamily.GenericSansSerif, 12), Brushes.Black, e.Bounds.Left, e.Bounds.Top);
                }
            }
        }

        private void listPhat_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            // Tô màu nền
            e.Graphics.FillRectangle(Brushes.RoyalBlue, e.Bounds);
            // vẽ lại dòng tiêu đề với font in đậm và màu trắng
            e.Graphics.DrawString(e.Header.Text, new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold), Brushes.White, e.Bounds);
        }

        private void listPhat_DrawItem(object sender, DrawListViewItemEventArgs e)
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
                    e.Graphics.DrawString(listPhat.Name, new Font(FontFamily.GenericSansSerif, 12), Brushes.Black, e.Bounds.Left, e.Bounds.Top);
                }
            }
        }

        private void UserControl_QuanLyNhanSu_ThuongPhat_Load(object sender, EventArgs e)
        {
            rdThuong.Checked = false;
            rdPhat.Checked = false;
            tbThuong_SoTien.Enabled = false;
            tbThuong_LyDo.Enabled = false;
            tbPhat_LyDo.Enabled = false;
            tbPhat_SoTien.Enabled = false;

        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            rdThuong.Checked = false;
            rdPhat.Checked = false;

            tbThuong_SoTien.Text = "";
            tbThuong_LyDo.Text = "";
            tbPhat_LyDo.Text = "";
            tbPhat_SoTien.Text = "";

            tbThuong_SoTien.Enabled = false;
            tbThuong_LyDo.Enabled = false;
            tbPhat_LyDo.Enabled = false;
            tbPhat_SoTien.Enabled = false;
        }

        private void rdThuong_CheckedChanged(object sender, EventArgs e)
        {
            tbThuong_SoTien.Enabled = true;
            tbThuong_LyDo.Enabled = true;
            tbPhat_SoTien.Enabled = false;
            tbPhat_LyDo.Enabled = false;
        }

        private void rdPhat_CheckedChanged(object sender, EventArgs e)
        {
            tbThuong_SoTien.Enabled = false;
            tbThuong_LyDo.Enabled = false;
            tbPhat_SoTien.Enabled = true;
            tbPhat_LyDo.Enabled = true;
        }
    }
}
