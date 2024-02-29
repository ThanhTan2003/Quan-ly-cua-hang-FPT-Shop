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
    public partial class UserControl_KhuyenMaiQuaTang : UserControl
    {
        public UserControl_KhuyenMaiQuaTang()
        {
            InitializeComponent();
        }

        void Add_UserControl(UserControl user)
        {
            user.Dock = DockStyle.Fill;
            panelChinh.Controls.Clear();
            panelChinh.Controls.Add(user);
            user.BringToFront();
        }

        void RestPanel()
        {
            foreach (Control cn in panel1.Controls)
            {
                if (cn is Panel)
                {
                    Panel bt = cn as Panel;
                    bt.BackColor = Color.Transparent;
                    bt.ForeColor = Color.White;
                }
            }

        }

        void RestButton()
        {
            foreach (Control cn in panel1.Controls)
            {
                if (cn is Button)
                {
                    Button bt = cn as Button;
                    bt.BackColor = Color.White;
                    bt.ForeColor = Color.DimGray;
                }
            }

        }

        private void btKhuyenMai_Click(object sender, EventArgs e)
        {
            
        }

        private void btUuDai_Click(object sender, EventArgs e)
        {
            
        }

        private void btMaGiamGia_Click(object sender, EventArgs e)
        {
            RestButton();
            RestPanel();

            btMaGiamGia.BackColor = Color.White;
            btMaGiamGia.ForeColor = Color.MidnightBlue;

            pMaGiamGia.BackColor = Color.MidnightBlue;

            UserControl_KhuyenMaiQuaTang_MaGiamGia user = new UserControl_KhuyenMaiQuaTang_MaGiamGia();
            Add_UserControl(user);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RestButton();
            RestPanel();

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControl_KhuyenMaiQuaTang_Load(object sender, EventArgs e)
        {
            UserControl_KhuyenMaiQuaTang_ThongTinKhuyenMai user = new UserControl_KhuyenMaiQuaTang_ThongTinKhuyenMai();
            Add_UserControl(user);
        }

        private void UserControl_KhuyenMaiQuaTang_Load_1(object sender, EventArgs e)
        {
            UserControl_KhuyenMaiQuaTang_MaGiamGia user = new UserControl_KhuyenMaiQuaTang_MaGiamGia();
            Add_UserControl(user);
        }

        private void panelChinh_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
