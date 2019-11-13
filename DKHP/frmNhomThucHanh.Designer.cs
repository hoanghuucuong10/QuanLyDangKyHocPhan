namespace DKHP
{
    partial class frmNhomThucHanh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbMaLHP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.numNhom = new System.Windows.Forms.NumericUpDown();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbIDTH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numSoTiet = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.lichHocTHViewModelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbGiangVien = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHuyLuuLichHoc = new System.Windows.Forms.Button();
            this.btnLuuLichHoc = new System.Windows.Forms.Button();
            this.btnXoaLich = new System.Windows.Forms.Button();
            this.btnSuaLich = new System.Windows.Forms.Button();
            this.btnThemLich = new System.Windows.Forms.Button();
            this.cbNgayHoc = new System.Windows.Forms.ComboBox();
            this.cbTietHoc = new System.Windows.Forms.ComboBox();
            this.cbPhong = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ngayHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tietHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPhongHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDLichHocNhomTHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDNhomThucHanhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPhongHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lichHocTHViewModelsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMaLHP
            // 
            this.tbMaLHP.Location = new System.Drawing.Point(166, 83);
            this.tbMaLHP.Name = "tbMaLHP";
            this.tbMaLHP.ReadOnly = true;
            this.tbMaLHP.Size = new System.Drawing.Size(114, 20);
            this.tbMaLHP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Lớp Học Phần:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên Nhóm:";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(113, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(341, 29);
            this.lbTitle.TabIndex = 27;
            this.lbTitle.Text = "Thông Tin Nhóm Thực Hành";
            // 
            // numNhom
            // 
            this.numNhom.Location = new System.Drawing.Point(166, 114);
            this.numNhom.Name = "numNhom";
            this.numNhom.Size = new System.Drawing.Size(47, 20);
            this.numNhom.TabIndex = 30;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = global::DKHP.Properties.Resources.check_symbol;
            this.btnLuu.Location = new System.Drawing.Point(370, 431);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(126, 43);
            this.btnLuu.TabIndex = 28;
            this.btnLuu.Text = "Xác Nhận";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::DKHP.Properties.Resources.delete;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(221, 431);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 43);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::DKHP.Properties.Resources.clear;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(72, 431);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(82, 43);
            this.btnThoat.TabIndex = 29;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(384, 146);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(118, 20);
            this.dateTimePicker2.TabIndex = 33;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(166, 145);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(118, 20);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(300, 151);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Ngày Kết Thúc:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(87, 152);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Ngày Bắt Đầu:";
            // 
            // tbIDTH
            // 
            this.tbIDTH.Location = new System.Drawing.Point(166, 57);
            this.tbIDTH.Name = "tbIDTH";
            this.tbIDTH.ReadOnly = true;
            this.tbIDTH.Size = new System.Drawing.Size(114, 20);
            this.tbIDTH.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Nhóm Thực Hành:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tổng số tiết:";
            // 
            // numSoTiet
            // 
            this.numSoTiet.Location = new System.Drawing.Point(313, 114);
            this.numSoTiet.Name = "numSoTiet";
            this.numSoTiet.Size = new System.Drawing.Size(47, 20);
            this.numSoTiet.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Lịch Học:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ngayHocDataGridViewTextBoxColumn,
            this.tietHocDataGridViewTextBoxColumn,
            this.tenPhongHocDataGridViewTextBoxColumn,
            this.iDLichHocNhomTHDataGridViewTextBoxColumn,
            this.iDNhomThucHanhDataGridViewTextBoxColumn,
            this.iDPhongHocDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.lichHocTHViewModelsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView3.Location = new System.Drawing.Point(42, 208);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(242, 139);
            this.dataGridView3.TabIndex = 35;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // lichHocTHViewModelsBindingSource
            // 
            this.lichHocTHViewModelsBindingSource.DataSource = typeof(DKHP.ViewModels.LichHocTHViewModels);
            // 
            // cbGiangVien
            // 
            this.cbGiangVien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbGiangVien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbGiangVien.FormattingEnabled = true;
            this.cbGiangVien.Location = new System.Drawing.Point(370, 82);
            this.cbGiangVien.Name = "cbGiangVien";
            this.cbGiangVien.Size = new System.Drawing.Size(145, 21);
            this.cbGiangVien.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Giảng Viên:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuyLuuLichHoc);
            this.groupBox1.Controls.Add(this.btnLuuLichHoc);
            this.groupBox1.Controls.Add(this.btnXoaLich);
            this.groupBox1.Controls.Add(this.btnSuaLich);
            this.groupBox1.Controls.Add(this.btnThemLich);
            this.groupBox1.Controls.Add(this.cbNgayHoc);
            this.groupBox1.Controls.Add(this.cbTietHoc);
            this.groupBox1.Controls.Add(this.cbPhong);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(330, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 145);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lịch Học";
            // 
            // btnHuyLuuLichHoc
            // 
            this.btnHuyLuuLichHoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHuyLuuLichHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyLuuLichHoc.Location = new System.Drawing.Point(6, 113);
            this.btnHuyLuuLichHoc.Name = "btnHuyLuuLichHoc";
            this.btnHuyLuuLichHoc.Size = new System.Drawing.Size(46, 23);
            this.btnHuyLuuLichHoc.TabIndex = 19;
            this.btnHuyLuuLichHoc.Text = "Hủy";
            this.btnHuyLuuLichHoc.UseVisualStyleBackColor = true;
            this.btnHuyLuuLichHoc.Visible = false;
            this.btnHuyLuuLichHoc.Click += new System.EventHandler(this.btnHuyLuuLichHoc_Click);
            // 
            // btnLuuLichHoc
            // 
            this.btnLuuLichHoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLuuLichHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuLichHoc.Location = new System.Drawing.Point(95, 113);
            this.btnLuuLichHoc.Name = "btnLuuLichHoc";
            this.btnLuuLichHoc.Size = new System.Drawing.Size(83, 23);
            this.btnLuuLichHoc.TabIndex = 19;
            this.btnLuuLichHoc.Text = "Xác Nhận";
            this.btnLuuLichHoc.UseVisualStyleBackColor = true;
            this.btnLuuLichHoc.Visible = false;
            this.btnLuuLichHoc.Click += new System.EventHandler(this.btnLuuLichHoc_Click);
            // 
            // btnXoaLich
            // 
            this.btnXoaLich.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLich.Location = new System.Drawing.Point(6, 113);
            this.btnXoaLich.Name = "btnXoaLich";
            this.btnXoaLich.Size = new System.Drawing.Size(46, 23);
            this.btnXoaLich.TabIndex = 19;
            this.btnXoaLich.Text = "Xóa";
            this.btnXoaLich.UseVisualStyleBackColor = true;
            this.btnXoaLich.Click += new System.EventHandler(this.btnXoaLich_Click);
            // 
            // btnSuaLich
            // 
            this.btnSuaLich.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuaLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLich.Location = new System.Drawing.Point(72, 113);
            this.btnSuaLich.Name = "btnSuaLich";
            this.btnSuaLich.Size = new System.Drawing.Size(46, 23);
            this.btnSuaLich.TabIndex = 19;
            this.btnSuaLich.Text = "Sửa";
            this.btnSuaLich.UseVisualStyleBackColor = true;
            this.btnSuaLich.Click += new System.EventHandler(this.btnSuaLich_Click);
            // 
            // btnThemLich
            // 
            this.btnThemLich.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLich.Location = new System.Drawing.Point(132, 113);
            this.btnThemLich.Name = "btnThemLich";
            this.btnThemLich.Size = new System.Drawing.Size(46, 23);
            this.btnThemLich.TabIndex = 19;
            this.btnThemLich.Text = "Thêm";
            this.btnThemLich.UseVisualStyleBackColor = true;
            this.btnThemLich.Click += new System.EventHandler(this.btnThemLich_Click);
            // 
            // cbNgayHoc
            // 
            this.cbNgayHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNgayHoc.FormattingEnabled = true;
            this.cbNgayHoc.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbNgayHoc.Location = new System.Drawing.Point(58, 21);
            this.cbNgayHoc.Name = "cbNgayHoc";
            this.cbNgayHoc.Size = new System.Drawing.Size(108, 21);
            this.cbNgayHoc.TabIndex = 16;
            // 
            // cbTietHoc
            // 
            this.cbTietHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTietHoc.FormattingEnabled = true;
            this.cbTietHoc.Location = new System.Drawing.Point(58, 51);
            this.cbTietHoc.Name = "cbTietHoc";
            this.cbTietHoc.Size = new System.Drawing.Size(108, 21);
            this.cbTietHoc.TabIndex = 16;
            // 
            // cbPhong
            // 
            this.cbPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhong.FormattingEnabled = true;
            this.cbPhong.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbPhong.Location = new System.Drawing.Point(58, 81);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(108, 21);
            this.cbPhong.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 89);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "Phòng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Tiết Học:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Ngày Học:";
            // 
            // ngayHocDataGridViewTextBoxColumn
            // 
            this.ngayHocDataGridViewTextBoxColumn.DataPropertyName = "NgayHoc";
            this.ngayHocDataGridViewTextBoxColumn.HeaderText = "Ngày Học";
            this.ngayHocDataGridViewTextBoxColumn.Name = "ngayHocDataGridViewTextBoxColumn";
            this.ngayHocDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayHocDataGridViewTextBoxColumn.Width = 80;
            // 
            // tietHocDataGridViewTextBoxColumn
            // 
            this.tietHocDataGridViewTextBoxColumn.DataPropertyName = "TietHoc";
            this.tietHocDataGridViewTextBoxColumn.HeaderText = "Tiết Học";
            this.tietHocDataGridViewTextBoxColumn.Name = "tietHocDataGridViewTextBoxColumn";
            this.tietHocDataGridViewTextBoxColumn.ReadOnly = true;
            this.tietHocDataGridViewTextBoxColumn.Width = 73;
            // 
            // tenPhongHocDataGridViewTextBoxColumn
            // 
            this.tenPhongHocDataGridViewTextBoxColumn.DataPropertyName = "TenPhongHoc";
            this.tenPhongHocDataGridViewTextBoxColumn.HeaderText = "Phòng Học";
            this.tenPhongHocDataGridViewTextBoxColumn.Name = "tenPhongHocDataGridViewTextBoxColumn";
            this.tenPhongHocDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenPhongHocDataGridViewTextBoxColumn.Width = 86;
            // 
            // iDLichHocNhomTHDataGridViewTextBoxColumn
            // 
            this.iDLichHocNhomTHDataGridViewTextBoxColumn.DataPropertyName = "ID_LichHoc_NhomTH";
            this.iDLichHocNhomTHDataGridViewTextBoxColumn.HeaderText = "ID_LichHoc_NhomTH";
            this.iDLichHocNhomTHDataGridViewTextBoxColumn.Name = "iDLichHocNhomTHDataGridViewTextBoxColumn";
            this.iDLichHocNhomTHDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDLichHocNhomTHDataGridViewTextBoxColumn.Width = 138;
            // 
            // iDNhomThucHanhDataGridViewTextBoxColumn
            // 
            this.iDNhomThucHanhDataGridViewTextBoxColumn.DataPropertyName = "ID_NhomThucHanh";
            this.iDNhomThucHanhDataGridViewTextBoxColumn.HeaderText = "ID_NhomThucHanh";
            this.iDNhomThucHanhDataGridViewTextBoxColumn.Name = "iDNhomThucHanhDataGridViewTextBoxColumn";
            this.iDNhomThucHanhDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDNhomThucHanhDataGridViewTextBoxColumn.Visible = false;
            this.iDNhomThucHanhDataGridViewTextBoxColumn.Width = 128;
            // 
            // iDPhongHocDataGridViewTextBoxColumn
            // 
            this.iDPhongHocDataGridViewTextBoxColumn.DataPropertyName = "ID_PhongHoc";
            this.iDPhongHocDataGridViewTextBoxColumn.HeaderText = "ID_PhongHoc";
            this.iDPhongHocDataGridViewTextBoxColumn.Name = "iDPhongHocDataGridViewTextBoxColumn";
            this.iDPhongHocDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPhongHocDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmNhomThucHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 516);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbGiangVien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.numSoTiet);
            this.Controls.Add(this.numNhom);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIDTH);
            this.Controls.Add(this.tbMaLHP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmNhomThucHanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmNhomThucHanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lichHocTHViewModelsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMaLHP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.NumericUpDown numNhom;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbIDTH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numSoTiet;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ComboBox cbGiangVien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoaLich;
        private System.Windows.Forms.Button btnSuaLich;
        private System.Windows.Forms.Button btnThemLich;
        private System.Windows.Forms.ComboBox cbNgayHoc;
        private System.Windows.Forms.ComboBox cbTietHoc;
        private System.Windows.Forms.ComboBox cbPhong;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnHuyLuuLichHoc;
        private System.Windows.Forms.Button btnLuuLichHoc;
        private System.Windows.Forms.BindingSource lichHocTHViewModelsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tietHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhongHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLichHocNhomTHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNhomThucHanhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPhongHocDataGridViewTextBoxColumn;
    }
}