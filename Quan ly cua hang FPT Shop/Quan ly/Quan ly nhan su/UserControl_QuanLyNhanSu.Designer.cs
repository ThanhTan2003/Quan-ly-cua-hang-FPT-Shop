namespace Quan_ly_cua_hang_FPT_Shop
{
    partial class UserControl_QuanLyNhanSu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pQuanLyTaiKhoan = new System.Windows.Forms.Panel();
            this.pThongTinNhanVien = new System.Windows.Forms.Panel();
            this.btQanLyTaiKhoan = new System.Windows.Forms.Button();
            this.btThongTinNhanVien = new System.Windows.Forms.Button();
            this.panelChinh = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pQuanLyTaiKhoan);
            this.panel1.Controls.Add(this.pThongTinNhanVien);
            this.panel1.Controls.Add(this.btQanLyTaiKhoan);
            this.panel1.Controls.Add(this.btThongTinNhanVien);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1329, 63);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pQuanLyTaiKhoan
            // 
            this.pQuanLyTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.pQuanLyTaiKhoan.Location = new System.Drawing.Point(190, 59);
            this.pQuanLyTaiKhoan.Name = "pQuanLyTaiKhoan";
            this.pQuanLyTaiKhoan.Size = new System.Drawing.Size(189, 3);
            this.pQuanLyTaiKhoan.TabIndex = 1;
            this.pQuanLyTaiKhoan.Paint += new System.Windows.Forms.PaintEventHandler(this.pQuanLyTaiKhoan_Paint);
            // 
            // pThongTinNhanVien
            // 
            this.pThongTinNhanVien.BackColor = System.Drawing.Color.MidnightBlue;
            this.pThongTinNhanVien.Location = new System.Drawing.Point(0, 59);
            this.pThongTinNhanVien.Name = "pThongTinNhanVien";
            this.pThongTinNhanVien.Size = new System.Drawing.Size(189, 3);
            this.pThongTinNhanVien.TabIndex = 1;
            this.pThongTinNhanVien.Paint += new System.Windows.Forms.PaintEventHandler(this.pThongTinNhanVien_Paint);
            // 
            // btQanLyTaiKhoan
            // 
            this.btQanLyTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btQanLyTaiKhoan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btQanLyTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQanLyTaiKhoan.Font = new System.Drawing.Font("#9Slide02 Tieu de dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQanLyTaiKhoan.ForeColor = System.Drawing.Color.DimGray;
            this.btQanLyTaiKhoan.Location = new System.Drawing.Point(190, 0);
            this.btQanLyTaiKhoan.Name = "btQanLyTaiKhoan";
            this.btQanLyTaiKhoan.Size = new System.Drawing.Size(189, 61);
            this.btQanLyTaiKhoan.TabIndex = 0;
            this.btQanLyTaiKhoan.Text = "Quản lý tài khoản";
            this.btQanLyTaiKhoan.UseVisualStyleBackColor = true;
            this.btQanLyTaiKhoan.Click += new System.EventHandler(this.btThongKe_Click);
            // 
            // btThongTinNhanVien
            // 
            this.btThongTinNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThongTinNhanVien.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btThongTinNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThongTinNhanVien.Font = new System.Drawing.Font("#9Slide02 Tieu de dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThongTinNhanVien.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btThongTinNhanVien.Location = new System.Drawing.Point(0, 0);
            this.btThongTinNhanVien.Name = "btThongTinNhanVien";
            this.btThongTinNhanVien.Size = new System.Drawing.Size(189, 62);
            this.btThongTinNhanVien.TabIndex = 0;
            this.btThongTinNhanVien.Text = "Thông tin nhân viên";
            this.btThongTinNhanVien.UseVisualStyleBackColor = true;
            this.btThongTinNhanVien.Click += new System.EventHandler(this.btNhanSu_Click);
            // 
            // panelChinh
            // 
            this.panelChinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChinh.Location = new System.Drawing.Point(0, 62);
            this.panelChinh.Name = "panelChinh";
            this.panelChinh.Size = new System.Drawing.Size(1329, 684);
            this.panelChinh.TabIndex = 1;
            this.panelChinh.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChinh_Paint);
            // 
            // UserControl_QuanLyNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelChinh);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControl_QuanLyNhanSu";
            this.Size = new System.Drawing.Size(1329, 746);
            this.Load += new System.EventHandler(this.UserControl_QuanLyNhanSu_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pThongTinNhanVien;
        private System.Windows.Forms.Button btThongTinNhanVien;
        private System.Windows.Forms.Panel pQuanLyTaiKhoan;
        private System.Windows.Forms.Button btQanLyTaiKhoan;
        private System.Windows.Forms.Panel panelChinh;
    }
}
