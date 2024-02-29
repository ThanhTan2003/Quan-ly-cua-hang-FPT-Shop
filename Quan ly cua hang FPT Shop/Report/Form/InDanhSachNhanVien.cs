//using Quan_ly_cua_hang_FPT_Shop.Report.Crystal_Report;
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
    public partial class InDanhSachNhanVien : Form
    {
        public InDanhSachNhanVien()
        {
            InitializeComponent();
        }

        private void InDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            //CSDL.CSDL.KetNoi();
            string sql = "select MaNV, HoTen, convert(varchar(10), NHANVIEN.NgaySinh, 103) as NgaySinh, ViTri, LuongCB, (SELECT SUM(LuongCB) FROM NHANVIEN) as TongLuong from NHANVIEN order by ViTri desc";
            DataTable dt = CSDL.CSDL.LayDuLieu(sql);
            InDanhSachNhanVien_CrystalReport cry = new InDanhSachNhanVien_CrystalReport();
            cry.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cry;
        }
    }
}
