using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quan_ly_cua_hang_FPT_Shop.CSDL;

namespace Quan_ly_cua_hang_FPT_Shop.HoaDon
{
    public partial class Report : Form
    {
        string MaDH = "";
        public Report(string MaHD)
        {
            InitializeComponent();
            this.MaDH = MaHD;
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            string select = "select DONHANG.MaDH, convert(varchar(10), NgayMuaHang, 103) as NgayMuaHang, SoDT, KHACHHANG.HoTen, DANHSACHMATHANGBAN.MaMH, MATHANG.TenMH, GiaBan, DANHSACHMATHANGBAN.SL, (GiaBan * DANHSACHMATHANGBAN.SL) as ThanhTien, TongTien, GiamGia, TongCong";
            string from = " from DONHANG, DANHSACHMATHANGBAN, MATHANG, KHACHHANG ";
            string where = " where KHACHHANG.SoDT = DONHANG.SoDTKhachHang and MATHANG.MaMH = DANHSACHMATHANGBAN.MaMH and DONHANG.MaDH = DANHSACHMATHANGBAN.MaDH and DONHANG.MaDH = '"+MaDH+"'";

            string sql = select + from + where;
            DataTable dt = Quan_ly_cua_hang_FPT_Shop.CSDL.CSDL.LayDuLieu(sql);
            HoaDonThanhToan cry = new HoaDonThanhToan();
            cry.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cry;

        }
    }
}
