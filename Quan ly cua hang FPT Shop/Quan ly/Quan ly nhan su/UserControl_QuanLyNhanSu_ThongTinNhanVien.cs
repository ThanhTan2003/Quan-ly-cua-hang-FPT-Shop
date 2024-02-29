using Quan_ly_cua_hang_FPT_Shop.CSDL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Quan_ly_cua_hang_FPT_Shop
{
    public partial class UserControl_QuanLyNhanSu_ThongTinNhanVien : UserControl
    {
        private const string Url = "anhdaidien.jpg";
        string NamePic = "";
        //string //strSQL = "";

        bool ThayDoiHinhAnh = false;

        public UserControl_QuanLyNhanSu_ThongTinNhanVien()
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

        void LayDanhSachViTri()
        {
            string sql = "select distinct ViTri from NHANVIEN";
            comboViTri.Items.Clear();
            cbPhanLoai.Items.Clear();
            cbPhanLoai.Items.Add("Tất cả");
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboViTri.Items.Add(dt.Rows[i][0].ToString());
                cbPhanLoai.Items.Add(dt.Rows[i][0].ToString());
            }
                
        }
        void LayDanhSachNhanVien()
        {
            string sql = "select * from NHANVIEN";
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            listDS.Items.Clear();
            for(int i = 0; i < dt.Rows.Count;i++)
            {
                listDS.Items.Add(dt.Rows[i][0].ToString());
                listDS.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                listDS.Items[i].SubItems.Add(Convert.ToDateTime(dt.Rows[i][3].ToString()).ToString("dd/MM/yyyy"));
                listDS.Items[i].SubItems.Add(dt.Rows[i][6].ToString());
                listDS.Items[i].SubItems.Add(dt.Rows[i][9].ToString());
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
            lbTong.Text = listDS.Items.Count.ToString();
        }
        void LayThongTinNhanVien(string MaNV)
        {
            string sql = $"select * from NHANVIEN where MaNV = '{MaNV}'";
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            if(dt.Rows.Count > 0)
            {
                tbMaNV.Text = dt.Rows[0][0].ToString();
                tbHoTen.Text = dt.Rows[0][1].ToString();
                tbSoCCCD.Text = dt.Rows[0][2].ToString();
                dateNgaySinh.Value = Convert.ToDateTime(dt.Rows[0][3].ToString());
                tbDiaChi.Text = dt.Rows[0][4].ToString();
                cbGioiTinh.Text = dt.Rows[0][5].ToString();
                tbSDT.Text = dt.Rows[0][6].ToString();
                tbEmail.Text = dt.Rows[0][7].ToString();
                dateNLV.Value = Convert.ToDateTime(dt.Rows[0][8].ToString());
                comboViTri.Text = dt.Rows[0][9].ToString();
                tbLuongCB.Text = String.Format("{0:#,##0}", dt.Rows[0][10]);
                tbTinhTrang.Text = dt.Rows[0][11].ToString();
            }
        }

        private void UserControl_QuanLyNhanSu_ThongTinNhanVien_Load(object sender, EventArgs e)
        {
            LayDanhSachViTri();
            LayDanhSachNhanVien();
        }

        private void listDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbMaNV.Enabled = false;
            if (listDS.SelectedItems.Count > 0)
            {
                LayThongTinNhanVien(listDS.SelectedItems[0].SubItems[0].Text);
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
            }
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            tbMaNV.Enabled = true;
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

        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void cbPhanLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPhanLoai.Text == "Tất cả")
                LayDanhSachNhanVien();
            else
            {
                string sql = $"select * from NHANVIEN where ViTri = N'{cbPhanLoai.Text}'";
                DataTable dt = CSDL.CSDL.LayDuLieu(sql);
                listDS.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    listDS.Items.Add(dt.Rows[i][0].ToString());
                    listDS.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                    listDS.Items[i].SubItems.Add(Convert.ToDateTime(dt.Rows[i][3].ToString()).ToString("dd/MM/yyyy"));
                    listDS.Items[i].SubItems.Add(dt.Rows[i][6].ToString());
                    listDS.Items[i].SubItems.Add(dt.Rows[i][9].ToString());
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
            }
            lbTong.Text = listDS.Items.Count.ToString();
        }

        private void listDS_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            tbMaNV.Enabled = false;
            if (listDS.SelectedItems.Count > 0)
            {
                LayThongTinNhanVien(listDS.SelectedItems[0].SubItems[0].Text);
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
        bool KiemTraDuLieuTrong()
        {
            if (tbHoTen.Text == "" || tbMaNV.Text == "" || tbSDT.Text == "" || cbPhanLoai.Text == "" || comboViTri.Text == "")
                return true;
            return false;
        }

        private bool IsNumericLengthValid(string input, int expectedLength)
        {
            // Kiểm tra xem chuỗi có phải là số không
            if (!long.TryParse(input, out _))
            {
                return false;
            }

            // Kiểm tra chiều dài của chuỗi
            return input.Length == expectedLength;
        }

        bool KiemTraSDT(string SoDT)
        {
            if (!IsNumericLengthValid(SoDT, 10))
            {
                return true;

            }
            return false;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if(KiemTraDuLieuTrong())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắc buộc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if(KiemTraSDT(tbSDT.Text))
            {
                MessageBox.Show("Số điện thoại phải đúng 10 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(tbLuongCB.Text != "")
            {
                try
                {
                    int.Parse(tbLuongCB.Text);
                }
                catch
                {
                    MessageBox.Show("Lương co8 bản không đúng định dạng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if(tbSoCCCD.Text !="")
            {
                if (!IsNumericLengthValid(tbSoCCCD.Text, 12))
                {
                    MessageBox.Show("Số CCCD phải đúng 12 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            string input = tbLuongCB.Text;
            string Luong = input.Replace(",", "");
            if (tbLuongCB.Text == "")
                Luong = "0";
            string insert = "";
            string values = @"";
            string select = @"";
            if (ThayDoiHinhAnh)
            {
                insert = "INSERT INTO NHANVIEN (MaNV, HoTen, CCCD, NgaySinh, DiaChi, GioiTinh, SoDT, Email, NgayLV, ViTri, LuongCB, TinhTrang, HinhAnh)";
                values = $" VALUES ('{tbMaNV.Text}', N'{tbHoTen.Text}', '{tbSoCCCD.Text}', '{Convert.ToDateTime(dateNgaySinh.Value).ToString("yyyy/MM/dd")}', N'{tbDiaChi.Text}', N'{cbGioiTinh.Text}', '{tbSDT.Text}', '{tbEmail.Text}', '{Convert.ToDateTime(dateNLV.Value).ToString("yyyy/MM/dd")}', N'{cbPhanLoai.Text}', {Luong}, N'{tbTinhTrang.Text}',";
                select = $" (SELECT BulkColumn FROM OPENROWSET(Bulk '{NamePic}', Single_Blob) as imgHV))";
            }
            else
            {
                insert = "INSERT INTO NHANVIEN (MaNV, HoTen, CCCD, NgaySinh, DiaChi, GioiTinh, SoDT, Email, NgayLV, ViTri, LuongCB, TinhTrang)";
                values = $" VALUES ('{tbMaNV.Text}', N'{tbHoTen.Text}', '{tbSoCCCD.Text}', '{Convert.ToDateTime(dateNgaySinh.Value).ToString("yyyy/MM/dd")}', N'{tbDiaChi.Text}', N'{cbGioiTinh.Text}', '{tbSDT.Text}', '{tbEmail.Text}', '{Convert.ToDateTime(dateNLV.Value).ToString("yyyy/MM/dd")}', N'{cbPhanLoai.Text}', {Luong}, N'{tbTinhTrang.Text}')";
                select = $"";
            }
            try
            {
                string sql = insert + values + select;
                CSDL.CSDL.XuLy(sql);
                LayDanhSachNhanVien();
                MessageBox.Show("Đã thêm nhân viên mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Không thể thêm nhân viên mới. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieuTrong())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắc buộc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (KiemTraSDT(tbSDT.Text))
            {
                MessageBox.Show("Số điện thoại phải đúng 10 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbLuongCB.Text != "")
            {
                try
                {
                    int.Parse(tbLuongCB.Text);
                }
                catch
                {
                    MessageBox.Show("Lương cơ bản không đúng định dạng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (tbSoCCCD.Text != "")
            {
                if (!IsNumericLengthValid(tbSoCCCD.Text, 12))
                {
                    MessageBox.Show("Số CCCD phải đúng 12 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string input = tbLuongCB.Text;
            string Luong = input.Replace(",", "");
            if (tbLuongCB.Text == "")
                Luong = "0";
            string update = "UPDATE NHANVIEN SET ";
            string setValues = $"HoTen = N'{tbHoTen.Text}', CCCD = '{tbSoCCCD.Text}', NgaySinh = '{Convert.ToDateTime(dateNgaySinh.Value).ToString("yyyy/MM/dd")}', DiaChi = N'{tbDiaChi.Text}', GioiTinh = N'{cbGioiTinh.Text}', SoDT = '{tbSDT.Text}', Email = '{tbEmail.Text}', NgayLV = '{Convert.ToDateTime(dateNLV.Value).ToString("yyyy/MM/dd")}', ViTri = N'{cbPhanLoai.Text}', LuongCB = {Luong}, TinhTrang = N'{tbTinhTrang.Text}'";
            string whereClause = $" WHERE MaNV = '{tbMaNV.Text}'";

            try
            {
                string sql = update + setValues + whereClause;
                CSDL.CSDL.XuLy(sql);
                if(ThayDoiHinhAnh)
                {
                    sql = update + $"HinhAnh = (SELECT BulkColumn FROM OPENROWSET(Bulk '{NamePic}', Single_Blob) as imgHV)" + whereClause;
                    CSDL.CSDL.XuLy(sql);
                }
                LayDanhSachNhanVien();
                MessageBox.Show("Đã cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Không thể cập nhật thông tin nhân viên. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string delete = "DELETE FROM NHANVIEN";
            string whereClause = $" WHERE MaNV = '{tbMaNV.Text}'";

            DialogResult result = MessageBox.Show($"Bạn thật sự muốn xóa nhân viên {tbHoTen.Text}?", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string sql = delete + whereClause;
                    CSDL.CSDL.XuLy(sql);
                    MessageBox.Show("Đã xóa thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LayDanhSachNhanVien();
                }
                catch
                {
                    MessageBox.Show("Không thể xóa thông tin nhân viên. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if(rdMaNV.Checked == false && rdTen.Checked == false)
            {
                MessageBox.Show("Vui lòng nhập và chọn đầy đủ thông tin tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (rdMaNV.Checked)
            {
                string sql = $"select * from NHANVIEN where MaNV like '%{tbTK.Text}%'";
                DataTable dt = CSDL.CSDL.LayDuLieu(sql);
                listDS.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    listDS.Items.Add(dt.Rows[i][0].ToString());
                    listDS.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                    listDS.Items[i].SubItems.Add(Convert.ToDateTime(dt.Rows[i][3].ToString()).ToString("dd/MM/yyyy"));
                    listDS.Items[i].SubItems.Add(dt.Rows[i][6].ToString());
                    listDS.Items[i].SubItems.Add(dt.Rows[i][9].ToString());
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
            }
            else
            {
                string sql = $"select * from NHANVIEN where HoTen like '%{tbTK.Text}%'";
                DataTable dt = CSDL.CSDL.LayDuLieu(sql);
                listDS.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    listDS.Items.Add(dt.Rows[i][0].ToString());
                    listDS.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                    listDS.Items[i].SubItems.Add(Convert.ToDateTime(dt.Rows[i][3].ToString()).ToString("dd/MM/yyyy"));
                    listDS.Items[i].SubItems.Add(dt.Rows[i][6].ToString());
                    listDS.Items[i].SubItems.Add(dt.Rows[i][9].ToString());
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
            }
            if(listDS.Items.Count == 0 )
            {
                MessageBox.Show("Không tìm thấy nhân viên phù hợp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InDanhSachNhanVien f = new InDanhSachNhanVien();
            f.ShowDialog();
        }
    }
}
