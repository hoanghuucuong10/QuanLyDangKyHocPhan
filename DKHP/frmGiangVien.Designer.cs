﻿namespace DKHP
{
    partial class frmGiangVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTrinhDo = new System.Windows.Forms.TextBox();
            this.tbxTen = new System.Windows.Forms.TextBox();
            this.tbxMK = new System.Windows.Forms.TextBox();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDGiangVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoVaTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trinhDoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhAnhDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.matKhauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giangVienViewModelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbTenSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienViewModelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnChonAnh);
            this.groupBox1.Controls.Add(this.btnHide);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbxMail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxAddress);
            this.groupBox1.Controls.Add(this.tbxPhone);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbTrinhDo);
            this.groupBox1.Controls.Add(this.tbxTen);
            this.groupBox1.Controls.Add(this.tbxMK);
            this.groupBox1.Controls.Add(this.tbxID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 483);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Giảng Viên";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.Image = global::DKHP.Properties.Resources.contract;
            this.btnSua.Location = new System.Drawing.Point(177, 419);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 39);
            this.btnSua.TabIndex = 29;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::DKHP.Properties.Resources.book;
            this.pictureBox1.Location = new System.Drawing.Point(84, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.Image = global::DKHP.Properties.Resources.add;
            this.btnThem.Location = new System.Drawing.Point(23, 419);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 39);
            this.btnThem.TabIndex = 30;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(98, 141);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(75, 23);
            this.btnChonAnh.TabIndex = 31;
            this.btnChonAnh.Text = "Chọn Ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.White;
            this.btnHide.BackgroundImage = global::DKHP.Properties.Resources.hide__2_;
            this.btnHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHide.Location = new System.Drawing.Point(228, 201);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(26, 20);
            this.btnHide.TabIndex = 29;
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.Image = global::DKHP.Properties.Resources.check_symbol;
            this.btnLuu.Location = new System.Drawing.Point(180, 419);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 39);
            this.btnLuu.TabIndex = 28;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.Image = global::DKHP.Properties.Resources.clear;
            this.btnHuy.Location = new System.Drawing.Point(21, 419);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 39);
            this.btnHuy.TabIndex = 27;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Trình Độ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Email:";
            // 
            // tbxMail
            // 
            this.tbxMail.Location = new System.Drawing.Point(113, 372);
            this.tbxMail.Name = "tbxMail";
            this.tbxMail.Size = new System.Drawing.Size(142, 20);
            this.tbxMail.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Địa Chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Số Điện Thoại:";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(113, 338);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(142, 20);
            this.tbxAddress.TabIndex = 18;
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(113, 304);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(142, 20);
            this.tbxPhone.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Họ Và Tên:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Mật Khẩu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Mã Giảng Viên:";
            // 
            // tbTrinhDo
            // 
            this.tbTrinhDo.Location = new System.Drawing.Point(112, 270);
            this.tbTrinhDo.Name = "tbTrinhDo";
            this.tbTrinhDo.Size = new System.Drawing.Size(110, 20);
            this.tbTrinhDo.TabIndex = 14;
            // 
            // tbxTen
            // 
            this.tbxTen.Location = new System.Drawing.Point(113, 236);
            this.tbxTen.Name = "tbxTen";
            this.tbxTen.Size = new System.Drawing.Size(142, 20);
            this.tbxTen.TabIndex = 14;
            // 
            // tbxMK
            // 
            this.tbxMK.Location = new System.Drawing.Point(113, 202);
            this.tbxMK.Name = "tbxMK";
            this.tbxMK.Size = new System.Drawing.Size(109, 20);
            this.tbxMK.TabIndex = 15;
            this.tbxMK.UseSystemPasswordChar = true;
            this.tbxMK.TextChanged += new System.EventHandler(this.tbxMK_TextChanged);
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(113, 168);
            this.tbxID.Name = "tbxID";
            this.tbxID.ReadOnly = true;
            this.tbxID.Size = new System.Drawing.Size(121, 20);
            this.tbxID.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.tbTenSearch);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tbxSearch);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(314, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(892, 483);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Giảng Viên";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::DKHP.Properties.Resources.search__1_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(464, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDGiangVienDataGridViewTextBoxColumn,
            this.hoVaTenDataGridViewTextBoxColumn,
            this.trinhDoDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.hinhAnhDataGridViewImageColumn,
            this.matKhauDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.giangVienViewModelsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(847, 354);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // iDGiangVienDataGridViewTextBoxColumn
            // 
            this.iDGiangVienDataGridViewTextBoxColumn.DataPropertyName = "ID_GiangVien";
            this.iDGiangVienDataGridViewTextBoxColumn.HeaderText = "Mã Giảng Viên";
            this.iDGiangVienDataGridViewTextBoxColumn.Name = "iDGiangVienDataGridViewTextBoxColumn";
            this.iDGiangVienDataGridViewTextBoxColumn.Width = 102;
            // 
            // hoVaTenDataGridViewTextBoxColumn
            // 
            this.hoVaTenDataGridViewTextBoxColumn.DataPropertyName = "HoVaTen";
            this.hoVaTenDataGridViewTextBoxColumn.HeaderText = "Họ Và Tên";
            this.hoVaTenDataGridViewTextBoxColumn.Name = "hoVaTenDataGridViewTextBoxColumn";
            this.hoVaTenDataGridViewTextBoxColumn.Width = 84;
            // 
            // trinhDoDataGridViewTextBoxColumn
            // 
            this.trinhDoDataGridViewTextBoxColumn.DataPropertyName = "TrinhDo";
            this.trinhDoDataGridViewTextBoxColumn.HeaderText = "Trình Độ";
            this.trinhDoDataGridViewTextBoxColumn.Name = "trinhDoDataGridViewTextBoxColumn";
            this.trinhDoDataGridViewTextBoxColumn.Width = 73;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.Width = 66;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "Số Điện Thoại";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.Width = 57;
            // 
            // hinhAnhDataGridViewImageColumn
            // 
            this.hinhAnhDataGridViewImageColumn.DataPropertyName = "HinhAnh";
            this.hinhAnhDataGridViewImageColumn.HeaderText = "HinhAnh";
            this.hinhAnhDataGridViewImageColumn.Name = "hinhAnhDataGridViewImageColumn";
            this.hinhAnhDataGridViewImageColumn.Visible = false;
            this.hinhAnhDataGridViewImageColumn.Width = 54;
            // 
            // matKhauDataGridViewTextBoxColumn
            // 
            this.matKhauDataGridViewTextBoxColumn.DataPropertyName = "MatKhau";
            this.matKhauDataGridViewTextBoxColumn.HeaderText = "MatKhau";
            this.matKhauDataGridViewTextBoxColumn.Name = "matKhauDataGridViewTextBoxColumn";
            this.matKhauDataGridViewTextBoxColumn.Visible = false;
            this.matKhauDataGridViewTextBoxColumn.Width = 75;
            // 
            // giangVienViewModelsBindingSource
            // 
            this.giangVienViewModelsBindingSource.DataSource = typeof(DKHP.ViewModels.GiangVienViewModels);
            // 
            // tbTenSearch
            // 
            this.tbTenSearch.Location = new System.Drawing.Point(325, 72);
            this.tbTenSearch.Name = "tbTenSearch";
            this.tbTenSearch.Size = new System.Drawing.Size(133, 20);
            this.tbTenSearch.TabIndex = 10;
            this.tbTenSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(262, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Họ Và Tên:";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(115, 72);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(133, 20);
            this.tbxSearch.TabIndex = 10;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã Giảng Viên:";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DKHP.Properties.Resources.istockphoto_995719694_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1218, 507);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGiangVien";
            this.Text = "frmGiangVien";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienViewModelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxTen;
        private System.Windows.Forms.TextBox tbxMK;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTrinhDo;
        private System.Windows.Forms.TextBox tbTenSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDGiangVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoVaTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trinhDoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn hinhAnhDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhauDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource giangVienViewModelsBindingSource;
    }
}