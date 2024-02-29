namespace Quan_ly_cua_hang_FPT_Shop
{
    partial class UserControl_QuanLyKho
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pTheoDoiTonKho = new System.Windows.Forms.Panel();
            this.btTheoDoiTonKho = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChinh
            // 
            this.panelChinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChinh.Location = new System.Drawing.Point(2, 62);
            this.panelChinh.Name = "panelChinh";
            this.panelChinh.Size = new System.Drawing.Size(1329, 684);
            this.panelChinh.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pTheoDoiTonKho);
            this.panel1.Controls.Add(this.btTheoDoiTonKho);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1329, 63);
            this.panel1.TabIndex = 2;
            // 
            // pTheoDoiTonKho
            // 
            this.pTheoDoiTonKho.BackColor = System.Drawing.Color.MidnightBlue;
            this.pTheoDoiTonKho.Location = new System.Drawing.Point(0, 59);
            this.pTheoDoiTonKho.Name = "pTheoDoiTonKho";
            this.pTheoDoiTonKho.Size = new System.Drawing.Size(189, 3);
            this.pTheoDoiTonKho.TabIndex = 1;
            // 
            // btTheoDoiTonKho
            // 
            this.btTheoDoiTonKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTheoDoiTonKho.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btTheoDoiTonKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTheoDoiTonKho.Font = new System.Drawing.Font("#9Slide02 Tieu de dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTheoDoiTonKho.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btTheoDoiTonKho.Location = new System.Drawing.Point(0, 0);
            this.btTheoDoiTonKho.Name = "btTheoDoiTonKho";
            this.btTheoDoiTonKho.Size = new System.Drawing.Size(189, 62);
            this.btTheoDoiTonKho.TabIndex = 0;
            this.btTheoDoiTonKho.Text = "Theo dõi tồn kho";
            this.btTheoDoiTonKho.UseVisualStyleBackColor = true;
            this.btTheoDoiTonKho.Click += new System.EventHandler(this.btTheoDoiTonKho_Click);
            // 
            // UserControl_QuanLyKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelChinh);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl_QuanLyKho";
            this.Size = new System.Drawing.Size(1329, 746);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChinh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pTheoDoiTonKho;
        private System.Windows.Forms.Button btTheoDoiTonKho;
    }
}
