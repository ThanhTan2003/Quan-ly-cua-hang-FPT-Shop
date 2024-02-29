using Quan_ly_cua_hang_FPT_Shop.CSDL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_cua_hang_FPT_Shop
{
    public partial class UserControl_QuanLyKho_TheoDoiTonKho : UserControl
    {
        public UserControl_QuanLyKho_TheoDoiTonKho()
        {
            InitializeComponent();
        }

        private const string Url = "Chien-luoc-Marketing-cua-FPT-Shop-1.png";
        void LayDSPhanLoai()
        {
            cbPhanLoai.Items.Clear();
            string sql = "select distinct PhanLoai from MATHANG";
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
                cbPhanLoai.Items.Add(dt.Rows[i][0].ToString());
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

        private void listSL_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            // Tô màu nền
            e.Graphics.FillRectangle(Brushes.RoyalBlue, e.Bounds);
            // vẽ lại dòng tiêu đề với font in đậm và màu trắng
            e.Graphics.DrawString(e.Header.Text, new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold), Brushes.White, e.Bounds);

        }

        private void listSL_DrawItem(object sender, DrawListViewItemEventArgs e)
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
                    e.Graphics.DrawString(listSL.Name, new Font(FontFamily.GenericSansSerif, 12), Brushes.Black, e.Bounds.Left, e.Bounds.Top);
                }
            }

        }

        private void UserControl_QuanLyKho_TheoDoiTonKho_Load(object sender, EventArgs e)
        {
            LayDSPhanLoai();
        }

        private void cbPhanLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select MaMH, TenMH, SL, HinhAnh from MATHANG where PhanLoai = N'" + cbPhanLoai.Text + "' order by TenMH asc";
            listDS.Items.Clear();
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listDS.Items.Add(dt.Rows[i][0].ToString());
                listDS.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                listDS.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                if (dt.Rows[i]["HinhAnh"] != DBNull.Value)
                {
                    byte[] data = (byte[])dt.Rows[i]["HinhAnh"];
                    using (MemoryStream mem = new MemoryStream(data))
                    {
                        listDS.Items[i].Tag = Image.FromStream(mem); // Lưu hình ảnh vào Tag để sử dụng sau này nếu cần thiết
                    }
                }
            }
        }

        private void listDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listDS.SelectedItems.Count > 0)
            {
                listSL.Items.Clear();
                tbMaMH.Text = listDS.SelectedItems[0].SubItems[0].Text;
                tbTenMH.Text = listDS.SelectedItems[0].SubItems[1].Text;
                tbSL.Text = listDS.SelectedItems[0].SubItems[2].Text;
                if (listDS.Items.Count > 0 && listDS.Items[0].Tag != null)
                {
                    pic.Image = (Image)listDS.SelectedItems[0].Tag;
                }
                string sql = "select * from KIEMKE where MaMH = '" + listDS.SelectedItems[0].SubItems[0].Text +"' order by ThoiGian desc";
                DataTable dt = CSDL.CSDL.LayDuLieu(sql);
                for(int i = 0; i < dt.Rows.Count;i++)
                {
                    listSL.Items.Add(dt.Rows[i][0].ToString());
                    listSL.Items[i].SubItems.Add(tbTenMH.Text);
                    listSL.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                    listSL.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                    DateTime date = Convert.ToDateTime(dt.Rows[i][4].ToString());
                    listSL.Items[i].SubItems.Add(date.ToString("dd/MM/yyyy"));
                }
            }
        }

        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbTuKhoa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập từ khóa cần tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (rdMa.Checked == false && rdTen.Checked == false)
            {
                MessageBox.Show("Vui lòng nhập chọn loại tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            DataTable dt = new DataTable();
            if (rdTen.Checked)
            {
                string sql = "select MaMH, TenMH, SL from MATHANG where TenMH like N'%" + tbTuKhoa.Text + "%' order by TenMH asc";
                cbPhanLoai.Text = "";
                listDS.Items.Clear();
                dt = CSDL.CSDL.LayDuLieu(sql);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    listDS.Items.Add(dt.Rows[i][0].ToString());
                    listDS.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                    listDS.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                }
            }
            if (rdMa.Checked)
            {
                string sql = "select MaMH, TenMH, SL from MATHANG where MaMH like N'%" + tbTuKhoa.Text + "%' order by TenMH asc";
                cbPhanLoai.Text = "";
                listDS.Items.Clear();
                dt = CSDL.CSDL.LayDuLieu(sql);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    listDS.Items.Add(dt.Rows[i][0].ToString());
                    listDS.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                    listDS.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                }
            }
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy mặt hàng phù hợp. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
