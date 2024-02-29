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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quan_ly_cua_hang_FPT_Shop
{
    public partial class UserControl_QuanLyMatHang_MatHang : UserControl
    {
        private const string Url = "Chien-luoc-Marketing-cua-FPT-Shop-1.png";

        //DataTable data;
        String PhanLoai = "";
        String ThuongHieu = "";
        string NamePic = "";
        string strSQL = "";

        bool ThayDoiHinhAnh = false;

        private Byte[] ImageToByteArray(string imgLocation)
        {
            Byte[] img = null;
            FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);

            return img;
        }

        public UserControl_QuanLyMatHang_MatHang()
        {
            InitializeComponent();
        }
        void LayDSPhanLoai()
        {
            string sql = "select distinct PhanLoai from MATHANG";
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            cbPhanLoai.Items.Clear();
            for(int i = 0; i < dt.Rows.Count; i++)
                cbPhanLoai.Items.Add(dt.Rows[i][0].ToString());
        }
        void LayDSXuatXu()
        {
            string sql = "select distinct XuatXu from MATHANG where PhanLoai = N'"+cbPhanLoai.Text+"'";
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            cbXuatXu.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
                cbXuatXu.Items.Add(dt.Rows[i][0].ToString());
        }
        void LayDSThuongHieu()
        {
            string sql = "select distinct ThuongHieu from MATHANG where PhanLoai = N'" + cbPhanLoai.Text + "'";
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            cbThuongHieu.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
                cbThuongHieu.Items.Add(dt.Rows[i][0].ToString());
        }

        private void UserControl_QuanLyMatHang_MatHang_Load(object sender, EventArgs e)
        {
            LayDSPhanLoai();
            //LayDSThuongHieu();
            //LayDSXuatXu();
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
            //listDS.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

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
                   // e.Graphics.DrawString(listQuaTang.Name, new Font(FontFamily.GenericSansSerif, 12), Brushes.Black, e.Bounds.Left, e.Bounds.Top);
                }
            }
        }

        
        private void treeDS_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            if(e.Node.Parent == null)
            {
                string sql = "select * from MATHANG where PhanLoai = N'"+e.Node.Text+ "' order by MaMH asc";
                strSQL = sql;
                DataTable dt = CSDL.CSDL.LayDuLieu(sql);
                //data = Database.LayDuLieu(sql);
                listDS.Items.Clear();
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    listDS.Items.Add(dt.Rows[i][0].ToString());
                    listDS.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                    listDS.Items[i].SubItems.Add(dt.Rows[i][4].ToString());
                    listDS.Items[i].SubItems.Add(string.Format("{0:#,##0}", dt.Rows[i][5]));
                    try
                    {
                        if (dt.Rows[i]["HinhAnh"] != DBNull.Value)
                        {
                            byte[] data = (byte[])dt.Rows[i]["HinhAnh"];
                            using (MemoryStream mem = new MemoryStream(data))
                            {
                                listDS.Items[i].Tag = Image.FromStream(mem); // Lưu hình ảnh vào Tag để sử dụng sau này nếu cần thiết
                            }
                        }
                    }
                    catch
                    {

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
                string sql = "select * from MATHANG where ThuongHieu = N'" + e.Node.Text + "' and PhanLoai = N'"+e.Node.Parent.Text+ "' order by MaMH asc";
                strSQL = sql;
                DataTable dt = CSDL.CSDL.LayDuLieu(sql);
                //data = Database.LayDuLieu(sql);
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
            ThayDoiHinhAnh = false;
        }

        private void listDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listDS.SelectedItems.Count > 0)
            {
                if (listDS.Items.Count > 0 && listDS.Items[0].Tag != null)
                {
                    pic.Image = (Image)listDS.SelectedItems[0].Tag;
                }
                string sql = "select * from MATHANG where MaMH = '" + listDS.SelectedItems[0].SubItems[0].Text +"'";
                DataTable dt = CSDL.CSDL.LayDuLieu(sql);
                if(dt.Rows.Count > 0)
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

        private void listDS_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listDS.SelectedItems.Count > 0)
            {
                try
                {
                    if (listDS.Items.Count > 0 && listDS.Items[0].Tag == null)
                    {
                        pic.Load(Url);
                    }
                    else if (listDS.Items.Count > 0 && listDS.Items[0].Tag != null)
                    {
                        pic.Image = (Image)listDS.SelectedItems[0].Tag;
                    }
                }
                catch
                {
                    pic.Load(Url);
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
            ThayDoiHinhAnh = false;
        }

        private void cbPhanLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbThuongHieu.Text = "";
            cbXuatXu.Text = "";
            LayDSThuongHieu();
            LayDSXuatXu();
        }

        private void cbMucGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = CSDL.CSDL.LayDuLieu(strSQL);
            //Tất cả
            //Dưới 5 triệu
            //Từ 5 - 10 triệu
            //Từ 10 - 20 triệu
            // Trên 20 triệu
            int Muc1 = 0;
            int Muc2 = 0;
            if (listDS.Items.Count == 0 && cbMucGia.Text =="")
            {
                MessageBox.Show("Không tìm thấy mặt hàng phù hợp. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch(cbMucGia.Text)
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
            }
            else if (Muc2 == -1)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
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
                for (int i = 0; i < dt.Rows.Count; i++)
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

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = CSDL.CSDL.LayDuLieu(strSQL);

            if (listDS.Items.Count == 0 )
            {
                MessageBox.Show("Không tìm thấy mặt hàng phù hợp. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            listDS.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
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
            if(listDS.Items.Count == 0)
                MessageBox.Show("Không tìm thấy mặt hàng phù hợp. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbTuKhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pic_Click(object sender, EventArgs e)
        {
            
        }

        private void btThayDoiHinhAnh_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Title = "Chọn ảnh đại diện";
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|All Files (*.*)|*.*";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn tệp hình ảnh
                    string imgLoc = dlg.FileName;

                    // Lưu đường dẫn hình ảnh vào biến NamePic (hoặc biến khác tùy ý)
                    NamePic = imgLoc;

                    // Đọc hình ảnh từ tệp và thêm vào Resources
                    Image img = Image.FromFile(imgLoc);
                    Properties.Resources.MyImage = new Bitmap(img);

                    // Hiển thị hình ảnh
                    pic.Image = img;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ThayDoiHinhAnh = true;
        }

        private bool IsInt(string input)
        {
            // Sử dụng int.TryParse để kiểm tra xem chuỗi có thể chuyển đổi thành kiểu int không
            return int.TryParse(input, out _);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(NamePic);
            
            string input = tbGiaBan.Text;
            string Gia = input.Replace(",", "");
            if (tbGiaBan.Text != "")
            {
                if (IsInt(Gia))
                {
                   
                }
                else
                {
                    MessageBox.Show("Giá bán không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            string insert = "";
            string values = @"";
            string select = @"";
            //MessageBox.Show(Gia);
            if(tbMaMH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin mặt hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (ThayDoiHinhAnh)
            {
                insert = @"INSERT INTO MATHANG(MaMH, TenMH, PhanLoai, XuatXu, ThuongHieu, GiaBan, SL, HinhAnh) ";
                values = @"VALUES ('" + tbMaMH.Text + "', N'" + tbTenMH.Text + "', N'" + cbPhanLoai.Text + "', N'" + cbXuatXu.Text + "', N'" + cbThuongHieu.Text + "', " + Gia + ", 0, ";
                select = @"(SELECT BulkColumn FROM OPENROWSET(Bulk '" + @NamePic + "', Single_Blob) as imgHV))";
            }
            else
            {
                insert = @"INSERT INTO MATHANG(MaMH, TenMH, PhanLoai, XuatXu, ThuongHieu, GiaBan, SL) ";
                values = @"VALUES ('" + tbMaMH.Text + "', N'" + tbTenMH.Text + "', N'" + cbPhanLoai.Text + "', N'" + cbXuatXu.Text + "', N'" + cbThuongHieu.Text + "', " + Gia + ", 0)";
                select = @"";
            }
            
            string sql = insert + values + select;
            try
            {
                CSDL.CSDL.XuLy(sql);
                
                MessageBox.Show("Đã thêm mặt hàng mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            listDS.Items.Clear();
            DataTable dt = CSDL.CSDL.LayDuLieu(strSQL);
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
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            string input = tbGiaBan.Text;
            string Gia = input.Replace(",", "");
            string sql = "";
            if (!ThayDoiHinhAnh)
            {
                sql = @"UPDATE MATHANG SET TenMH = N'" + tbTenMH.Text + "', PhanLoai = N'" + cbPhanLoai.Text + "', XuatXu = N'" + cbXuatXu.Text + "', ThuongHieu = N'" + cbThuongHieu.Text + "', GiaBan = " + Gia + " WHERE MaMH = '" + tbMaMH.Text + "'";
            }
            else
            {
                sql = @"UPDATE MATHANG SET TenMH = N'" + tbTenMH.Text + "', PhanLoai = N'" + cbPhanLoai.Text + "', XuatXu = N'" + cbXuatXu.Text + "', ThuongHieu = N'" + cbThuongHieu.Text + "', GiaBan = " + Gia + ", HinhAnh = (SELECT BulkColumn FROM OPENROWSET(Bulk '" + NamePic + "', Single_Blob) as imgHV) WHERE MaMH = '" + tbMaMH.Text + "'";
            }
            listDS.Items.Clear();
            CSDL.CSDL.XuLy(sql);
            DataTable dt = CSDL.CSDL.LayDuLieu(strSQL);
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
            MessageBox.Show("Đã cập nhật thông tin mặt hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Bạn thật sự muốn xóa thông tin mặt hàng " + tbTenMH.Text + "?", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        string sql = "Delete MATHANG where MaMH = '" + tbMaMH.Text + "'";
                        try
                        {
                            CSDL.CSDL.XuLy(sql);
                            listDS.Items.Clear();
                            DataTable dt = CSDL.CSDL.LayDuLieu(strSQL);
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
                            MessageBox.Show("Đã xóa thông tin mặt hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        catch
                        {
                            MessageBox.Show("Xóa thông tin mặt hàng không thành công. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
            }
        }
    }
}
