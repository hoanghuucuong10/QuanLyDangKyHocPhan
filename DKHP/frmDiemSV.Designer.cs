namespace DKHP
{
    partial class frmDiemSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiemSV));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLopNC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.picHinhAnh = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvHeader = new System.Windows.Forms.DataGridView();
            this.idLopHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnDiemSV = new System.Windows.Forms.FlowLayoutPanel();
            this.printPreView = new System.Windows.Forms.PrintPreviewDialog();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtLopNC);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.picHinhAnh);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 510);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sinh Viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Email:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(109, 370);
            this.txtMail.Name = "txtMail";
            this.txtMail.ReadOnly = true;
            this.txtMail.Size = new System.Drawing.Size(152, 20);
            this.txtMail.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Địa Chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Số Điện Thoại:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(109, 335);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(152, 20);
            this.txtAddress.TabIndex = 36;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(109, 300);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(152, 20);
            this.txtPhone.TabIndex = 37;
            // 
            // txtLopNC
            // 
            this.txtLopNC.Location = new System.Drawing.Point(109, 259);
            this.txtLopNC.Name = "txtLopNC";
            this.txtLopNC.ReadOnly = true;
            this.txtLopNC.Size = new System.Drawing.Size(152, 20);
            this.txtLopNC.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Lớp Niên Chế:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Họ Và Tên:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(233, 175);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(24, 24);
            this.btnSearch.TabIndex = 34;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(109, 217);
            this.txtTen.Name = "txtTen";
            this.txtTen.ReadOnly = true;
            this.txtTen.Size = new System.Drawing.Size(142, 20);
            this.txtTen.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Mã Sinh Viên:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(109, 179);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(118, 20);
            this.txtID.TabIndex = 32;
            this.txtID.Text = "sv00000001";
            // 
            // picHinhAnh
            // 
            this.picHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHinhAnh.Image = ((System.Drawing.Image)(resources.GetObject("picHinhAnh.Image")));
            this.picHinhAnh.Location = new System.Drawing.Point(91, 56);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Size = new System.Drawing.Size(102, 95);
            this.picHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picHinhAnh.TabIndex = 31;
            this.picHinhAnh.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(307, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(899, 510);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng Điểm";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.BackgroundImage = global::DKHP.Properties.Resources.printer;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrint.Location = new System.Drawing.Point(696, 443);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(95, 51);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvHeader);
            this.panel1.Controls.Add(this.pnDiemSV);
            this.panel1.Location = new System.Drawing.Point(36, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 388);
            this.panel1.TabIndex = 9;
            // 
            // dgvHeader
            // 
            this.dgvHeader.BackgroundColor = System.Drawing.Color.Blue;
            this.dgvHeader.ColumnHeadersHeight = 40;
            this.dgvHeader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLopHP,
            this.TenMonHoc,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvHeader.GridColor = System.Drawing.Color.White;
            this.dgvHeader.Location = new System.Drawing.Point(0, 0);
            this.dgvHeader.Name = "dgvHeader";
            this.dgvHeader.RowHeadersVisible = false;
            this.dgvHeader.RowHeadersWidth = 50;
            this.dgvHeader.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvHeader.Size = new System.Drawing.Size(843, 40);
            this.dgvHeader.TabIndex = 12;
            // 
            // idLopHP
            // 
            this.idLopHP.FillWeight = 95.83844F;
            this.idLopHP.HeaderText = "Mã Lớp Học Phần";
            this.idLopHP.Name = "idLopHP";
            this.idLopHP.Width = 180;
            // 
            // TenMonHoc
            // 
            this.TenMonHoc.FillWeight = 110.4082F;
            this.TenMonHoc.HeaderText = "Tên Môn Học";
            this.TenMonHoc.Name = "TenMonHoc";
            this.TenMonHoc.Width = 220;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 69.37276F;
            this.Column1.HeaderText = "TK1";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 77.5659F;
            this.Column2.HeaderText = "TK2";
            this.Column2.Name = "Column2";
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 85.23756F;
            this.Column3.HeaderText = "TK3";
            this.Column3.Name = "Column3";
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 83.53434F;
            this.Column4.HeaderText = "GK";
            this.Column4.Name = "Column4";
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 88.20744F;
            this.Column5.HeaderText = "CK";
            this.Column5.Name = "Column5";
            this.Column5.Width = 60;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 143.6442F;
            this.Column6.HeaderText = "Tổng Kết";
            this.Column6.Name = "Column6";
            this.Column6.Width = 60;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 146.1912F;
            this.Column7.HeaderText = "Xếp Loại";
            this.Column7.Name = "Column7";
            this.Column7.Width = 60;
            // 
            // pnDiemSV
            // 
            this.pnDiemSV.AutoScroll = true;
            this.pnDiemSV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnDiemSV.Location = new System.Drawing.Point(0, 41);
            this.pnDiemSV.Margin = new System.Windows.Forms.Padding(0);
            this.pnDiemSV.Name = "pnDiemSV";
            this.pnDiemSV.Size = new System.Drawing.Size(843, 345);
            this.pnDiemSV.TabIndex = 11;
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
            // frmDiemSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DKHP.Properties.Resources.istockphoto_995719694_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1218, 534);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDiemSV";
            this.Text = "frmDiemSV";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLopNC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.PictureBox picHinhAnh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLopHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.FlowLayoutPanel pnDiemSV;
        private System.Windows.Forms.PrintPreviewDialog printPreView;
        private System.Drawing.Printing.PrintDocument printDoc;
        private System.Windows.Forms.Button btnPrint;
    }
}