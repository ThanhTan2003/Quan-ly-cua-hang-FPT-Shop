namespace Quan_ly_cua_hang_FPT_Shop.NV_Ban_hang.Khach_hang
{
    partial class UserControl_NVBanHang_KhachHang
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
            this.panelChinh = new System.Windows.Forms.Panel();
            this.pThongTinKhachHang = new System.Windows.Forms.Panel();
            this.btThongTinKhachHang = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChinh
            // 
            this.panelChinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChinh.Location = new System.Drawing.Point(0, 62);
            this.panelChinh.Name = "panelChinh";
            this.panelChinh.Size = new System.Drawing.Size(1329, 684);
            this.panelChinh.TabIndex = 7;
            // 
            // pThongTinKhachHang
            // 
            this.pThongTinKhachHang.BackColor = System.Drawing.Color.MidnightBlue;
            this.pThongTinKhachHang.Location = new System.Drawing.Point(0, 59);
            this.pThongTinKhachHang.Name = "pThongTinKhachHang";
            this.pThongTinKhachHang.Size = new System.Drawing.Size(189, 3);
            this.pThongTinKhachHang.TabIndex = 1;
            // 
            // btThongTinKhachHang
            // 
            this.btThongTinKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThongTinKhachHang.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btThongTinKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThongTinKhachHang.Font = new System.Drawing.Font("#9Slide02 Tieu de dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThongTinKhachHang.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btThongTinKhachHang.Location = new System.Drawing.Point(0, 0);
            this.btThongTinKhachHang.Name = "btThongTinKhachHang";
            this.btThongTinKhachHang.Size = new System.Drawing.Size(189, 62);
            this.btThongTinKhachHang.TabIndex = 0;
            this.btThongTinKhachHang.Text = "Thông tin khách hàng";
            this.btThongTinKhachHang.UseVisualStyleBackColor = true;
            this.btThongTinKhachHang.Click += new System.EventHandler(this.btThongTinKhachHang_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pThongTinKhachHang);
            this.panel1.Controls.Add(this.btThongTinKhachHang);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1329, 63);
            this.panel1.TabIndex = 6;
            // 
            // UserControl_NVBanHang_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelChinh);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("#9Slide02 Noi dung dai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControl_NVBanHang_KhachHang";
            this.Size = new System.Drawing.Size(1329, 746);
            this.Load += new System.EventHandler(this.UserControl_NVBanHang_KhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChinh;
        private System.Windows.Forms.Panel pThongTinKhachHang;
        private System.Windows.Forms.Button btThongTinKhachHang;
        private System.Windows.Forms.Panel panel1;
    }
}
