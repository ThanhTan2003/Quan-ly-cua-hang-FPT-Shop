﻿namespace Quan_ly_cua_hang_FPT_Shop.NV_QL_kho.Quan_ly_kho
{
    partial class UserControl_NVQLKho_QuanLyKho_XuatKho
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
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listDS = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbNguoiGH = new System.Windows.Forms.TextBox();
            this.tbTongTien = new System.Windows.Forms.TextBox();
            this.tbGiamGia = new System.Windows.Forms.TextBox();
            this.tbTongCong = new System.Windows.Forms.TextBox();
            this.tbNgayMuaHang = new System.Windows.Forms.TextBox();
            this.tbThuNgan = new System.Windows.Forms.TextBox();
            this.tbMaDH = new System.Windows.Forms.TextBox();
            this.tbSoDT = new System.Windows.Forms.TextBox();
            this.tbTenKH = new System.Windows.Forms.TextBox();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.btTim = new System.Windows.Forms.Button();
            this.rdTenKH = new System.Windows.Forms.RadioButton();
            this.tbtuKhoa = new System.Windows.Forms.TextBox();
            this.rdSoDT = new System.Windows.Forms.RadioButton();
            this.rdMaDH = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbGhiChu = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbTrangThaiDonHang = new System.Windows.Forms.ComboBox();
            this.tbSoDTNguoiNhanHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên khách hàng";
            this.columnHeader2.Width = 233;
            // 
            // listDS
            // 
            this.listDS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
            this.listDS.FullRowSelect = true;
            this.listDS.GridLines = true;
            this.listDS.HideSelection = false;
            this.listDS.Location = new System.Drawing.Point(27, 332);
            this.listDS.Name = "listDS";
            this.listDS.OwnerDraw = true;
            this.listDS.Size = new System.Drawing.Size(626, 335);
            this.listDS.TabIndex = 106;
            this.listDS.UseCompatibleStateImageBehavior = false;
            this.listDS.View = System.Windows.Forms.View.Details;
            this.listDS.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listDS_DrawColumnHeader_1);
            this.listDS.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listDS_DrawItem_1);
            this.listDS.SelectedIndexChanged += new System.EventHandler(this.listDS_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã đơn hàng";
            this.columnHeader1.Width = 214;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Trạng thái";
            this.columnHeader4.Width = 174;
            // 
            // tbNguoiGH
            // 
            this.tbNguoiGH.Font = new System.Drawing.Font("#9Slide02 Noi dung dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNguoiGH.Location = new System.Drawing.Point(876, 245);
            this.tbNguoiGH.Name = "tbNguoiGH";
            this.tbNguoiGH.Size = new System.Drawing.Size(257, 27);
            this.tbNguoiGH.TabIndex = 105;
            // 
            // tbTongTien
            // 
            this.tbTongTien.Enabled = false;
            this.tbTongTien.Font = new System.Drawing.Font("#9Slide02 Noi dung dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTongTien.Location = new System.Drawing.Point(1104, 80);
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.Size = new System.Drawing.Size(191, 27);
            this.tbTongTien.TabIndex = 103;
            this.tbTongTien.TextChanged += new System.EventHandler(this.tbTongTien_TextChanged);
            // 
            // tbGiamGia
            // 
            this.tbGiamGia.Enabled = false;
            this.tbGiamGia.Font = new System.Drawing.Font("#9Slide02 Noi dung dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGiamGia.Location = new System.Drawing.Point(1104, 109);
            this.tbGiamGia.Name = "tbGiamGia";
            this.tbGiamGia.Size = new System.Drawing.Size(191, 27);
            this.tbGiamGia.TabIndex = 102;
            this.tbGiamGia.TextChanged += new System.EventHandler(this.tbGiamGia_TextChanged);
            // 
            // tbTongCong
            // 
            this.tbTongCong.Enabled = false;
            this.tbTongCong.Font = new System.Drawing.Font("#9Slide02 Noi dung dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTongCong.Location = new System.Drawing.Point(1104, 142);
            this.tbTongCong.Name = "tbTongCong";
            this.tbTongCong.Size = new System.Drawing.Size(191, 27);
            this.tbTongCong.TabIndex = 101;
            this.tbTongCong.TextChanged += new System.EventHandler(this.tbTongCong_TextChanged);
            // 
            // tbNgayMuaHang
            // 
            this.tbNgayMuaHang.Enabled = false;
            this.tbNgayMuaHang.Font = new System.Drawing.Font("#9Slide02 Noi dung dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNgayMuaHang.Location = new System.Drawing.Point(824, 167);
            this.tbNgayMuaHang.Name = "tbNgayMuaHang";
            this.tbNgayMuaHang.Size = new System.Drawing.Size(183, 27);
            this.tbNgayMuaHang.TabIndex = 100;
            // 
            // tbThuNgan
            // 
            this.tbThuNgan.Enabled = false;
            this.tbThuNgan.Font = new System.Drawing.Font("#9Slide02 Noi dung dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbThuNgan.Location = new System.Drawing.Point(770, 138);
            this.tbThuNgan.Name = "tbThuNgan";
            this.tbThuNgan.Size = new System.Drawing.Size(237, 27);
            this.tbThuNgan.TabIndex = 99;
            // 
            // tbMaDH
            // 
            this.tbMaDH.Enabled = false;
            this.tbMaDH.Font = new System.Drawing.Font("#9Slide02 Noi dung dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaDH.Location = new System.Drawing.Point(770, 109);
            this.tbMaDH.Name = "tbMaDH";
            this.tbMaDH.Size = new System.Drawing.Size(237, 27);
            this.tbMaDH.TabIndex = 98;
            // 
            // tbSoDT
            // 
            this.tbSoDT.Enabled = false;
            this.tbSoDT.Font = new System.Drawing.Font("#9Slide02 Noi dung dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoDT.Location = new System.Drawing.Point(770, 80);
            this.tbSoDT.Name = "tbSoDT";
            this.tbSoDT.Size = new System.Drawing.Size(237, 27);
            this.tbSoDT.TabIndex = 97;
            // 
            // tbTenKH
            // 
            this.tbTenKH.Enabled = false;
            this.tbTenKH.Font = new System.Drawing.Font("#9Slide02 Noi dung dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenKH.Location = new System.Drawing.Point(770, 51);
            this.tbTenKH.Name = "tbTenKH";
            this.tbTenKH.Size = new System.Drawing.Size(525, 27);
            this.tbTenKH.TabIndex = 77;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(876, 305);
            this.tbDiaChi.Multiline = true;
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(420, 57);
            this.tbDiaChi.TabIndex = 94;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("#9Slide02 Tieu de dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(687, 305);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(133, 20);
            this.label16.TabIndex = 93;
            this.label16.Text = "Địa chỉ giao hàng";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("#9Slide02 Tieu de dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(687, 141);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(77, 20);
            this.label27.TabIndex = 91;
            this.label27.Text = "Thu ngân";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("#9Slide02 Tieu de dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(1013, 113);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(73, 20);
            this.label26.TabIndex = 90;
            this.label26.Text = "Giảm giá";
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // btTim
            // 
            this.btTim.BackColor = System.Drawing.Color.SteelBlue;
            this.btTim.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTim.ForeColor = System.Drawing.Color.White;
            this.btTim.Location = new System.Drawing.Point(171, 204);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(127, 38);
            this.btTim.TabIndex = 4;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = false;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // rdTenKH
            // 
            this.rdTenKH.AutoSize = true;
            this.rdTenKH.Font = new System.Drawing.Font("#9Slide02 Noi dung dai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTenKH.ForeColor = System.Drawing.Color.Black;
            this.rdTenKH.Location = new System.Drawing.Point(14, 135);
            this.rdTenKH.Name = "rdTenKH";
            this.rdTenKH.Size = new System.Drawing.Size(141, 24);
            this.rdTenKH.TabIndex = 2;
            this.rdTenKH.TabStop = true;
            this.rdTenKH.Text = "Tên khách hàng";
            this.rdTenKH.UseVisualStyleBackColor = true;
            // 
            // tbtuKhoa
            // 
            this.tbtuKhoa.Font = new System.Drawing.Font("#9Slide02 Noi dung dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtuKhoa.Location = new System.Drawing.Point(14, 62);
            this.tbtuKhoa.Name = "tbtuKhoa";
            this.tbtuKhoa.Size = new System.Drawing.Size(284, 27);
            this.tbtuKhoa.TabIndex = 3;
            // 
            // rdSoDT
            // 
            this.rdSoDT.AutoSize = true;
            this.rdSoDT.Font = new System.Drawing.Font("#9Slide02 Noi dung dai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSoDT.ForeColor = System.Drawing.Color.Black;
            this.rdSoDT.Location = new System.Drawing.Point(14, 170);
            this.rdSoDT.Name = "rdSoDT";
            this.rdSoDT.Size = new System.Drawing.Size(157, 24);
            this.rdSoDT.TabIndex = 1;
            this.rdSoDT.TabStop = true;
            this.rdSoDT.Text = "Số ĐT khách hàng";
            this.rdSoDT.UseVisualStyleBackColor = true;
            // 
            // rdMaDH
            // 
            this.rdMaDH.AutoSize = true;
            this.rdMaDH.Font = new System.Drawing.Font("#9Slide02 Noi dung dai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMaDH.ForeColor = System.Drawing.Color.Black;
            this.rdMaDH.Location = new System.Drawing.Point(14, 100);
            this.rdMaDH.Name = "rdMaDH";
            this.rdMaDH.Size = new System.Drawing.Size(122, 24);
            this.rdMaDH.TabIndex = 0;
            this.rdMaDH.TabStop = true;
            this.rdMaDH.Text = "Mã đơn hàng";
            this.rdMaDH.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("#9Slide02 Tieu de dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập từ khóa";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("#9Slide02 Tieu de dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(687, 170);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(127, 20);
            this.label22.TabIndex = 89;
            this.label22.Text = "Ngày mua hàng:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(690, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 1);
            this.panel1.TabIndex = 88;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("#9Slide02 Tieu de dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(687, 248);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 20);
            this.label13.TabIndex = 87;
            this.label13.Text = "Người giao hàng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("#9Slide02 Tieu de dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(686, 278);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 20);
            this.label12.TabIndex = 86;
            this.label12.Text = "Trạng thái đơn hàng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("#9Slide02 Tieu de dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1013, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 20);
            this.label11.TabIndex = 85;
            this.label11.Text = "Tổng cộng";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("#9Slide02 Tieu de dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1012, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 84;
            this.label10.Text = "Tổng tiền";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("#9Slide02 Tieu de dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(686, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 83;
            this.label9.Text = "Mã ĐH";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("#9Slide02 Tieu de dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(686, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 82;
            this.label8.Text = "Số ĐT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("#9Slide02 Tieu de dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(686, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 81;
            this.label7.Text = "Tên KH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("#9Slide02 Tieu de dai", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(686, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 24);
            this.label6.TabIndex = 80;
            this.label6.Text = "THÔNG TIN ĐƠN HÀNG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("#9Slide02 Tieu de dai", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(22, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 24);
            this.label5.TabIndex = 79;
            this.label5.Text = "DANH SÁCH ĐƠN HÀNG";
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Location = new System.Drawing.Point(381, 296);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(272, 28);
            this.cbTrangThai.TabIndex = 78;
            this.cbTrangThai.SelectedIndexChanged += new System.EventHandler(this.cbTrangThai_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("#9Slide02 Noi dung dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(377, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 20);
            this.label4.TabIndex = 76;
            this.label4.Text = "LỌC THEO TRẠNG THÁI";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btTim);
            this.groupBox1.Controls.Add(this.rdTenKH);
            this.groupBox1.Controls.Add(this.tbtuKhoa);
            this.groupBox1.Controls.Add(this.rdSoDT);
            this.groupBox1.Controls.Add(this.rdMaDH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("#9Slide02 Noi dung dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(27, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 251);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TÌM KIẾM";
            // 
            // tbGhiChu
            // 
            this.tbGhiChu.Location = new System.Drawing.Point(692, 372);
            this.tbGhiChu.Multiline = true;
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.Size = new System.Drawing.Size(605, 55);
            this.tbGhiChu.TabIndex = 108;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("#9Slide02 Tieu de dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(687, 349);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 20);
            this.label15.TabIndex = 107;
            this.label15.Text = "Ghi chú";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("#9Slide02 Tieu de dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(867, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "CẬP NHẬT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbTrangThaiDonHang
            // 
            this.cbTrangThaiDonHang.FormattingEnabled = true;
            this.cbTrangThaiDonHang.Items.AddRange(new object[] {
            "Đã giao hàng",
            "Chờ giao hàng",
            "Đang giao hàng",
            "Đã thanh thoán"});
            this.cbTrangThaiDonHang.Location = new System.Drawing.Point(876, 275);
            this.cbTrangThaiDonHang.Name = "cbTrangThaiDonHang";
            this.cbTrangThaiDonHang.Size = new System.Drawing.Size(257, 28);
            this.cbTrangThaiDonHang.TabIndex = 109;
            // 
            // tbSoDTNguoiNhanHang
            // 
            this.tbSoDTNguoiNhanHang.Font = new System.Drawing.Font("#9Slide02 Noi dung dai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoDTNguoiNhanHang.Location = new System.Drawing.Point(876, 216);
            this.tbSoDTNguoiNhanHang.Name = "tbSoDTNguoiNhanHang";
            this.tbSoDTNguoiNhanHang.Size = new System.Drawing.Size(257, 27);
            this.tbSoDTNguoiNhanHang.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("#9Slide02 Tieu de dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(687, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 113;
            this.label1.Text = "Số ĐT người nhận hàng:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("#9Slide02 Tieu de dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.SteelBlue;
            this.button2.Location = new System.Drawing.Point(1086, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 38);
            this.button2.TabIndex = 114;
            this.button2.Text = "Tải lại hóa đơn";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserControl_NVQLKho_QuanLyKho_XuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSoDTNguoiNhanHang);
            this.Controls.Add(this.cbTrangThaiDonHang);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbGhiChu);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.listDS);
            this.Controls.Add(this.tbNguoiGH);
            this.Controls.Add(this.tbTongTien);
            this.Controls.Add(this.tbGiamGia);
            this.Controls.Add(this.tbTongCong);
            this.Controls.Add(this.tbNgayMuaHang);
            this.Controls.Add(this.tbThuNgan);
            this.Controls.Add(this.tbMaDH);
            this.Controls.Add(this.tbSoDT);
            this.Controls.Add(this.tbTenKH);
            this.Controls.Add(this.tbDiaChi);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbTrangThai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("#9Slide02 Noi dung dai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControl_NVQLKho_QuanLyKho_XuatKho";
            this.Size = new System.Drawing.Size(1329, 650);
            this.Load += new System.EventHandler(this.UserControl_NVQLKho_QuanLyKho_XuatKho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listDS;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox tbNguoiGH;
        private System.Windows.Forms.TextBox tbTongTien;
        private System.Windows.Forms.TextBox tbGiamGia;
        private System.Windows.Forms.TextBox tbTongCong;
        private System.Windows.Forms.TextBox tbNgayMuaHang;
        private System.Windows.Forms.TextBox tbThuNgan;
        private System.Windows.Forms.TextBox tbMaDH;
        private System.Windows.Forms.TextBox tbSoDT;
        private System.Windows.Forms.TextBox tbTenKH;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.RadioButton rdTenKH;
        private System.Windows.Forms.TextBox tbtuKhoa;
        private System.Windows.Forms.RadioButton rdSoDT;
        private System.Windows.Forms.RadioButton rdMaDH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbGhiChu;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbTrangThaiDonHang;
        private System.Windows.Forms.TextBox tbSoDTNguoiNhanHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}
