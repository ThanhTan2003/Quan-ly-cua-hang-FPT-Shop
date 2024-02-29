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

namespace Quan_ly_cua_hang_FPT_Shop.NV_Ban_hang.Quan_ly_mat_hang
{
    public partial class UserControl_NVBanHang_QuanLyMatHang_MatHang : UserControl
    {
        public UserControl_NVBanHang_QuanLyMatHang_MatHang()
        {
            InitializeComponent();
        }

        private const string Url = "Chien-luoc-Marketing-cua-FPT-Shop-1.png";

        DataTable data;
        String PhanLoai = "";
        String ThuongHieu = "";

        

        private void UserControl_NVBanHang_QuanLyMatHang_MatHang_Load(object sender, EventArgs e)
        {
            treeDS.ExpandAll();
            treeDS.ItemHeight = 30;
            treeDS.Indent = 10;

            Font fontCha = new Font(treeDS.Font, FontStyle.Bold);
            treeDS.Font = fontCha;

            // Lặp qua các node con và thiết lập font in thường cho chúng
            foreach (TreeNode nodeCha in treeDS.Nodes)
            {
                foreach (TreeNode nodeCon in nodeCha.Nodes)
                {
                    Font fontCon = new Font(treeDS.Font, FontStyle.Regular);
                    nodeCon.NodeFont = fontCon;
                }
            }
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

        private void listQuaTang_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            // Tô màu nền
            e.Graphics.FillRectangle(Brushes.RoyalBlue, e.Bounds);
            // vẽ lại dòng tiêu đề với font in đậm và màu trắng
            e.Graphics.DrawString(e.Header.Text, new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold), Brushes.White, e.Bounds);
        }

