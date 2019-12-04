namespace WindowsFormsApplication6
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuItemTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemĐN = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemĐK = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHSNV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.chấmCôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemThuongPhat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPhuCap = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnĐX = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picCong = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picHSNV = new System.Windows.Forms.PictureBox();
            this.picCTLuong = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHSNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCTLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // menuItemTaiKhoan
            // 
            this.menuItemTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemĐN,
            this.menuItemĐK});
            this.menuItemTaiKhoan.Name = "menuItemTaiKhoan";
            this.menuItemTaiKhoan.Size = new System.Drawing.Size(71, 20);
            this.menuItemTaiKhoan.Text = "Tài Khoản";
            // 
            // menuItemĐN
            // 
            this.menuItemĐN.Name = "menuItemĐN";
            this.menuItemĐN.Size = new System.Drawing.Size(152, 22);
            this.menuItemĐN.Text = "Đăng nhập";
            // 
            // menuItemĐK
            // 
            this.menuItemĐK.Name = "menuItemĐK";
            this.menuItemĐK.Size = new System.Drawing.Size(152, 22);
            this.menuItemĐK.Text = "Đăng kí";
            this.menuItemĐK.Click += new System.EventHandler(this.menuItemĐK_Click);
            // 
            // menuItemDanhMuc
            // 
            this.menuItemDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemHSNV,
            this.menuItemLuong});
            this.menuItemDanhMuc.Name = "menuItemDanhMuc";
            this.menuItemDanhMuc.Size = new System.Drawing.Size(74, 20);
            this.menuItemDanhMuc.Text = "Danh mục";
            // 
            // menuItemHSNV
            // 
            this.menuItemHSNV.Name = "menuItemHSNV";
            this.menuItemHSNV.Size = new System.Drawing.Size(164, 22);
            this.menuItemHSNV.Text = "Hồ Sơ Nhân Viên";
            // 
            // menuItemLuong
            // 
            this.menuItemLuong.Name = "menuItemLuong";
            this.menuItemLuong.Size = new System.Drawing.Size(164, 22);
            this.menuItemLuong.Text = "Tiền Lương";
            this.menuItemLuong.Click += new System.EventHandler(this.menuItemLuong_Click);
            // 
            // menuItemChucNang
            // 
            this.menuItemChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chấmCôngToolStripMenuItem});
            this.menuItemChucNang.Name = "menuItemChucNang";
            this.menuItemChucNang.Size = new System.Drawing.Size(77, 20);
            this.menuItemChucNang.Text = "Chức năng";
            // 
            // chấmCôngToolStripMenuItem
            // 
            this.chấmCôngToolStripMenuItem.Name = "chấmCôngToolStripMenuItem";
            this.chấmCôngToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.chấmCôngToolStripMenuItem.Text = "Chấm Công";
            this.chấmCôngToolStripMenuItem.Click += new System.EventHandler(this.chấmCôngToolStripMenuItem_Click);
            // 
            // menuItemQuanLy
            // 
            this.menuItemQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemThuongPhat,
            this.menuItemPhuCap});
            this.menuItemQuanLy.Name = "menuItemQuanLy";
            this.menuItemQuanLy.Size = new System.Drawing.Size(60, 20);
            this.menuItemQuanLy.Text = "Quản lý";
            // 
            // menuItemThuongPhat
            // 
            this.menuItemThuongPhat.Name = "menuItemThuongPhat";
            this.menuItemThuongPhat.Size = new System.Drawing.Size(152, 22);
            this.menuItemThuongPhat.Text = "Thưởng Phạt";
            this.menuItemThuongPhat.Click += new System.EventHandler(this.menuItemThuongPhat_Click);
            // 
            // menuItemPhuCap
            // 
            this.menuItemPhuCap.Name = "menuItemPhuCap";
            this.menuItemPhuCap.Size = new System.Drawing.Size(152, 22);
            this.menuItemPhuCap.Text = "Phụ Cấp";
            this.menuItemPhuCap.Click += new System.EventHandler(this.menuItemPhuCap_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemTaiKhoan,
            this.menuItemDanhMuc,
            this.menuItemChucNang,
            this.menuItemQuanLy});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(710, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnĐX
            // 
            this.btnĐX.BackColor = System.Drawing.SystemColors.Control;
            this.btnĐX.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnĐX.Location = new System.Drawing.Point(542, 23);
            this.btnĐX.Name = "btnĐX";
            this.btnĐX.Size = new System.Drawing.Size(75, 23);
            this.btnĐX.TabIndex = 16;
            this.btnĐX.Text = "Đăng xuất";
            this.btnĐX.UseVisualStyleBackColor = false;
            this.btnĐX.Click += new System.EventHandler(this.btnĐX_Click_1);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.Control;
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThoat.Location = new System.Drawing.Point(623, 23);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(42, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(356, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "PHẦN MỀM QUẢN LÝ NHÂN SỰ ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(95, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "TRONG CÔNG TY";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(161, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 121);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picCong);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.picHSNV);
            this.groupBox2.Controls.Add(this.picCTLuong);
            this.groupBox2.Location = new System.Drawing.Point(35, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(647, 134);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
            // 
            // picCong
            // 
            this.picCong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picCong.Image = global::WindowsFormsApplication6.Properties.Resources.cv_ico;
            this.picCong.Location = new System.Drawing.Point(266, 29);
            this.picCong.Name = "picCong";
            this.picCong.Size = new System.Drawing.Size(109, 64);
            this.picCong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCong.TabIndex = 13;
            this.picCong.TabStop = false;
            this.picCong.Click += new System.EventHandler(this.picCong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hồ Sơ Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Chấm Công";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Chi Tiết Lương";
            // 
            // picHSNV
            // 
            this.picHSNV.Image = global::WindowsFormsApplication6.Properties.Resources.file;
            this.picHSNV.Location = new System.Drawing.Point(52, 29);
            this.picHSNV.Name = "picHSNV";
            this.picHSNV.Size = new System.Drawing.Size(102, 64);
            this.picHSNV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHSNV.TabIndex = 8;
            this.picHSNV.TabStop = false;
            this.picHSNV.Click += new System.EventHandler(this.picHSNV_Click);
            // 
            // picCTLuong
            // 
            this.picCTLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picCTLuong.Image = global::WindowsFormsApplication6.Properties.Resources.pb_ico;
            this.picCTLuong.Location = new System.Drawing.Point(488, 29);
            this.picCTLuong.Name = "picCTLuong";
            this.picCTLuong.Size = new System.Drawing.Size(94, 64);
            this.picCTLuong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCTLuong.TabIndex = 14;
            this.picCTLuong.TabStop = false;
            this.picCTLuong.Click += new System.EventHandler(this.picCTLuong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(710, 409);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnĐX);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHSNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCTLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem menuItemTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem menuItemĐN;
        private System.Windows.Forms.ToolStripMenuItem menuItemĐK;
        private System.Windows.Forms.ToolStripMenuItem menuItemDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem menuItemHSNV;
        private System.Windows.Forms.ToolStripMenuItem menuItemLuong;
        private System.Windows.Forms.ToolStripMenuItem menuItemChucNang;
        private System.Windows.Forms.ToolStripMenuItem chấmCôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemQuanLy;
        private System.Windows.Forms.ToolStripMenuItem menuItemThuongPhat;
        private System.Windows.Forms.ToolStripMenuItem menuItemPhuCap;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnĐX;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picCong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picHSNV;
        private System.Windows.Forms.PictureBox picCTLuong;

    }
}

