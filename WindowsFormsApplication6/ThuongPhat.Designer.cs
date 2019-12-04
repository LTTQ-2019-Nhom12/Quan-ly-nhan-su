namespace WindowsFormsApplication6
{
    partial class ThuongPhat
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
            this.gridViewThuongPhat = new System.Windows.Forms.DataGridView();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loaitp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tientp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioBtnKT = new System.Windows.Forms.RadioButton();
            this.radioBtnPhat = new System.Windows.Forms.RadioButton();
            this.txtLyDo = new System.Windows.Forms.RichTextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTP = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewThuongPhat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewThuongPhat
            // 
            this.gridViewThuongPhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewThuongPhat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.HoTen,
            this.Loaitp,
            this.Tientp,
            this.LyDo,
            this.Ngay});
            this.gridViewThuongPhat.Location = new System.Drawing.Point(12, 73);
            this.gridViewThuongPhat.Name = "gridViewThuongPhat";
            this.gridViewThuongPhat.Size = new System.Drawing.Size(601, 351);
            this.gridViewThuongPhat.TabIndex = 2;
            this.gridViewThuongPhat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewThuongPhat_CellContentClick);
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaNhanVien.DataPropertyName = "MaNV";
            this.MaNhanVien.HeaderText = "Mã NV";
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.Width = 65;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.Name = "HoTen";
            // 
            // Loaitp
            // 
            this.Loaitp.DataPropertyName = "Loai";
            this.Loaitp.HeaderText = "Loại";
            this.Loaitp.Name = "Loaitp";
            // 
            // Tientp
            // 
            this.Tientp.DataPropertyName = "Tien";
            this.Tientp.HeaderText = "Tiền";
            this.Tientp.Name = "Tientp";
            // 
            // LyDo
            // 
            this.LyDo.DataPropertyName = "LyDo";
            this.LyDo.HeaderText = "Lý Do";
            this.LyDo.Name = "LyDo";
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "Ngay";
            this.Ngay.HeaderText = "Ngày Tháng";
            this.Ngay.Name = "Ngay";
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(100, 244);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(191, 20);
            this.txtTien.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tiền";
            // 
            // radioBtnKT
            // 
            this.radioBtnKT.AutoSize = true;
            this.radioBtnKT.Checked = true;
            this.radioBtnKT.Location = new System.Drawing.Point(100, 61);
            this.radioBtnKT.Name = "radioBtnKT";
            this.radioBtnKT.Size = new System.Drawing.Size(90, 17);
            this.radioBtnKT.TabIndex = 2;
            this.radioBtnKT.TabStop = true;
            this.radioBtnKT.Text = "Khen Thưởng";
            this.radioBtnKT.UseVisualStyleBackColor = true;
            // 
            // radioBtnPhat
            // 
            this.radioBtnPhat.AutoSize = true;
            this.radioBtnPhat.Location = new System.Drawing.Point(273, 61);
            this.radioBtnPhat.Name = "radioBtnPhat";
            this.radioBtnPhat.Size = new System.Drawing.Size(47, 17);
            this.radioBtnPhat.TabIndex = 2;
            this.radioBtnPhat.Text = "Phạt";
            this.radioBtnPhat.UseVisualStyleBackColor = true;
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(100, 112);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(262, 112);
            this.txtLyDo.TabIndex = 7;
            this.txtLyDo.Text = "";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(111, 292);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(192, 292);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(273, 292);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "VNĐ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Lý do";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(43, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 42);
            this.panel1.TabIndex = 8;
            // 
            // dateTP
            // 
            this.dateTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTP.Location = new System.Drawing.Point(100, 29);
            this.dateTP.Name = "dateTP";
            this.dateTP.Size = new System.Drawing.Size(118, 20);
            this.dateTP.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTP);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.txtTien);
            this.groupBox1.Controls.Add(this.txtLyDo);
            this.groupBox1.Controls.Add(this.radioBtnKT);
            this.groupBox1.Controls.Add(this.radioBtnPhat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(619, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 330);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(30, 292);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // ThuongPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 452);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridViewThuongPhat);
            this.Name = "ThuongPhat";
            this.Text = "ThuongPhat";
            this.Load += new System.EventHandler(this.ThuongPhat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewThuongPhat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewThuongPhat;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioBtnKT;
        private System.Windows.Forms.RadioButton radioBtnPhat;
        private System.Windows.Forms.RichTextBox txtLyDo;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loaitp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tientp;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
    }
}