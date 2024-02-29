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
    public partial class UserControl_KhuyenMaiQuaTang_MaGiamGia : UserControl
    {
        public UserControl_KhuyenMaiQuaTang_MaGiamGia()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void listDS_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            // Tô màu nền
            e.Graphics.FillRectangle(Brushes.RoyalBlue, e.Bounds);
            // vẽ lại dòng tiêu đề với font in đậm và màu trắng
            e.Graphics.DrawString(e.Header.Text, new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold), Brushes.White, e.Bounds);

        }

        private void listLichSu_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
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

        private void listLichSu_DrawItem(object sender, DrawListViewItemEventArgs e)
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
                    e.Graphics.DrawString(listLichSu.Name, new Font(FontFamily.GenericSansSerif, 12), Brushes.Black, e.Bounds.Left, e.Bounds.Top);
                }
            }

        }

        void LayDSMaGG()
        {
            listDS.Items.Clear();
            string sql = "select Ma, SL from MAGIAMGIA";
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                listDS.Items.Add(dt.Rows[i][0].ToString());
                if (dt.Rows[i][1].ToString() == "")
                    listDS.Items[i].SubItems.Add("Không giới hạn");
                else
                    listDS.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
            }
        }

        private void UserControl_KhuyenMaiQuaTang_MaGiamGia_Load(object sender, EventArgs e)
        {
            tbPhanTran_GiaTri.Enabled = false;
            numPhanTram.Enabled = false;
            lbPhanTram_GiaTri.Enabled = false;
            lbPhanTram_MucGiam.Enabled = false;
            lb1.Enabled = false;
            

            tbCoDinh_GiaTri.Enabled = false;
            tbCoDinh_SoTien.Enabled = false;
            lbCoDinh_GiaTri.Enabled = false;
            lbCoDinh_SoTien.Enabled =false;
            lb21.Enabled = false;
            lb22.Enabled = false;
            

            dateThoiHan.Enabled = false;
            lbThoiHan.Enabled = false;

            LayDSMaGG();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tbPhanTran_GiaTri.Enabled = true;
            numPhanTram.Enabled = true;
            lbPhanTram_GiaTri.Enabled = true;
            lbPhanTram_MucGiam.Enabled = true;
            lb1.Enabled = true;

            tbCoDinh_GiaTri.Enabled = false;
            tbCoDinh_SoTien.Enabled = false;
            lbCoDinh_GiaTri.Enabled = false;
            lbCoDinh_SoTien.Enabled = false;
            lb21.Enabled = false;
            lb22.Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            tbPhanTran_GiaTri.Enabled = false;
            numPhanTram.Enabled = false;
            lbPhanTram_GiaTri.Enabled = false;
            lbPhanTram_MucGiam.Enabled = false;
            lb1.Enabled = false;

            tbCoDinh_GiaTri.Enabled = true;
            tbCoDinh_SoTien.Enabled = true;
            lbCoDinh_GiaTri.Enabled = true;
            lbCoDinh_SoTien.Enabled = true;
            lb21.Enabled = true;
            lb22.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dateThoiHan.Enabled = true;
            lbThoiHan.Enabled = true;
        }

        private void rdKhongThoiHan_CheckedChanged(object sender, EventArgs e)
        {
            dateThoiHan.Enabled = false;
            lbThoiHan.Enabled = false;
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            numSL.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            numSL.Enabled = false;
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
        void LayDSDonHang(string MaGG)
        {
            listLichSu.Items.Clear();
            string sql = $"select MaGiamGia, MaDH, convert(varchar(10), NgayMuaHang, 103) as NgayMuaHang, GiamGia from DONHANG where MaGiamGia = '{MaGG}'";
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                listLichSu.Items.Add(dt.Rows[i][0].ToString());
                listLichSu.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                listLichSu.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                listLichSu.Items[i].SubItems.Add("");
                listLichSu.Items[i].SubItems.Add(String.Format("{0:#,##0}", dt.Rows[i][3]));
            }
        }

        private void listDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listDS.SelectedItems.Count > 0)
            {
                tbMa.Text = listDS.SelectedItems[0].SubItems[0].Text;
                if (listDS.SelectedItems[0].SubItems[1].Text == "Không giới hạn")
                {
                    rdKhongGioiHan.Checked = true;
                    numSL.Value = 0;
                }

                else
                {
                    rdCoGioiHan.Checked = true;
                    numSL.Value = Convert.ToInt32(listDS.SelectedItems[0].SubItems[1].Text);
                }
                LayDSDonHang(listDS.SelectedItems[0].SubItems[0].Text);
                string sql = $"select Ma, HanSuDung, SL, PhanLoai, GiaTriDonHang, MucGiamGia, SoTienGiam from MAGIAMGIA where Ma = '{listDS.SelectedItems[0].SubItems[0].Text}'";
                DataTable dt = CSDL.CSDL.LayDuLieu(sql);
                if(dt.Rows.Count > 0 )
                {
                    if (dt.Rows[0][1].ToString() != "")
                    {
                        rdCoThoiHan.Checked = true;
                        dateThoiHan.Value = Convert.ToDateTime(dt.Rows[0][1]);
                    }
                    else
                    {
                        rdKhongThoiHan.Checked = true;
                        dateThoiHan.Value = DateTime.Now;
                    }
                    if (Convert.ToUInt32(dt.Rows[0][3]) == 0)
                    {
                        rdMuc.Checked = true;
                        tbPhanTran_GiaTri.Text = dt.Rows[0][4].ToString();
                        numPhanTram.Value = Convert.ToDecimal(dt.Rows[0][5].ToString());

                        tbCoDinh_GiaTri.Text = "";
                        tbCoDinh_SoTien.Text = "";
                    }
                    else
                    {
                        rdSoTien.Checked = true;

                        tbPhanTran_GiaTri.Text = "";
                        numPhanTram.Value = 0;

                        tbCoDinh_GiaTri.Text = dt.Rows[0][4].ToString();
                        tbCoDinh_SoTien.Text = dt.Rows[0][6].ToString();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbTK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            listDS.Items.Clear();
            string sql = $"select Ma, SL from MAGIAMGIA where Ma like '%{tbTK.Text}%'";
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listDS.Items.Add(dt.Rows[i][0].ToString());
                if (dt.Rows[i][1].ToString() == "")
                    listDS.Items[i].SubItems.Add("Không giới hạn");
                else
                    listDS.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
            }
            if(dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql = $"delete MAGIAMGIA where Ma = '{tbMa.Text}'";
            try
            {
                DialogResult result = MessageBox.Show("Bạn thật sự muốn xóa mã giảm giá " + tbMa.Text + "?", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    CSDL.CSDL.XuLy(sql);
                    LayDSMaGG();
                    MessageBox.Show("Đã xóa mã giảm giá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch
            {
                MessageBox.Show("Không thể xóa mã giảm giá này do đã được áp dụng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool KiemTraDuLieuTrong()
        {
            if (tbMa.Text == "")
                return true;
            if(rdKhongGioiHan.Checked == false && rdCoGioiHan.Checked == false)
                return true;
            if(rdKhongThoiHan.Checked == false && rdCoThoiHan.Checked == false)
                return true;
            if (rdMuc.Checked == false && rdSoTien.Checked == false)
                return true;

            if(rdMuc.Checked)
            {
                if (tbPhanTran_GiaTri.Text == "" || numPhanTram.Value == 0)
                    return true;
            }
            if (rdSoTien.Checked)
            {
                if (tbCoDinh_GiaTri.Text == "" || tbCoDinh_SoTien.Text == "")
                    return true;
            }
            return false;
        }
        
        bool KiemTraTrungLap()
        {
            string sql = "select Ma from MAGIAMGIA";
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString() == tbMa.Text)
                    return true;
            }
            return false;
        }
        bool KiemTraDuLieuNhap()
        {
            if(rdMuc.Checked)
            {
                if (!int.TryParse(tbPhanTran_GiaTri.Text, out int result))
                    return true;
            }
            if(rdSoTien.Checked)
            {
                if (!int.TryParse(tbCoDinh_GiaTri.Text, out int result1))
                    return true;
                if (!int.TryParse(tbCoDinh_SoTien.Text, out int result2))
                    return true;
            }
            return false;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if(KiemTraDuLieuTrong())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if(KiemTraTrungLap())
            {
                MessageBox.Show("Mã giảm giá đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(KiemTraDuLieuNhap())
            {
                MessageBox.Show("Giá trị nhập không hợp lệ. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string HanSuDung = "null";
            string SL = "null";
            string PhanLoai = "null";
            string GiaTriDonHang = "null";
            string MucGiamGia = "null";
            string SoTienGiam = "null";
            if(rdKhongThoiHan.Checked)
            {

            }
            else
            {
                HanSuDung = $"'{dateThoiHan.Value.ToString("yyyy/MM/dd")}'";
            }
            if(rdCoGioiHan.Checked)
            {
                SL = numSL.Value.ToString();
            }
            if(rdMuc.Checked)
            {
                GiaTriDonHang = tbPhanTran_GiaTri.Text;
                MucGiamGia = numPhanTram.Value.ToString();
                PhanLoai = "0";
            }
            else
            {
                GiaTriDonHang = tbCoDinh_GiaTri.Text;
                SoTienGiam = tbCoDinh_SoTien.Text;
                PhanLoai = "1";
            }
            string sql = $"insert MAGIAMGIA(Ma, HanSuDung, SL, PhanLoai, GiaTriDonHang, MucGiamGia, SoTienGiam) values('{tbMa.Text}', {HanSuDung}, {SL}, {PhanLoai}, {GiaTriDonHang}, {MucGiamGia}, {SoTienGiam})";
            //try
            //{
                CSDL.CSDL.XuLy(sql);
                LayDSMaGG();
                MessageBox.Show("Đã thêm Mã giảm giá mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
           // catch
           // {

           // }
        }
    }
}
