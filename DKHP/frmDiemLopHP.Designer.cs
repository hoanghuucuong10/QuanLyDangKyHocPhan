﻿namespace DKHP
{
    partial class frmDiemLopHP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiemLopHP));
            this.pnMain = new System.Windows.Forms.Panel();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbIDLopHP = new System.Windows.Forms.TextBox();
            this.lbSoTC = new System.Windows.Forms.Label();
            this.lbHocKi = new System.Windows.Forms.Label();
            this.lbTenMonHoc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.diemLopHocPhanViewModelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDSinhVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoVaTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLopNienCheDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tK1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tK2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tK3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongKetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xepLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemLopHocPhanViewModelsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.dgvDiem);
            this.pnMain.Controls.Add(this.btnSearch);
            this.pnMain.Controls.Add(this.tbIDLopHP);
            this.pnMain.Controls.Add(this.lbSoTC);
            this.pnMain.Controls.Add(this.lbHocKi);
            this.pnMain.Controls.Add(this.lbTenMonHoc);
            this.pnMain.Controls.Add(this.label5);
            this.pnMain.Controls.Add(this.label4);
            this.pnMain.Controls.Add(this.label3);
            this.pnMain.Controls.Add(this.label2);
            this.pnMain.Controls.Add(this.label1);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1218, 534);
            this.pnMain.TabIndex = 0;
            // 
            // dgvDiem
            // 
            this.dgvDiem.AutoGenerateColumns = false;
            this.dgvDiem.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSinhVienDataGridViewTextBoxColumn,
            this.hoVaTenDataGridViewTextBoxColumn,
            this.tenLopNienCheDataGridViewTextBoxColumn,
            this.tenNhomDataGridViewTextBoxColumn,
            this.tK1DataGridViewTextBoxColumn,
            this.tK2DataGridViewTextBoxColumn,
            this.tK3DataGridViewTextBoxColumn,
            this.gKDataGridViewTextBoxColumn,
            this.cKDataGridViewTextBoxColumn,
            this.tongKetDataGridViewTextBoxColumn,
            this.xepLoaiDataGridViewTextBoxColumn});
            this.dgvDiem.DataSource = this.diemLopHocPhanViewModelsBindingSource;
            this.dgvDiem.Location = new System.Drawing.Point(30, 185);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.RowHeadersVisible = false;
            this.dgvDiem.Size = new System.Drawing.Size(1150, 304);
            this.dgvDiem.TabIndex = 36;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(564, 88);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(24, 24);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbIDLopHP
            // 
            this.tbIDLopHP.Location = new System.Drawing.Point(414, 92);
            this.tbIDLopHP.Name = "tbIDLopHP";
            this.tbIDLopHP.Size = new System.Drawing.Size(144, 20);
            this.tbIDLopHP.TabIndex = 4;
            // 
            // lbSoTC
            // 
            this.lbSoTC.AutoSize = true;
            this.lbSoTC.Location = new System.Drawing.Point(856, 100);
            this.lbSoTC.Name = "lbSoTC";
            this.lbSoTC.Size = new System.Drawing.Size(15, 13);
            this.lbSoTC.TabIndex = 3;
            this.lbSoTC.Text = "lb";
            // 
            // lbHocKi
            // 
            this.lbHocKi.AutoSize = true;
            this.lbHocKi.Location = new System.Drawing.Point(856, 129);
            this.lbHocKi.Name = "lbHocKi";
            this.lbHocKi.Size = new System.Drawing.Size(15, 13);
            this.lbHocKi.TabIndex = 3;
            this.lbHocKi.Text = "lb";
            // 
            // lbTenMonHoc
            // 
            this.lbTenMonHoc.AutoSize = true;
            this.lbTenMonHoc.Location = new System.Drawing.Point(411, 129);
            this.lbTenMonHoc.Name = "lbTenMonHoc";
            this.lbTenMonHoc.Size = new System.Drawing.Size(15, 13);
            this.lbTenMonHoc.TabIndex = 3;
            this.lbTenMonHoc.Text = "lb";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(789, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số Tín Chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(805, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Học Kỳ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Môn Học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Lớp Học Phần:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(494, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Điểm";
            // 
            // diemLopHocPhanViewModelsBindingSource
            // 
            this.diemLopHocPhanViewModelsBindingSource.DataSource = typeof(DKHP.ViewModels.DiemLopHocPhanViewModels);
            // 
            // iDSinhVienDataGridViewTextBoxColumn
            // 
            this.iDSinhVienDataGridViewTextBoxColumn.DataPropertyName = "ID_SinhVien";
            this.iDSinhVienDataGridViewTextBoxColumn.HeaderText = "Mã Số Sinh Viên";
            this.iDSinhVienDataGridViewTextBoxColumn.Name = "iDSinhVienDataGridViewTextBoxColumn";
            this.iDSinhVienDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDSinhVienDataGridViewTextBoxColumn.Width = 150;
            // 
            // hoVaTenDataGridViewTextBoxColumn
            // 
            this.hoVaTenDataGridViewTextBoxColumn.DataPropertyName = "HoVaTen";
            this.hoVaTenDataGridViewTextBoxColumn.HeaderText = "Họ Và Tên";
            this.hoVaTenDataGridViewTextBoxColumn.Name = "hoVaTenDataGridViewTextBoxColumn";
            this.hoVaTenDataGridViewTextBoxColumn.ReadOnly = true;
            this.hoVaTenDataGridViewTextBoxColumn.Width = 250;
            // 
            // tenLopNienCheDataGridViewTextBoxColumn
            // 
            this.tenLopNienCheDataGridViewTextBoxColumn.DataPropertyName = "TenLopNienChe";
            this.tenLopNienCheDataGridViewTextBoxColumn.HeaderText = "Lớp Niên Chế";
            this.tenLopNienCheDataGridViewTextBoxColumn.Name = "tenLopNienCheDataGridViewTextBoxColumn";
            this.tenLopNienCheDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenLopNienCheDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenNhomDataGridViewTextBoxColumn
            // 
            this.tenNhomDataGridViewTextBoxColumn.DataPropertyName = "TenNhom";
            this.tenNhomDataGridViewTextBoxColumn.HeaderText = "Nhóm Thực Hành";
            this.tenNhomDataGridViewTextBoxColumn.Name = "tenNhomDataGridViewTextBoxColumn";
            this.tenNhomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tK1DataGridViewTextBoxColumn
            // 
            this.tK1DataGridViewTextBoxColumn.DataPropertyName = "TK1";
            this.tK1DataGridViewTextBoxColumn.HeaderText = "TK1";
            this.tK1DataGridViewTextBoxColumn.Name = "tK1DataGridViewTextBoxColumn";
            this.tK1DataGridViewTextBoxColumn.Width = 70;
            // 
            // tK2DataGridViewTextBoxColumn
            // 
            this.tK2DataGridViewTextBoxColumn.DataPropertyName = "TK2";
            this.tK2DataGridViewTextBoxColumn.HeaderText = "TK2";
            this.tK2DataGridViewTextBoxColumn.Name = "tK2DataGridViewTextBoxColumn";
            this.tK2DataGridViewTextBoxColumn.Width = 70;
            // 
            // tK3DataGridViewTextBoxColumn
            // 
            this.tK3DataGridViewTextBoxColumn.DataPropertyName = "TK3";
            this.tK3DataGridViewTextBoxColumn.HeaderText = "TK3";
            this.tK3DataGridViewTextBoxColumn.Name = "tK3DataGridViewTextBoxColumn";
            this.tK3DataGridViewTextBoxColumn.Width = 70;
            // 
            // gKDataGridViewTextBoxColumn
            // 
            this.gKDataGridViewTextBoxColumn.DataPropertyName = "GK";
            this.gKDataGridViewTextBoxColumn.HeaderText = "GK";
            this.gKDataGridViewTextBoxColumn.Name = "gKDataGridViewTextBoxColumn";
            this.gKDataGridViewTextBoxColumn.Width = 70;
            // 
            // cKDataGridViewTextBoxColumn
            // 
            this.cKDataGridViewTextBoxColumn.DataPropertyName = "CK";
            this.cKDataGridViewTextBoxColumn.HeaderText = "CK";
            this.cKDataGridViewTextBoxColumn.Name = "cKDataGridViewTextBoxColumn";
            this.cKDataGridViewTextBoxColumn.Width = 70;
            // 
            // tongKetDataGridViewTextBoxColumn
            // 
            this.tongKetDataGridViewTextBoxColumn.DataPropertyName = "TongKet";
            this.tongKetDataGridViewTextBoxColumn.HeaderText = "Tổng Kết";
            this.tongKetDataGridViewTextBoxColumn.Name = "tongKetDataGridViewTextBoxColumn";
            this.tongKetDataGridViewTextBoxColumn.ReadOnly = true;
            this.tongKetDataGridViewTextBoxColumn.Width = 70;
            // 
            // xepLoaiDataGridViewTextBoxColumn
            // 
            this.xepLoaiDataGridViewTextBoxColumn.DataPropertyName = "XepLoai";
            this.xepLoaiDataGridViewTextBoxColumn.HeaderText = "Xếp Loại";
            this.xepLoaiDataGridViewTextBoxColumn.Name = "xepLoaiDataGridViewTextBoxColumn";
            this.xepLoaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.xepLoaiDataGridViewTextBoxColumn.Width = 77;
            // 
            // frmDiemLopHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 534);
            this.Controls.Add(this.pnMain);
            this.Name = "frmDiemLopHP";
            this.Text = "frmDiemLopHP";
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemLopHocPhanViewModelsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIDLopHP;
        private System.Windows.Forms.Label lbSoTC;
        private System.Windows.Forms.Label lbHocKi;
        private System.Windows.Forms.Label lbTenMonHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.BindingSource diemLopHocPhanViewModelsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSinhVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoVaTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLopNienCheDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tK1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tK2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tK3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongKetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xepLoaiDataGridViewTextBoxColumn;
    }
}