        private void listQuaTang_DrawItem(object sender, DrawListViewItemEventArgs e)
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
                    e.Graphics.DrawString(listQuaTang.Name, new Font(FontFamily.GenericSansSerif, 12), Brushes.Black, e.Bounds.Left, e.Bounds.Top);
                }
            }

        }

        private void treeDS_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent == null)
            {
                string sql = "select * from MATHANG where PhanLoai = N'" + e.Node.Text + "' order by MaMH asc";
                DataTable dt = CSDL.CSDL.LayDuLieu(sql);
                data = CSDL.CSDL.LayDuLieu(sql);
                listDS.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    listDS.Items.Add(dt.Rows[i][0].ToString());
                    listDS.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                    listDS.Items[i].SubItems.Add(dt.Rows[i][4].ToString());
                    listDS.Items[i].SubItems.Add(string.Format("{0:#,##0}", dt.Rows[i][5]));
                    if (dt.Rows[i]["HinhAnh"] != DBNull.Value)
                    {
                        byte[] data = (byte[])dt.Rows[i]["HinhAnh"];
                        using (MemoryStream mem = new MemoryStream(data))
                        {
                            listDS.Items[i].Tag = Image.FromStream(mem); // Lưu hình ảnh vào Tag để sử dụng sau này nếu cần thiết
                        }
                    }

                }
                tbMaMH.Text = "";
                tbTenMH.Text = "";
                cbPhanLoai.Text = e.Node.Text;
                cbXuatXu.Text = "";
                cbThuongHieu.Text = "";
                tbGiaBan.Text = "";
                pic.Load(Url);
                PhanLoai = e.Node.Text;
                ThuongHieu = "";

                tbTuKhoa.Text = "";
                cbMucGia.Text = "Tất cả";
            }
            else
            {
                string sql = "select * from MATHANG where ThuongHieu = N'" + e.Node.Text + "' and PhanLoai = N'" + e.Node.Parent.Text + "' order by MaMH asc";
                DataTable dt = CSDL.CSDL.LayDuLieu(sql);
                data = CSDL.CSDL.LayDuLieu(sql);
                listDS.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    listDS.Items.Add(dt.Rows[i][0].ToString());
                    listDS.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                    listDS.Items[i].SubItems.Add(dt.Rows[i][4].ToString());
                    listDS.Items[i].SubItems.Add(string.Format("{0:#,##0}", dt.Rows[i][5]));
                    if (dt.Rows[i]["HinhAnh"] != DBNull.Value)
                    {
                        byte[] data = (byte[])dt.Rows[i]["HinhAnh"];
                        using (MemoryStream mem = new MemoryStream(data))
                        {
                            listDS.Items[i].Tag = Image.FromStream(mem); // Lưu hình ảnh vào Tag để sử dụng sau này nếu cần thiết
                        }
                    }
                    //listDS.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                }
                tbMaMH.Text = "";
                tbTenMH.Text = "";
                cbPhanLoai.Text = e.Node.Parent.Text;
                cbXuatXu.Text = "";
                cbThuongHieu.Text = e.Node.Text;
                tbGiaBan.Text = "";
                pic.Load(Url);
                PhanLoai = e.Node.Parent.Text;
                ThuongHieu = e.Node.Text;

                tbTuKhoa.Text = "";
                cbMucGia.Text = "Tất cả";
            }
        }

        private void listDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listDS.SelectedItems.Count > 0)
            {
                if (listDS.Items.Count > 0 && listDS.Items[0].Tag != null)
                {
                    pic.Image = (Image)listDS.SelectedItems[0].Tag;
                }
                string sql = "select * from MATHANG where MaMH = '" + listDS.SelectedItems[0].SubItems[0].Text + "'";
                DataTable dt = CSDL.CSDL.LayDuLieu(sql);
                if (dt.Rows.Count > 0)
                {
                    tbMaMH.Text = dt.Rows[0][0].ToString();
                    tbTenMH.Text = dt.Rows[0][1].ToString();
                    cbPhanLoai.Text = dt.Rows[0][2].ToString();
                    cbXuatXu.Text = dt.Rows[0][3].ToString();
                    cbThuongHieu.Text = dt.Rows[0][4].ToString();
                    tbGiaBan.Text = string.Format("{0:#,##0}", dt.Rows[0][5]);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataTable dt = data;

            if (listDS.Items.Count == 0)
            {
                MessageBox.Show("Không tìm thấy mặt hàng phù hợp. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            listDS.Items.Clear();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                String chuoiA = tbTuKhoa.Text;
                String chuoiB = dt.Rows[i][1].ToString();
                if (chuoiB.IndexOf(chuoiA, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    int n = listDS.Items.Count;
                    listDS.Items.Add(dt.Rows[i][0].ToString());
                    listDS.Items[n].SubItems.Add(dt.Rows[i][1].ToString());
                    listDS.Items[n].SubItems.Add(dt.Rows[i][4].ToString());
                    listDS.Items[n].SubItems.Add(string.Format("{0:#,##0}", dt.Rows[i][5]));
                    if (dt.Rows[i]["HinhAnh"] != DBNull.Value)
                    {
                        byte[] data = (byte[])dt.Rows[i]["HinhAnh"];
                        using (MemoryStream mem = new MemoryStream(data))
                        {
                            listDS.Items[n].Tag = Image.FromStream(mem); // Lưu hình ảnh vào Tag để sử dụng sau này nếu cần thiết
                        }
                    }
                }
            }
            tbMaMH.Text = "";
            tbTenMH.Text = "";
            cbPhanLoai.Text = PhanLoai;
            cbXuatXu.Text = "";
            cbThuongHieu.Text = ThuongHieu;
            tbGiaBan.Text = "";
            pic.Load(Url);
            if (listDS.Items.Count == 0)
                MessageBox.Show("Không tìm thấy mặt hàng phù hợp. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cbMucGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = data;
            //Tất cả
            //Dưới 5 triệu
            //Từ 5 - 10 triệu
            //Từ 10 - 20 triệu
            // Trên 20 triệu
            int Muc1 = 0;
            int Muc2 = 0;
            if (listDS.Items.Count == 0 && cbMucGia.Text == "")
            {
                MessageBox.Show("Không tìm thấy mặt hàng phù hợp. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch (cbMucGia.Text)
            {
                case "Tất cả":
                    Muc1 = -1;
                    break;
                case "Dưới 5 triệu":
                    Muc2 = 5000000;
                    break;
                case "Từ 5 - 10 triệu":
                    Muc1 = 5000000;
                    Muc2 = 10000000;
                    break;
                case "Từ 10 - 20 triệu":
                    Muc1 = 10000000;
                    Muc2 = 20000000;
                    break;
                case "Trên 20 triệu":
                    Muc2 = -1;
                    break;
            }
            listDS.Items.Clear();
            if (Muc1 == -1)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    listDS.Items.Add(dt.Rows[i][0].ToString());
                    listDS.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                    listDS.Items[i].SubItems.Add(dt.Rows[i][4].ToString());
                    listDS.Items[i].SubItems.Add(string.Format("{0:#,##0}", dt.Rows[i][5]));
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
            else if (Muc2 == -1)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dt.Rows[i][5]) > 20000000)
                    {
                        int n = listDS.Items.Count;
                        listDS.Items.Add(dt.Rows[i][0].ToString());
                        listDS.Items[n].SubItems.Add(dt.Rows[i][1].ToString());
                        listDS.Items[n].SubItems.Add(dt.Rows[i][4].ToString());
                        listDS.Items[n].SubItems.Add(string.Format("{0:#,##0}", dt.Rows[i][5]));
                        if (dt.Rows[i]["HinhAnh"] != DBNull.Value)
                        {
                            byte[] data = (byte[])dt.Rows[i]["HinhAnh"];
                            using (MemoryStream mem = new MemoryStream(data))
                            {
                                listDS.Items[n].Tag = Image.FromStream(mem); // Lưu hình ảnh vào Tag để sử dụng sau này nếu cần thiết
                            }
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dt.Rows[i][5]) >= Muc1 && Convert.ToInt32(dt.Rows[i][5]) <= Muc2)
                    {
                        int n = listDS.Items.Count;
                        listDS.Items.Add(dt.Rows[i][0].ToString());
                        listDS.Items[n].SubItems.Add(dt.Rows[i][1].ToString());
                        listDS.Items[n].SubItems.Add(dt.Rows[i][4].ToString());
                        listDS.Items[n].SubItems.Add(string.Format("{0:#,##0}", dt.Rows[i][5]));
                        if (dt.Rows[i]["HinhAnh"] != DBNull.Value)
                        {
                            byte[] data = (byte[])dt.Rows[i]["HinhAnh"];
                            using (MemoryStream mem = new MemoryStream(data))
                            {
                                listDS.Items[n].Tag = Image.FromStream(mem); // Lưu hình ảnh vào Tag để sử dụng sau này nếu cần thiết
                            }
                        }
                    }
                }
            }

            tbMaMH.Text = "";
            tbTenMH.Text = "";
            cbPhanLoai.Text = PhanLoai;
            cbXuatXu.Text = "";
            cbThuongHieu.Text = ThuongHieu;
            tbGiaBan.Text = "";
            pic.Load(Url);
        }

        private void treeDS_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent == null)
            {
                string sql = "select * from MATHANG where PhanLoai = N'" + e.Node.Text + "' order by MaMH asc";
                DataTable dt = CSDL.CSDL.LayDuLieu(sql);
                data = CSDL.CSDL.LayDuLieu(sql);
                listDS.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    listDS.Items.Add(dt.Rows[i][0].ToString());
                    listDS.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                    listDS.Items[i].SubItems.Add(dt.Rows[i][4].ToString());
                    listDS.Items[i].SubItems.Add(string.Format("{0:#,##0}", dt.Rows[i][5]));
                    if (dt.Rows[i]["HinhAnh"] != DBNull.Value)
                    {
                        byte[] data = (byte[])dt.Rows[i]["HinhAnh"];
                        using (MemoryStream mem = new MemoryStream(data))
                        {
                            listDS.Items[i].Tag = Image.FromStream(mem); // Lưu hình ảnh vào Tag để sử dụng sau này nếu cần thiết
                        }
                    }

                }
                tbMaMH.Text = "";
                tbTenMH.Text = "";
                cbPhanLoai.Text = e.Node.Text;
                cbXuatXu.Text = "";
                cbThuongHieu.Text = "";
                tbGiaBan.Text = "";
                pic.Load(Url);
                PhanLoai = e.Node.Text;
                ThuongHieu = "";

                tbTuKhoa.Text = "";
                cbMucGia.Text = "Tất cả";
            }
            else
            {
                string sql = "select * from MATHANG where ThuongHieu = N'" + e.Node.Text + "' and PhanLoai = N'" + e.Node.Parent.Text + "' order by MaMH asc";
                DataTable dt = CSDL.CSDL.LayDuLieu(sql);
                data = CSDL.CSDL.LayDuLieu(sql);
                listDS.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    listDS.Items.Add(dt.Rows[i][0].ToString());
                    listDS.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                    listDS.Items[i].SubItems.Add(dt.Rows[i][4].ToString());
                    listDS.Items[i].SubItems.Add(string.Format("{0:#,##0}", dt.Rows[i][5]));
                    if (dt.Rows[i]["HinhAnh"] != DBNull.Value)
                    {
                        byte[] data = (byte[])dt.Rows[i]["HinhAnh"];
                        using (MemoryStream mem = new MemoryStream(data))
                        {
                            listDS.Items[i].Tag = Image.FromStream(mem); // Lưu hình ảnh vào Tag để sử dụng sau này nếu cần thiết
                        }
                    }
                    //listDS.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                }
                tbMaMH.Text = "";
                tbTenMH.Text = "";
                cbPhanLoai.Text = e.Node.Parent.Text;
                cbXuatXu.Text = "";
                cbThuongHieu.Text = e.Node.Text;
                tbGiaBan.Text = "";
                pic.Load(Url);
                PhanLoai = e.Node.Parent.Text;
                ThuongHieu = e.Node.Text;

                tbTuKhoa.Text = "";
                cbMucGia.Text = "Tất cả";
            }
        }
    }
}
