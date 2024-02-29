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

namespace Quan_ly_cua_hang_FPT_Shop.NV_QL_kho.Quan_ly_kho
{
    public partial class UserControl_NVQLKho_QuanLyKho_NhapKho : UserControl
    {
        public UserControl_NVQLKho_QuanLyKho_NhapKho()
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

        private void listView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
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

        private void listNhapKho_DrawItem(object sender, DrawListViewItemEventArgs e)
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
                    e.Graphics.DrawString(listNhapKho.Name, new Font(FontFamily.GenericSansSerif, 12), Brushes.Black, e.Bounds.Left, e.Bounds.Top);
                }
            }

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

        private void UserControl_NVQLKho_QuanLyKho_NhapKho_Load(object sender, EventArgs e)
        {
            LayDSPhanLoai();
        }

        private void cbPhanLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select MaMH, TenMH, HinhAnh from MATHANG where PhanLoai = N'" + cbPhanLoai.Text + "' order by TenMH asc";
            listDS.Items.Clear();
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listDS.Items.Add(dt.Rows[i][0].ToString());
                listDS.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                if (dt.Rows[i]["HinhAnh"] != DBNull.Value)
                {
                    byte[] data = (byte[])dt.Rows[i]["HinhAnh"];
                    using (MemoryStream mem = new MemoryStream(data))
                    {
                        listDS.Items[i].Tag = Image.FromStream(mem); // Lưu hình ảnh vào Tag để sử dụng sau này nếu cần thiết
                    }
                }
            }
            tbTuKhoa.Text = "";
            rdTen.Checked = false;
            rdMa.Checked = false;
        }
        void LaySLTonKho(string MaMH)
        {
            string sql = $"select SL From MATHANG where MaMH = '{MaMH}'";
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            if(dt.Rows.Count > 0)
            {
                numTonKho.Value = Convert.ToInt32(dt.Rows[0][0].ToString()) ;
            }
        }

        private void listDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listDS.SelectedItems.Count > 0)
            {
                if (listDS.Items.Count > 0 && listDS.Items[0].Tag != null)
                {
                    pic.Image = (Image)listDS.SelectedItems[0].Tag;
                    pic.Visible = true;
                }
                tbMaMH.Text = listDS.SelectedItems[0].SubItems[0].Text;
                tbTenMH.Text = listDS.SelectedItems[0].SubItems[1].Text;
                numSL.Value = 0;
                LaySLTonKho(tbMaMH.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = listNhapKho.Items.Count;
            if(tbMaMH.Text !="" && numSL.Value > 0)
            {
                listNhapKho.Items.Add(tbMaMH.Text);
                listNhapKho.Items[n].SubItems.Add(tbTenMH.Text);
                listNhapKho.Items[n].SubItems.Add(numSL.Value.ToString());
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(listNhapKho.SelectedItems.Count > 0)
            {
                listNhapKho.Items.RemoveAt(listNhapKho.SelectedIndices[0]);
            }
        }

        bool KiemTraDanhSach(string MaMH)
        {
            for(int i = 0; i < listNhapKho.Items.Count; i++)
            {
                if(MaMH == listNhapKho.Items[i].SubItems[i].Text)
                {
                    return true;
                }
            }
            return false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(tbMaMH.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mặt hàng cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if(KiemTraDanhSach(tbMaMH.Text))
            {
                for(int i = 0; i < listNhapKho.Items[i].SubItems.Count; i++)
                {
                    if(tbMaMH.Text == listNhapKho.Items[i].SubItems[0].Text)
                    {
                        //int SL = Convert.ToInt32(listNhapKho.Items[i].SubItems[2].Text);
                        listNhapKho.Items[i].SubItems[2].Text = numSL.Value.ToString();
                        break;
                    }
                }
                MessageBox.Show("Đã cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Mặt hàng không có trong danh sách nhập kho!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(listNhapKho.Items.Count > 0)
            {
                for(int i = 0; i < listNhapKho.Items.Count; i++)
                {
                    string sql = $"insert KIEMKE(MaMH, SLTruoc, SLSau, ThoiGian) values ('{listNhapKho.Items[i].SubItems[0].Text}', (select SL From MATHANG where MaMH = '{listNhapKho.Items[i].SubItems[0].Text}'), ((select SL From MATHANG where MaMH = '{listNhapKho.Items[i].SubItems[0].Text}') + {listNhapKho.Items[i].SubItems[2].Text}), '{date.Value.ToString("yyyy/MM/dd")}')";
                    CSDL.CSDL.XuLy(sql);
                    sql = $"UPDATE MATHANG SET SL = SL + {listNhapKho.Items[i].SubItems[2].Text} where MaMH = '{listNhapKho.Items[i].SubItems[0].Text}'";
                    CSDL.CSDL.XuLy(sql);
                    sql = $"insert NHAPKHO (MaMH, SL, Ngay) values ('{listNhapKho.Items[i].SubItems[0].Text}', {listNhapKho.Items[i].SubItems[2].Text}, '{date.Value.ToString("yyyy/MM/dd")}')";
                    CSDL.CSDL.XuLy(sql);
                    listNhapKho.Items.Clear();
                    tbMaMH.Text = "";
                    tbTenMH.Text = "";
                    numSL.Value = 0;
                    numTonKho.Value = 0;
                    pic.Visible = false;

                }
                MessageBox.Show("Đã nhập kho thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mặt hàng cần nhập kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void listNhapKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listDS.SelectedItems.Count > 0)
            {
                try
                {
                    tbMaMH.Text = listNhapKho.SelectedItems[0].SubItems[0].Text;
                    tbTenMH.Text = listNhapKho.SelectedItems[0].SubItems[1].Text;
                    numSL.Value = Convert.ToInt32(listNhapKho.SelectedItems[0].SubItems[2].Text);
                    pic.Visible = false;
                }
                catch { }
            }
        }
    }
}
