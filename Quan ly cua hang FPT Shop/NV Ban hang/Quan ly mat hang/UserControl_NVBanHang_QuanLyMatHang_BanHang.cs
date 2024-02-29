using Quan_ly_cua_hang_FPT_Shop.CSDL;
using Quan_ly_cua_hang_FPT_Shop.HoaDon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_cua_hang_FPT_Shop.NV_Ban_hang.Quan_ly_mat_hang
{
    public partial class UserControl_NVBanHang_QuanLyMatHang_BanHang : UserControl
    {
        public UserControl_NVBanHang_QuanLyMatHang_BanHang()
        {
            InitializeComponent();
        }

        void LayDSPhanLoai()
        {
            string sql = "select distinct PhanLoai from MATHANG";
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            cbPhanLoai.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
                cbPhanLoai.Items.Add(dt.Rows[i][0].ToString());
        }

        private void listQuaTang_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            // Tô màu nền
            e.Graphics.FillRectangle(Brushes.RoyalBlue, e.Bounds);
            // vẽ lại dòng tiêu đề với font in đậm và màu trắng
            e.Graphics.DrawString(e.Header.Text, new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold), Brushes.White, e.Bounds);

        }

        private void listDS_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            // Tô màu nền
            e.Graphics.FillRectangle(Brushes.RoyalBlue, e.Bounds);
            // vẽ lại dòng tiêu đề với font in đậm và màu trắng
            e.Graphics.DrawString(e.Header.Text, new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold), Brushes.White, e.Bounds);
        }

        private void listHoaDon_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
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
                    //e.Graphics.DrawString(listQuaTang.Name, new Font(FontFamily.GenericSansSerif, 12), Brushes.Black, e.Bounds.Left, e.Bounds.Top);
                }
            }

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

        private void listHoaDon_DrawItem(object sender, DrawListViewItemEventArgs e)
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
                    e.Graphics.DrawString(listHoaDon.Name, new Font(FontFamily.GenericSansSerif, 12), Brushes.Black, e.Bounds.Left, e.Bounds.Top);
                }
            }

        }

        private void UserControl_NVBanHang_QuanLyMatHang_BanHang_Load(object sender, EventArgs e)
        {
            LayDSPhanLoai();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThemKhachHangMoi trangChu = new ThemKhachHangMoi();
            trangChu.ShowDialog();
            //this.Hide();
            //return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from KHACHHANG where SoDT = '"+tbTK.Text+"'";
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            if(dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbTenKH.Text = "";
            }
            else
            {
                tbTenKH.Text = dt.Rows[0][1].ToString();
            }
        }

        private void cbPhanLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select MaMH, TenMH from MATHANG where PhanLoai = N'"+cbPhanLoai.Text+"'";
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            listDS.Items.Clear();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                listDS.Items.Add(dt.Rows[i][0].ToString());
                listDS.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
            }
        }

        private void listDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listDS.SelectedItems.Count > 0)
            {
                tbTenMH.Text = listDS.SelectedItems[0].SubItems[1].Text;
                numSL.Value = 1;
                 
                string sql = "select TenMH, GiaBan, SL from MATHANG where MaMH = '"+ listDS.SelectedItems[0].SubItems[0].Text + "'";
                DataTable dt = CSDL.CSDL.LayDuLieu(sql);
                if(dt.Rows.Count > 0)
                {
                    tbDonGia.Text = string.Format("{0:#,##0}", dt.Rows[0][1]);
                    tbThanhTien.Text = string.Format("{0:#,##0}", dt.Rows[0][1]);
                    //tbSL.Text  = dt.Rows[0][2].ToString();
                    int SL = Convert.ToInt32(dt.Rows[0][2].ToString());
                    for(int i  = 0; i < listHoaDon.Items.Count; i++)
                    {
                        if (listHoaDon.Items[i].SubItems[0].Text == tbTenMH.Text)
                        {
                            SL -= Convert.ToInt32((listHoaDon.Items[i].SubItems[2].Text));
                        }
                    }
                    tbSL.Text = SL.ToString();
                }
            }
        }

        private void numSL_ValueChanged(object sender, EventArgs e)
        {
            if(tbDonGia.Text.Length > 0)
            {
                string input = tbDonGia.Text;
                string Gia = input.Replace(",", "");
                int DonGia = int.Parse(Gia);
                int GiaBan = DonGia * Convert.ToInt32(numSL.Value);
                tbThanhTien.Text = string.Format("{0:#,##0}", GiaBan);
            }
        }

        int KiemTraTrungLap(string Ten)
        {
            for(int i = 0; i < listHoaDon.Items.Count; i++)
            {
                if (listHoaDon.Items[i].SubItems[0].Text == Ten)
                    return i;
            }
            return -1;
        }

        void TinhTien()
        {
            int Tong = 0;
            for(int i = 0; i < listHoaDon.Items.Count;i++)
            {
                string input = listHoaDon.Items[i].SubItems[3].Text;
                string ThanhTien = input.Replace(",", "");
                Tong += Convert.ToInt32(ThanhTien);
            }
            tbTongTien.Text = string.Format("{0:#,##0}", Tong);
            tbTongThanhToan.Text = string.Format("{0:#,##0}", Tong);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if(tbTenMH.Text.Length > 0)
            {
                int SLTonKho = Convert.ToInt32(tbSL.Text);
                int SLNhap = Convert.ToInt32(numSL.Value);
                if(SLTonKho == 0 || SLNhap > SLTonKho)
                {
                    MessageBox.Show("Không đủ số lượng tồn kho. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int index = KiemTraTrungLap(tbTenMH.Text);
                if (index != -1)
                {
                    int SL = Convert.ToInt32(numSL.Value) + Convert.ToInt32(listHoaDon.Items[index].SubItems[2].Text);
                    string input = listHoaDon.Items[index].SubItems[1].Text;
                    string DonGia = input.Replace(",", "");
                    int ThanhTien = Convert.ToInt32(DonGia.ToString()) * SL;
                    listHoaDon.Items[index].SubItems[2].Text = SL.ToString();
                    listHoaDon.Items[index].SubItems[3].Text = string.Format("{0:#,##0}", ThanhTien);
                    tbSL.Text = (Convert.ToInt32(tbSL.Text) - Convert.ToInt32(numSL.Value)).ToString();
                }
                else
                {
                    int n = listHoaDon.Items.Count;
                    listHoaDon.Items.Add(tbTenMH.Text);
                    listHoaDon.Items[n].SubItems.Add(tbDonGia.Text);
                    listHoaDon.Items[n].SubItems.Add(numSL.Value.ToString());
                    listHoaDon.Items[n].SubItems.Add(tbThanhTien.Text);
                    tbSL.Text = (Convert.ToInt32(tbSL.Text) - Convert.ToInt32(numSL.Value)).ToString();
                }
            }
            TinhTien();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(listHoaDon.SelectedItems.Count > 0)
            {
                listHoaDon.Items.RemoveAt(listHoaDon.SelectedIndices[0]);
            }
            TinhTien();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HoaDon1 trangChu = new HoaDon1(tbMaDH.Text);
            trangChu.ShowDialog();
        }
        bool KiemTra()
        {
            if (tbTenKH.Text == "")
                return true;
            if(tbTongTien.Text =="")
                return true;
            return false;
        }
        string GenerateRandomNumbers(int length)
        {
            Random random = new Random();
            string randomNumbers = "";

            for (int i = 0; i < length; i++)
            {
                randomNumbers += random.Next(0, 10).ToString();
            }

            return randomNumbers;
        }
        void DungMaGG(string MaGG)
        {
            string sql = $"update MAGIAMGIA set SL = SL -1 where Ma = '{MaGG}'";
            try
            {
                CSDL.CSDL.XuLy(sql);
            }
            catch { }
        }
        string LayMaDonHang(string Ten)
        {
            string result = "";
            string sql = "select MaMH from MATHANG where TenMH = N'"+Ten+"'";
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            if (dt.Rows.Count > 0)
                result = dt.Rows[0][0].ToString();
            return result;
        }
        void Insert_HoaDon()
        {
            string insert = "insert into DONHANG(MaDH, SoDTKhachHang, NgayMuaHang, TongTien, GiamGia, TongCong,  SoDTNguoiNhan, TrangThaiDonHang, NguoiGiaoHang, DiaChiGiaoHang, GhiChu, MaGiamGia) ";
            string values;
            if(tbSoTienGiam.Text == "")
            {
                values = "values('"+tbMaDH.Text+"', '"+tbTK.Text+"', '"+DateTime.Now.ToString("yyyy/MM/dd")+"', "+tbTongTien.Text.Replace(",", "") + ",0,"+ tbTongTien.Text.Replace(",", "") + ", '"+tbSDTNguoiNhan.Text+"', N'"+cbGiaoHang.Text+"', N'', N'"+tbDiaChi.Text+"', N'"+tbGhiChu.Text+"', null)";
            }
            else
            {
                values = "values('" + tbMaDH.Text + "', '" + tbTK.Text + "', '" + DateTime.Now.ToString("yyyy/MM/dd") + "', " + tbTongTien.Text.Replace(",", "") + ","+tbSoTienGiam.Text.Replace(",", "") + "," + tbTongThanhToan.Text.Replace(",", "") + ", '" + tbSDTNguoiNhan.Text + "', N'" + cbGiaoHang.Text + "', N'', N'" + tbDiaChi.Text + "', N'" + tbGhiChu.Text + "', '"+tbMaGiamGia.Text+"')";
                DungMaGG(tbMaGiamGia.Text);
            }
            string sql = insert + values;
            CSDL.CSDL.XuLy(sql);
        }
        void Insert_ChiTietHoaDon()
        {
            for(int i = 0; i < listHoaDon.Items.Count; i++)
            {
                string sql = "insert into DANHSACHMATHANGBAN(MaDH, MaMH, SL) values ('"+tbMaDH.Text+"', '" + LayMaDonHang(listHoaDon.Items[i].SubItems[0].Text)+"', "+ listHoaDon.Items[i].SubItems[2].Text + ")";
                CSDL.CSDL.XuLy(sql);
            }
        }
        private bool IsPhoneNumberValid(string input)
        {
            // Sử dụng regular expression để kiểm tra định dạng chuỗi
            string pattern = @"^\d{10}$"; // ^\d{10}$ có nghĩa là chuỗi phải bắt đầu và kết thúc bằng số (\d), và có độ dài chính xác là 10.
            Regex regex = new Regex(pattern);

            return regex.IsMatch(input);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(tbSDTNguoiNhan.Text != "")
            {
                if (IsPhoneNumberValid((tbSDTNguoiNhan.Text)))
                {
                    //Console.WriteLine("Chuỗi hợp lệ");
                }
                else
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (cbGiaoHang.Text == "")
            {
                MessageBox.Show("Vui lòng chọn trạng thái đơn hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (KiemTra())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                DateTime now = DateTime.Now;

                // Tạo chuỗi theo định dạng "DH + giờ + phút + ngày + tháng + năm + 3 số ngẫu nhiên"
                string MaHD = $"HD{now.Hour:D2}{now.Minute:D2}{now.Day:D2}{now.Month:D2}{now.Year}{GenerateRandomNumbers(3)}";

                tbMaDH.Text = MaHD;
                Insert_HoaDon();
                Insert_ChiTietHoaDon();
                for(int i = 0; i < listHoaDon.Items.Count; i++)
                {
                    string sql = $"UPDATE MATHANG SET SL = SL - {listHoaDon.Items[i].SubItems[2].Text} where TenMH = N'{listHoaDon.Items[i].SubItems[0].Text}'";
                    CSDL.CSDL.XuLy(sql);
                }
                MessageBox.Show("Đã nhập đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        bool KiemTraMaGG(string MaGG)
        {
            string sql = "select Ma from MAGIAMGIA";
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            for(int i = 0; i <dt.Rows.Count; i++)
            {
                if(MaGG == dt.Rows[i][0].ToString())
                    return true;
            }
            return false;
        }
        bool KiemTraQuaHan(DateTime d1)
        {
            int result = DateTime.Compare(DateTime.Now, d1);
            if (result > 0)
                return true;
            return false;
        }
        
        bool KiemTraGiaTriDonHang(int MucGiam, int SoTien)
        {
            if(MucGiam > SoTien)
                return true;
            return false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tbMaGiamGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (!KiemTraMaGG(tbMaGiamGia.Text))
            {
                MessageBox.Show("Mã giảm giá không phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sql = $"select HanSuDung, SL, PhanLoai, GiaTriDonHang, MucGiamGia, SoTienGiam from MAGIAMGIA where Ma = '{tbMaGiamGia.Text}'";
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            if (dt.Rows[0][0].ToString() != "")
            {
                DateTime d1 = Convert.ToDateTime(dt.Rows[0][0]);
                if (KiemTraQuaHan(d1))
                {
                    MessageBox.Show("Mã giảm giá đã quá hạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (dt.Rows[0][1].ToString() != "")
            {
                int SL = Convert.ToInt32(dt.Rows[0][1]);
                if (SL <= 0)
                {
                    MessageBox.Show("Mã giảm giá đã được sử dụng hết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            int PhanLoai = Convert.ToInt32(dt.Rows[0][2]);
            string numberString = tbTongTien.Text;
            numberString = numberString.Replace(",", ""); // Loại bỏ ký tự ","
            int TongTien = int.Parse(numberString);

            int MucGia = Convert.ToInt32(dt.Rows[0][3]);
            int Tong = Convert.ToInt32(tbTongTien.Text.Replace(",", ""));
            if (KiemTraGiaTriDonHang(MucGia, Tong))
            {
                MessageBox.Show($"Tổng tiền tối thiểu phải từ {String.Format("{0:#,##0}",MucGia)}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(PhanLoai == 0)
            {
                double TyLe = Convert.ToDouble(dt.Rows[0][4]);
                //MessageBox.Show(TyLe.ToString()+" , " +Tong.ToString());
                int GiamGia = (Tong * (int)TyLe) / 100;
                tbSoTienGiam.Text = String.Format("{0:#,##0}", GiamGia);
               // MessageBox.Show(TyLe.ToString() + " , " + Tong.ToString() +" , " + GiamGia.ToString());
                int ThanhToan = Tong - GiamGia;
                tbTongThanhToan.Text = String.Format("{0:#,##0}", ThanhToan);
            }
            else
            {
                int SoTienGiam = Convert.ToInt32(dt.Rows[0][5]);
                //MessageBox.Show(SoTienGiam.ToString());
                int ThanhToan = Tong - SoTienGiam;
                tbSoTienGiam.Text = String.Format("{0:#,##0}", SoTienGiam);
                tbTongThanhToan.Text = String.Format("{0:#,##0}", ThanhToan);
            }
            MessageBox.Show("Đã áp dụng mã giảm giá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
