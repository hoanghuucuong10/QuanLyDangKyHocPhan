namespace DKHP
{
    partial class frmDiemLopHocPhanGV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiemLopHocPhanGV));
            this.pnMain = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTenMH = new System.Windows.Forms.Label();
            this.lbSoTC = new System.Windows.Forms.Label();
            this.lbHocKy = new System.Windows.Forms.Label();
            this.lbIDLopHP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtIDLopHP = new System.Windows.Forms.TextBox();
            this.treeLopHocPhan = new System.Windows.Forms.TreeView();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
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
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.printPreView = new System.Windows.Forms.PrintPreviewDialog();
            this.pnMain.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diemLopHocPhanViewModelsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.AutoScroll = true;
            this.pnMain.BackColor = System.Drawing.Color.White;
            this.pnMain.BackgroundImage = global::DKHP.Properties.Resources.istockphoto_995719694_612x612;
            this.pnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMain.Controls.Add(this.groupBox2);
            this.pnMain.Controls.Add(this.groupBox1);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1202, 468);
            this.pnMain.TabIndex = 0;
            this.pnMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMain_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbTenMH);
            this.groupBox2.Controls.Add(this.lbSoTC);
            this.groupBox2.Controls.Add(this.lbHocKy);
            this.groupBox2.Controls.Add(this.lbIDLopHP);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dgvDiem);
            this.groupBox2.Location = new System.Drawing.Point(476, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1192, 506);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(924, 449);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(80, 45);
            this.btnLuu.TabIndex = 52;
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
            this.btnHuy.Location = new System.Drawing.Point(811, 450);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(80, 45);
            this.btnHuy.TabIndex = 53;
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
            this.btnPrint.Location = new System.Drawing.Point(1034, 450);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 45);
            this.btnPrint.TabIndex = 51;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(761, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 24);
            this.label5.TabIndex = 48;
            this.label5.Text = "Số Tín Chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(792, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 49;
            this.label4.Text = "Học Kỳ:";
            // 
            // lbTenMH
            // 
            this.lbTenMH.AutoSize = true;
            this.lbTenMH.BackColor = System.Drawing.Color.Transparent;
            this.lbTenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenMH.Location = new System.Drawing.Point(454, 95);
            this.lbTenMH.Name = "lbTenMH";
            this.lbTenMH.Size = new System.Drawing.Size(0, 24);
            this.lbTenMH.TabIndex = 47;
            // 
            // lbSoTC
            // 
            this.lbSoTC.AutoSize = true;
            this.lbSoTC.BackColor = System.Drawing.Color.Transparent;
            this.lbSoTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTC.Location = new System.Drawing.Point(878, 66);
            this.lbSoTC.Name = "lbSoTC";
            this.lbSoTC.Size = new System.Drawing.Size(0, 24);
            this.lbSoTC.TabIndex = 47;
            // 
            // lbHocKy
            // 
            this.lbHocKy.AutoSize = true;
            this.lbHocKy.BackColor = System.Drawing.Color.Transparent;
            this.lbHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHocKy.Location = new System.Drawing.Point(878, 95);
            this.lbHocKy.Name = "lbHocKy";
            this.lbHocKy.Size = new System.Drawing.Size(0, 24);
            this.lbHocKy.TabIndex = 47;
            // 
            // lbIDLopHP
            // 
            this.lbIDLopHP.AutoSize = true;
            this.lbIDLopHP.BackColor = System.Drawing.Color.Transparent;
            this.lbIDLopHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDLopHP.Location = new System.Drawing.Point(454, 66);
            this.lbIDLopHP.Name = "lbIDLopHP";
            this.lbIDLopHP.Size = new System.Drawing.Size(0, 24);
            this.lbIDLopHP.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 24);
            this.label3.TabIndex = 50;
            this.label3.Text = "Tên Môn Học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 24);
            this.label2.TabIndex = 47;
            this.label2.Text = "Mã Lớp Học Phần:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(476, -4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(339, 49);
            this.label6.TabIndex = 46;
            this.label6.Text = "Danh Sách Điểm";
            // 
            // dgvDiem
            // 
            this.dgvDiem.AllowUserToAddRows = false;
            this.dgvDiem.AllowUserToDeleteRows = false;
            this.dgvDiem.AllowUserToResizeColumns = false;
            this.dgvDiem.AllowUserToResizeRows = false;
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
            this.dgvDiem.Location = new System.Drawing.Point(20, 134);
            this.dgvDiem.MultiSelect = false;
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.RowHeadersVisible = false;
            this.dgvDiem.Size = new System.Drawing.Size(1150, 309);
            this.dgvDiem.TabIndex = 45;
            this.dgvDiem.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvDiem_CellBeginEdit);
            this.dgvDiem.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiem_CellEndEdit);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtIDLopHP);
            this.groupBox1.Controls.Add(this.treeLopHocPhan);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 501);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lớp Học Phần";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(358, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(65, 30);
            this.btnSearch.TabIndex = 40;
            this.btnSearch.Text = "Xem";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtIDLopHP
            // 
            this.txtIDLopHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDLopHP.ForeColor = System.Drawing.Color.Silver;
            this.txtIDLopHP.Location = new System.Drawing.Point(28, 31);
            this.txtIDLopHP.Name = "txtIDLopHP";
            this.txtIDLopHP.Size = new System.Drawing.Size(324, 29);
            this.txtIDLopHP.TabIndex = 39;
            this.txtIDLopHP.Text = "Mã Lớp Học Phần";
            this.txtIDLopHP.Enter += new System.EventHandler(this.txtIDLopHP_Enter);
            this.txtIDLopHP.Leave += new System.EventHandler(this.txtIDLopHP_Leave);
            // 
            // treeLopHocPhan
            // 
            this.treeLopHocPhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeLopHocPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeLopHocPhan.ImageKey = "next (1).png";
            this.treeLopHocPhan.ImageList = this.imgList;
            this.treeLopHocPhan.Location = new System.Drawing.Point(28, 66);
            this.treeLopHocPhan.Name = "treeLopHocPhan";
            this.treeLopHocPhan.SelectedImageIndex = 0;
            this.treeLopHocPhan.ShowLines = false;
            this.treeLopHocPhan.Size = new System.Drawing.Size(395, 419);
            this.treeLopHocPhan.TabIndex = 38;
            this.treeLopHocPhan.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeLopHocPhan_AfterSelect);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "next (2).png");
            this.imgList.Images.SetKeyName(1, "next (1).png");
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
            this.tenLopNienCheDataGridViewTextBoxColumn.HeaderText = "Lớp";
            this.tenLopNienCheDataGridViewTextBoxColumn.Name = "tenLopNienCheDataGridViewTextBoxColumn";
            this.tenLopNienCheDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenLopNienCheDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenNhomDataGridViewTextBoxColumn
            // 
            this.tenNhomDataGridViewTextBoxColumn.DataPropertyName = "TenNhom";
            this.tenNhomDataGridViewTextBoxColumn.HeaderText = "Nhóm";
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
            // printDoc
            // 
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_PrintPage);
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
            // frmDiemLopHocPhanGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1202, 468);
            this.Controls.Add(this.pnMain);
            this.Name = "frmDiemLopHocPhanGV";
            this.Text = "DiemLopHocPhanGV";
            this.pnMain.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diemLopHocPhanViewModelsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.TreeView treeLopHocPhan;
        private System.Windows.Forms.Label lbIDLopHP;
        private System.Windows.Forms.Label lbHocKy;
        private System.Windows.Forms.BindingSource diemLopHocPhanViewModelsBindingSource;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvDiem;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbTenMH;
        private System.Windows.Forms.Label lbSoTC;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtIDLopHP;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDoc;
        private System.Windows.Forms.PrintPreviewDialog printPreView;
    }
}