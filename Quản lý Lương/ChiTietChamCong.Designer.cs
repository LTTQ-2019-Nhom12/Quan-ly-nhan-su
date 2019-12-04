namespace WindowsFormsApplication6
{
    partial class ChiTietChamCong
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateCong = new System.Windows.Forms.DateTimePicker();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.ckBChamCong = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbNV = new System.Windows.Forms.Label();
            this.lbHT = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.gridViewChamCong = new System.Windows.Forms.DataGridView();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tblChiTietChamCongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSua = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lbTT = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChamCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChiTietChamCongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(555, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn Ngày";
            // 
            // dateCong
            // 
            this.dateCong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCong.Location = new System.Drawing.Point(135, 43);
            this.dateCong.Name = "dateCong";
            this.dateCong.Size = new System.Drawing.Size(131, 20);
            this.dateCong.TabIndex = 1;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(325, 38);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa ngày công";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(448, 38);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(79, 23);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // ckBChamCong
            // 
            this.ckBChamCong.AutoSize = true;
            this.ckBChamCong.Location = new System.Drawing.Point(767, 38);
            this.ckBChamCong.Name = "ckBChamCong";
            this.ckBChamCong.Size = new System.Drawing.Size(110, 17);
            this.ckBChamCong.TabIndex = 3;
            this.ckBChamCong.Text = "Chấm công tất cả";
            this.ckBChamCong.UseVisualStyleBackColor = true;
            this.ckBChamCong.CheckedChanged += new System.EventHandler(this.ckBChamCong_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckBChamCong);
            this.groupBox1.Controls.Add(this.btnXem);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.dateCong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(-1, 368);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(930, 82);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lbNV
            // 
            this.lbNV.AutoSize = true;
            this.lbNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNV.Location = new System.Drawing.Point(130, 91);
            this.lbNV.Name = "lbNV";
            this.lbNV.Size = new System.Drawing.Size(47, 20);
            this.lbNV.TabIndex = 2;
            this.lbNV.Text = "MNV";
            // 
            // lbHT
            // 
            this.lbHT.AutoSize = true;
            this.lbHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHT.Location = new System.Drawing.Point(291, 91);
            this.lbHT.Name = "lbHT";
            this.lbHT.Size = new System.Drawing.Size(58, 20);
            this.lbHT.TabIndex = 2;
            this.lbHT.Text = "Hoten";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(407, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 24);
            this.label13.TabIndex = 2;
            this.label13.Text = "CHẤM CÔNG";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Mã nhân viên";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(209, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Tên nhân viên";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(766, 72);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // gridViewChamCong
            // 
            this.gridViewChamCong.AllowUserToAddRows = false;
            this.gridViewChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewChamCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma,
            this.ht,
            this.tinhtrang});
            this.gridViewChamCong.Location = new System.Drawing.Point(6, 134);
            this.gridViewChamCong.Name = "gridViewChamCong";
            this.gridViewChamCong.Size = new System.Drawing.Size(917, 228);
            this.gridViewChamCong.TabIndex = 4;
            this.gridViewChamCong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewChamCong_CellContentClick);
            // 
            // ma
            // 
            this.ma.DataPropertyName = "MaNV";
            this.ma.HeaderText = "Mã Nhân Viên";
            this.ma.Name = "ma";
            this.ma.ReadOnly = true;
            // 
            // ht
            // 
            this.ht.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ht.DataPropertyName = "HoTen";
            this.ht.HeaderText = "Tên Nhân Viên";
            this.ht.Name = "ht";
            this.ht.ReadOnly = true;
            // 
            // tinhtrang
            // 
            this.tinhtrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tinhtrang.DataPropertyName = "TinhTrang";
            this.tinhtrang.HeaderText = "Tình Trạng";
            this.tinhtrang.Items.AddRange(new object[] {
            "Đi làm",
            "Nghỉ có phép",
            "Nghỉ không phép"});
            this.tinhtrang.Name = "tinhtrang";
            this.tinhtrang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tinhtrang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(766, 101);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(527, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Tình trạng";
            // 
            // lbTT
            // 
            this.lbTT.AutoSize = true;
            this.lbTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTT.Location = new System.Drawing.Point(601, 93);
            this.lbTT.Name = "lbTT";
            this.lbTT.Size = new System.Drawing.Size(90, 20);
            this.lbTT.TabIndex = 2;
            this.lbTT.Text = "Tình trạng";
            // 
            // ChiTietChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 450);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.gridViewChamCong);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbTT);
            this.Controls.Add(this.lbHT);
            this.Controls.Add(this.lbNV);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChiTietChamCong";
            this.Text = "ChiTietChamCong";
            this.Load += new System.EventHandler(this.ChiTietChamCong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChamCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChiTietChamCongBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateCong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.CheckBox ckBChamCong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbNV;
        private System.Windows.Forms.Label lbHT;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.DataGridView gridViewChamCong;
        private System.Windows.Forms.BindingSource tblChiTietChamCongBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ht;
        private System.Windows.Forms.DataGridViewComboBoxColumn tinhtrang;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbTT;

    }
}