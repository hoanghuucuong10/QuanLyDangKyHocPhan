namespace DKHP
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbIDLopHP = new System.Windows.Forms.TextBox();
            this.lbTenMonHoc = new System.Windows.Forms.Label();
            this.lbGiangVien = new System.Windows.Forms.Label();
            this.lbSoTC = new System.Windows.Forms.Label();
            this.lbHocKy = new System.Windows.Forms.Label();
            this.lbMonHoc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printPreView = new System.Windows.Forms.PrintPreviewDialog();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
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
            this.diemLopHocPhanViewModelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemLopHocPhanViewModelsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.Transparent;
            this.pnMain.BackgroundImage = global::DKHP.Properties.Resources.istockphoto_995719694_612x612;
            this.pnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMain.Controls.Add(this.btnLuu);
            this.pnMain.Controls.Add(this.btnHuy);
            this.pnMain.Controls.Add(this.btnPrint);
            this.pnMain.Controls.Add(this.dgvDiem);
            this.pnMain.Controls.Add(this.btnSearch);
            this.pnMain.Controls.Add(this.tbIDLopHP);
            this.pnMain.Controls.Add(this.lbTenMonHoc);
            this.pnMain.Controls.Add(this.lbGiangVien);
            this.pnMain.Controls.Add(this.lbSoTC);
            this.pnMain.Controls.Add(this.lbHocKy);
            this.pnMain.Controls.Add(this.lbMonHoc);
            this.pnMain.Controls.Add(this.label2);
            this.pnMain.Controls.Add(this.label1);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1218, 534);
            this.pnMain.TabIndex = 0;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(963, 476);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(80, 45);
            this.btnLuu.TabIndex = 56;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Visible = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(850, 477);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(80, 45);
            this.btnHuy.TabIndex = 57;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.BackgroundImage = global::DKHP.Properties.Resources.printer;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrint.Location = new System.Drawing.Point(1073, 477);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 45);
            this.btnPrint.TabIndex = 55;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dgvDiem
            // 
            this.dgvDiem.AllowUserToAddRows = false;
            this.dgvDiem.AllowUserToDeleteRows = false;
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
            this.dgvDiem.Size = new System.Drawing.Size(1150, 279);
            this.dgvDiem.TabIndex = 36;
            this.dgvDiem.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvDiem_CellBeginEdit);
            this.dgvDiem.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiem_CellEndEdit);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(644, 80);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(24, 24);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbIDLopHP
            // 
            this.tbIDLopHP.Location = new System.Drawing.Point(494, 82);
            this.tbIDLopHP.Name = "tbIDLopHP";
            this.tbIDLopHP.Size = new System.Drawing.Size(144, 20);
            this.tbIDLopHP.TabIndex = 4;
            // 
            // lbTenMonHoc
            // 
            this.lbTenMonHoc.AutoSize = true;
            this.lbTenMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenMonHoc.Location = new System.Drawing.Point(500, 145);
            this.lbTenMonHoc.Name = "lbTenMonHoc";
            this.lbTenMonHoc.Size = new System.Drawing.Size(0, 13);
            this.lbTenMonHoc.TabIndex = 3;
            // 
            // lbGiangVien
            // 
            this.lbGiangVien.AutoSize = true;
            this.lbGiangVien.BackColor = System.Drawing.Color.Transparent;
            this.lbGiangVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiangVien.Location = new System.Drawing.Point(432, 117);
            this.lbGiangVien.Name = "lbGiangVien";
            this.lbGiangVien.Size = new System.Drawing.Size(62, 13);
            this.lbGiangVien.TabIndex = 2;
            this.lbGiangVien.Text = "Giảng Viên:";
            // 
            // lbSoTC
            // 
            this.lbSoTC.AutoSize = true;
            this.lbSoTC.BackColor = System.Drawing.Color.Transparent;
            this.lbSoTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTC.Location = new System.Drawing.Point(706, 117);
            this.lbSoTC.Name = "lbSoTC";
            this.lbSoTC.Size = new System.Drawing.Size(61, 13);
            this.lbSoTC.TabIndex = 2;
            this.lbSoTC.Text = "Số Tín Chỉ:";
            // 
            // lbHocKy
            // 
            this.lbHocKy.AutoSize = true;
            this.lbHocKy.BackColor = System.Drawing.Color.Transparent;
            this.lbHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHocKy.Location = new System.Drawing.Point(706, 145);
            this.lbHocKy.Name = "lbHocKy";
            this.lbHocKy.Size = new System.Drawing.Size(45, 13);
            this.lbHocKy.TabIndex = 2;
            this.lbHocKy.Text = "Học Kỳ:";
            // 
            // lbMonHoc
            // 
            this.lbMonHoc.AutoSize = true;
            this.lbMonHoc.BackColor = System.Drawing.Color.Transparent;
            this.lbMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonHoc.Location = new System.Drawing.Point(418, 145);
            this.lbMonHoc.Name = "lbMonHoc";
            this.lbMonHoc.Size = new System.Drawing.Size(76, 13);
            this.lbMonHoc.TabIndex = 2;
            this.lbMonHoc.Text = "Tên Môn Học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(397, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Lớp Học Phần:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(481, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Điểm";
            // 
            // printPreView
            // 
            this.printPreView.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreView.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreView.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreView.Enabled = true;
            this.printPreView.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreView.Icon")));
            this.printPreView.Name = "printPreView";
            this.printPreView.Visible = false;
            // 
            // printDoc
            // 
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_PrintPage);
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
            // diemLopHocPhanViewModelsBindingSource
            // 
            this.diemLopHocPhanViewModelsBindingSource.DataSource = typeof(DKHP.ViewModels.DiemLopHocPhanViewModels);
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
        private System.Windows.Forms.Label lbHocKy;
        private System.Windows.Forms.Label lbMonHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIDLopHP;
        private System.Windows.Forms.Label lbTenMonHoc;
        private System.Windows.Forms.Label lbSoTC;
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
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreView;
        private System.Drawing.Printing.PrintDocument printDoc;
        private System.Windows.Forms.Label lbGiangVien;
    }
}