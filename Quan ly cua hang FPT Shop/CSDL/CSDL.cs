using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.IO;

namespace Quan_ly_cua_hang_FPT_Shop.CSDL
{
    public class CSDL
    {
        public static SqlConnection cn;
        // string strSQL = @"Data Source=THAVICO-0HN4EKU\SQLEXPRESS;Initial Catalog=QLCuaHangFPTShop;Integrated Security=True";
        public static string TenDN = "";
        public static string MK = "";
        public static string MaNV = "";
        public static string LoaiTK = "";
        public static string TenHienThi = "";

        public static string svName = @".\SQLEXPRESS";
        public static string dbName = "QLCuaHangFPTShop";

        public static void KetNoi()
        {
            string sql = @"Data Source=" + svName + ";Initial Catalog=" + dbName + ";Integrated Security=True";
            cn = new SqlConnection(sql);

        }
        public static DataTable LayDuLieu(string sql)
        {
            SqlDataAdapter data = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
        public static void XuLy(string sql)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
            GhiLenhXuLySQL(sql);
        }
        public static void GhiLenhXuLySQL(string sql)
        {
            File.AppendAllText(@"D:\XuLySQL1.txt", $"{sql}\ngo\n");
        }
    }
}
