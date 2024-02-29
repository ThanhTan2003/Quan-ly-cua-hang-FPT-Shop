using Quan_ly_cua_hang_FPT_Shop.CSDL;
using Quan_ly_cua_hang_FPT_Shop.NV_QL_kho.Trang_chu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Quan_ly_cua_hang_FPT_Shop.CSDL

namespace Quan_ly_cua_hang_FPT_Shop
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btDN_Click(object sender, EventArgs e)
        {
            if (tk.Text == "" || mk.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }

            string sql = "select *from TAIKHOAN";
            CSDL.CSDL.KetNoi();
            try
            {
                DataTable dt = CSDL.CSDL.LayDuLieu(sql);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (tk.Text == dt.Rows[i][1].ToString() && mk.Text == dt.Rows[i][2].ToString())
                        {
                            if (dt.Rows[i][5].ToString() == "Đang sử dụng")
                            {
                                CSDL.CSDL.MaNV = dt.Rows[i][0].ToString();
                                CSDL.CSDL.LoaiTK = dt.Rows[i][3].ToString();
                                CSDL.CSDL.TenHienThi = dt.Rows[i][4].ToString();
                                CSDL.CSDL.TenDN = tk.Text;
                                CSDL.CSDL.MK = mk.Text;
                                switch (CSDL.CSDL.LoaiTK)
                                {
                                    case "Quản lý":
                                        TrangChu_QuanLy trangChu = new TrangChu_QuanLy();
                                        trangChu.Show();
                                        this.Hide();
                                        return;

                                    case "NV bán hàng":
                                        TrangChu_NVBanHang trangChu1 = new TrangChu_NVBanHang();
                                        trangChu1.Show();
                                        this.Hide();
                                        return;
                                    case "NV QL Kho":
                                        TrangChu_NVQLKho trangChu2 = new TrangChu_NVQLKho();
                                        trangChu2.Show();
                                        this.Hide();
                                        return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Tài khoản đã bị khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }
                    MessageBox.Show("Thông tin đăng nhập không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Không thể kết nối với cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Không thể kết nối với cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cbLuuMK_CheckedChanged(object sender, EventArgs e)
        {
            if(cbLuuMK.Checked == true)
                mk.UseSystemPasswordChar = false;
            else mk.UseSystemPasswordChar = true;
        }

        private void cbLuuMK_CheckStateChanged(object sender, EventArgs e)
        {
            //mk.UseSystemPasswordChar = true;
        }
    }
}
