namespace Quan_ly_cua_hang_FPT_Shop.NV_Ban_hang.Quan_ly_mat_hang
{
    partial class UserControl_NVBanHang_QuanLyMatHang_MatHang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_NVBanHang_QuanLyMatHang_MatHang));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Apple (iPhone)");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("SamSung");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Oppo");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Vivo");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Điện thoại", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Apple (Macbook)");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Dell");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("HP");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Asus");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("LG");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Laptop", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Apple (iPad)");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("SamSung");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Lenovo");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Máy tính bảng", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Tai nghe");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Cáp sạc");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Sạc dự phòng");
            this.listQuaTang = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label12 = new System.Windows.Forms.Label();
            this.btThayDoiHinhAnh = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tbTenMH = new System.Windows.Forms.TextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listDS = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaMH = new System.Windows.Forms.Label();
            this.cbPhanLoai = new System.Windows.Forms.Label();
            this.cbXuatXu = new System.Windows.Forms.Label();
            this.cbThuongHieu = new System.Windows.Forms.Label();
            this.tbGiaBan = new System.Windows.Forms.Label();
            this.tbGiaKhuyenMai = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbMucGia = new System.Windows.Forms.ComboBox();
            this.tbTuKhoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.treeDS = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // listQuaTang
            // 
            this.listQuaTang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6});
            this.listQuaTang.FullRowSelect = true;
            this.listQuaTang.GridLines = true;
            this.listQuaTang.HideSelection = false;
            this.listQuaTang.Location = new System.Drawing.Point(976, 485);
            this.listQuaTang.Name = "listQuaTang";
            this.listQuaTang.OwnerDraw = true;
            this.listQuaTang.Size = new System.Drawing.Size(329, 148);
            this.listQuaTang.TabIndex = 62;
            this.listQuaTang.UseCompatibleStateImageBehavior = false;
            this.listQuaTang.View = System.Windows.Forms.View.Details;
            this.listQuaTang.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listQuaTang_DrawColumnHeader);
            this.listQuaTang.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listQuaTang_DrawItem);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tên quà tặng";
            this.columnHeader6.Width = 325;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("#9Slide02 Tieu de dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(972, 383);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 60;
            this.label12.Text = "Giá KM";
            // 
            // btThayDoiHinhAnh
            // 
            this.btThayDoiHinhAnh.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btThayDoiHinhAnh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThayDoiHinhAnh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btThayDoiHinhAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThayDoiHinhAnh.Font = new System.Drawing.Font("#9Slide02 Noi dung dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThayDoiHinhAnh.ForeColor = System.Drawing.Color.White;
            this.btThayDoiHinhAnh.Location = new System.Drawing.Point(673, 224);
            this.btThayDoiHinhAnh.Name = "btThayDoiHinhAnh";
            this.btThayDoiHinhAnh.Size = new System.Drawing.Size(277, 36);
            this.btThayDoiHinhAnh.TabIndex = 59;
            this.btThayDoiHinhAnh.Text = "Thay đổi hình ảnh";
            this.btThayDoiHinhAnh.UseVisualStyleBackColor = false;
            // 
            // pic
            // 
            this.pic.Image = global::Quan_ly_cua_hang_FPT_Shop.Properties.Resources.Chien_luoc_Marketing_cua_FPT_Shop_1;
            this.pic.Location = new System.Drawing.Point(673, 17);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(277, 201);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 58;
            this.pic.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("#9Slide02 Tieu de dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(977, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 20);
            this.label11.TabIndex = 56;
            this.label11.Text = "Phân loại";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("#9Slide02 Tieu de dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(972, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 50;
            this.label10.Text = "Thương hiệu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("#9Slide02 Tieu de dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(969, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 48;
            this.label9.Text = "Giá bán";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("#9Slide02 Tieu de dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(977, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "Xuất xứ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("#9Slide02 Tieu de dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(972, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "Tên mặt hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("#9Slide02 Tieu de dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(977, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "Mã mặt hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("#9Slide02 Tieu de dai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(977, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 24);
            this.label5.TabIndex = 41;
            this.label5.Text = "THÔNG TIN MẶT HÀNG";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "186239.png");
            this.imageList1.Images.SetKeyName(1, "428001.png");
            this.imageList1.Images.SetKeyName(2, "3355318.png");
            this.imageList1.Images.SetKeyName(3, "3616856.png");
            this.imageList1.Images.SetKeyName(4, "appple.png");
            this.imageList1.Images.SetKeyName(5, "samsung-icon-512x512-0o72hicf.png");
            this.imageList1.Images.SetKeyName(6, "Screenshot 2023-09-27 083358.png");
            this.imageList1.Images.SetKeyName(7, "tải xuống.png");
            this.imageList1.Images.SetKeyName(8, "214486.png");
            this.imageList1.Images.SetKeyName(9, "882726.png");
            this.imageList1.Images.SetKeyName(10, "lg_logo_icon_170264.png");
            this.imageList1.Images.SetKeyName(11, "1024px-HP_logo_2012.svg.png");
            this.imageList1.Images.SetKeyName(12, "keyboardbasicflat_106016.png");
            this.imageList1.Images.SetKeyName(13, "pngtree-headphones-icon-png-image_2383065.jpg");
            this.imageList1.Images.SetKeyName(14, "tải xuống (1).png");
            this.imageList1.Images.SetKeyName(15, "tải xuống4.png");
            this.imageList1.Images.SetKeyName(16, "Screenshot 2023-09-27 084408.png");
            // 
            // tbTenMH
            // 
            this.tbTenMH.Enabled = false;
            this.tbTenMH.Location = new System.Drawing.Point(1087, 101);
            this.tbTenMH.Multiline = true;
            this.tbTenMH.Name = "tbTenMH";
            this.tbTenMH.Size = new System.Drawing.Size(218, 78);
            this.tbTenMH.TabIndex = 44;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã MH";
            this.columnHeader1.Width = 109;
            // 
            // listDS
            // 
            this.listDS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listDS.FullRowSelect = true;
            this.listDS.GridLines = true;
            this.listDS.HideSelection = false;
            this.listDS.Location = new System.Drawing.Point(317, 279);
            this.listDS.Name = "listDS";
            this.listDS.OwnerDraw = true;
            this.listDS.Size = new System.Drawing.Size(633, 354);
            this.listDS.TabIndex = 39;
            this.listDS.UseCompatibleStateImageBehavior = false;
            this.listDS.View = System.Windows.Forms.View.Details;
            this.listDS.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listDS_DrawColumnHeader);
            this.listDS.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listDS_DrawItem);
            this.listDS.SelectedIndexChanged += new System.EventHandler(this.listDS_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên mặt hàng";
            this.columnHeader2.Width = 188;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Thương hiệu";
            this.columnHeader3.Width = 147;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá";
            this.columnHeader4.Width = 185;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("#9Slide02 Tieu de dai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(315, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "DANH SÁCH MẶT HÀNG";
            // 
            // tbMaMH
            // 
            this.tbMaMH.AutoSize = true;
            this.tbMaMH.Font = new System.Drawing.Font("#9Slide02 Noi dung dai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaMH.Location = new System.Drawing.Point(1083, 54);
            this.tbMaMH.Name = "tbMaMH";
            this.tbMaMH.Size = new System.Drawing.Size(21, 20);
            this.tbMaMH.TabIndex = 63;
            this.tbMaMH.Text = "...";
            // 
            // cbPhanLoai
            // 
            this.cbPhanLoai.AutoSize = true;
            this.cbPhanLoai.Font = new System.Drawing.Font("#9Slide02 Noi dung dai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPhanLoai.Location = new System.Drawing.Point(1083, 198);
            this.cbPhanLoai.Name = "cbPhanLoai";
            this.cbPhanLoai.Size = new System.Drawing.Size(21, 20);
            this.cbPhanLoai.TabIndex = 64;
            this.cbPhanLoai.Text = "...";
            // 
            // cbXuatXu
            // 
            this.cbXuatXu.AutoSize = true;
            this.cbXuatXu.Font = new System.Drawing.Font("#9Slide02 Noi dung dai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbXuatXu.Location = new System.Drawing.Point(1083, 246);
            this.cbXuatXu.Name = "cbXuatXu";
            this.cbXuatXu.Size = new System.Drawing.Size(21, 20);
            this.cbXuatXu.TabIndex = 65;
            this.cbXuatXu.Text = "...";
            // 
            // cbThuongHieu
            // 
            this.cbThuongHieu.AutoSize = true;
            this.cbThuongHieu.Font = new System.Drawing.Font("#9Slide02 Noi dung dai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThuongHieu.Location = new System.Drawing.Point(1083, 295);
            this.cbThuongHieu.Name = "cbThuongHieu";
            this.cbThuongHieu.Size = new System.Drawing.Size(21, 20);
            this.cbThuongHieu.TabIndex = 66;
            this.cbThuongHieu.Text = "...";
            // 
            // tbGiaBan
            // 
            this.tbGiaBan.AutoSize = true;
            this.tbGiaBan.Font = new System.Drawing.Font("#9Slide02 Noi dung dai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGiaBan.Location = new System.Drawing.Point(1083, 341);
            this.tbGiaBan.Name = "tbGiaBan";
            this.tbGiaBan.Size = new System.Drawing.Size(21, 20);
            this.tbGiaBan.TabIndex = 67;
            this.tbGiaBan.Text = "...";
            // 
            // tbGiaKhuyenMai
            // 
            this.tbGiaKhuyenMai.AutoSize = true;
            this.tbGiaKhuyenMai.Font = new System.Drawing.Font("#9Slide02 Noi dung dai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGiaKhuyenMai.Location = new System.Drawing.Point(1083, 383);
            this.tbGiaKhuyenMai.Name = "tbGiaKhuyenMai";
            this.tbGiaKhuyenMai.Size = new System.Drawing.Size(21, 20);
            this.tbGiaKhuyenMai.TabIndex = 68;
            this.tbGiaKhuyenMai.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("#9Slide02 Tieu de dai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(313, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 74;
            this.label4.Text = "TÌM KIẾM";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("#9Slide02 Tieu de dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(512, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 39);
            this.button1.TabIndex = 73;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cbMucGia
            // 
            this.cbMucGia.FormattingEnabled = true;
            this.cbMucGia.Items.AddRange(new object[] {
            "Tất cả",
            "Dưới 5 triệu",
            "Từ 5 - 10 triệu",
            "Từ 10 - 20 triệu",
            "Trên 20 triệu"});
            this.cbMucGia.Location = new System.Drawing.Point(405, 198);
            this.cbMucGia.Name = "cbMucGia";
            this.cbMucGia.Size = new System.Drawing.Size(234, 28);
            this.cbMucGia.TabIndex = 72;
            this.cbMucGia.SelectedIndexChanged += new System.EventHandler(this.cbMucGia_SelectedIndexChanged);
            // 
            // tbTuKhoa
            // 
            this.tbTuKhoa.Location = new System.Drawing.Point(404, 59);
            this.tbTuKhoa.Name = "tbTuKhoa";
            this.tbTuKhoa.Size = new System.Drawing.Size(235, 27);
            this.tbTuKhoa.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("#9Slide02 Tieu de dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(313, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 70;
            this.label3.Text = "Từ khóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("#9Slide02 Tieu de dai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 69;
            this.label2.Text = "Mức giá";
            // 
            // treeDS
            // 
            this.treeDS.ImageIndex = 0;
            this.treeDS.ImageList = this.imageList1;
            this.treeDS.Location = new System.Drawing.Point(20, 17);
            this.treeDS.Name = "treeDS";
            treeNode1.ImageKey = "appple.png";
            treeNode1.Name = "Node4";
            treeNode1.SelectedImageIndex = 4;
            treeNode1.Text = "Apple (iPhone)";
            treeNode2.ImageKey = "samsung-icon-512x512-0o72hicf.png";
            treeNode2.Name = "Node5";
            treeNode2.SelectedImageIndex = 5;
            treeNode2.Text = "SamSung";
            treeNode3.ImageKey = "tải xuống.png";
            treeNode3.Name = "Node6";
            treeNode3.SelectedImageIndex = 7;
            treeNode3.Text = "Oppo";
            treeNode4.ImageKey = "Screenshot 2023-09-27 083358.png";
            treeNode4.Name = "Node7";
            treeNode4.SelectedImageIndex = 6;
            treeNode4.Text = "Vivo";
            treeNode5.ImageKey = "186239.png";
            treeNode5.Name = "Node0";
            treeNode5.SelectedImageIndex = 0;
            treeNode5.Text = "Điện thoại";
            treeNode6.ImageKey = "appple.png";
            treeNode6.Name = "Node0";
            treeNode6.SelectedImageIndex = 4;
            treeNode6.Text = "Apple (Macbook)";
            treeNode7.ImageKey = "882726.png";
            treeNode7.Name = "Node1";
            treeNode7.SelectedImageIndex = 9;
            treeNode7.Text = "Dell";
            treeNode8.ImageKey = "1024px-HP_logo_2012.svg.png";
            treeNode8.Name = "Node2";
            treeNode8.SelectedImageIndex = 11;
            treeNode8.Text = "HP";
            treeNode9.ImageKey = "214486.png";
            treeNode9.Name = "Node3";
            treeNode9.SelectedImageIndex = 8;
            treeNode9.Text = "Asus";
            treeNode10.ImageKey = "lg_logo_icon_170264.png";
            treeNode10.Name = "Node4";
            treeNode10.SelectedImageIndex = 10;
            treeNode10.Text = "LG";
            treeNode11.ImageKey = "428001.png";
            treeNode11.Name = "Node1";
            treeNode11.SelectedImageIndex = 1;
            treeNode11.Text = "Laptop";
            treeNode12.ImageKey = "appple.png";
            treeNode12.Name = "Node8";
            treeNode12.SelectedImageIndex = 4;
            treeNode12.Text = "Apple (iPad)";
            treeNode13.ImageKey = "samsung-icon-512x512-0o72hicf.png";
            treeNode13.Name = "Node9";
            treeNode13.SelectedImageIndex = 5;
            treeNode13.Text = "SamSung";
            treeNode14.ImageKey = "tải xuống4.png";
            treeNode14.Name = "Node10";
            treeNode14.SelectedImageIndex = 15;
            treeNode14.Text = "Lenovo";
            treeNode15.ImageKey = "3616856.png";
            treeNode15.Name = "Node2";
            treeNode15.SelectedImageIndex = 3;
            treeNode15.Text = "Máy tính bảng";
            treeNode16.ImageKey = "pngtree-headphones-icon-png-image_2383065.jpg";
            treeNode16.Name = "Node11";
            treeNode16.SelectedImageIndex = 13;
            treeNode16.Text = "Tai nghe";
            treeNode17.ImageKey = "tải xuống (1).png";
            treeNode17.Name = "Node13";
            treeNode17.SelectedImageIndex = 14;
            treeNode17.Text = "Cáp sạc";
            treeNode18.ImageKey = "Screenshot 2023-09-27 084408.png";
            treeNode18.Name = "Node16";
            treeNode18.SelectedImageIndex = 16;
            treeNode18.Text = "Sạc dự phòng";
            this.treeDS.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode11,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18});
            this.treeDS.SelectedImageIndex = 0;
            this.treeDS.Size = new System.Drawing.Size(274, 616);
            this.treeDS.TabIndex = 75;
            this.treeDS.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeDS_AfterSelect_1);
            // 
            // UserControl_NVBanHang_QuanLyMatHang_MatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeDS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbMucGia);
            this.Controls.Add(this.tbTuKhoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbGiaKhuyenMai);
            this.Controls.Add(this.tbGiaBan);
            this.Controls.Add(this.cbThuongHieu);
            this.Controls.Add(this.cbXuatXu);
            this.Controls.Add(this.cbPhanLoai);
            this.Controls.Add(this.tbMaMH);
            this.Controls.Add(this.listQuaTang);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btThayDoiHinhAnh);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTenMH);
            this.Controls.Add(this.listDS);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("#9Slide02 Noi dung dai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControl_NVBanHang_QuanLyMatHang_MatHang";
            this.Size = new System.Drawing.Size(1329, 650);
            this.Load += new System.EventHandler(this.UserControl_NVBanHang_QuanLyMatHang_MatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listQuaTang;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btThayDoiHinhAnh;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox tbTenMH;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listDS;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tbMaMH;
        private System.Windows.Forms.Label cbPhanLoai;
        private System.Windows.Forms.Label cbXuatXu;
        private System.Windows.Forms.Label cbThuongHieu;
        private System.Windows.Forms.Label tbGiaBan;
        private System.Windows.Forms.Label tbGiaKhuyenMai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbMucGia;
        private System.Windows.Forms.TextBox tbTuKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeDS;
    }
}
