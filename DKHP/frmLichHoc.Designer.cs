namespace DKHP
{
    partial class frmLichHoc
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
            this.cbTietHoc = new System.Windows.Forms.ComboBox();
            this.cbPhongHoc = new System.Windows.Forms.ComboBox();
            this.cbNgayHoc = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbTietHoc
            // 
            this.cbTietHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTietHoc.FormattingEnabled = true;
            this.cbTietHoc.Items.AddRange(new object[] {
            "1-3",
            "4-6",
            "7-9",
            "10-12",
            "13-15",
            "1-2",
            "2-3",
            "4-5",
            "5-6",
            "7-8",
            "8-9",
            "10-11",
            "11-12",
            "13-14",
            "14-15",
            "1-6",
            "7-12"});
            this.cbTietHoc.Location = new System.Drawing.Point(76, 100);
            this.cbTietHoc.Name = "cbTietHoc";
            this.cbTietHoc.Size = new System.Drawing.Size(64, 21);
            this.cbTietHoc.TabIndex = 20;
            // 
            // cbPhongHoc
            // 
            this.cbPhongHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhongHoc.FormattingEnabled = true;
            this.cbPhongHoc.Location = new System.Drawing.Point(78, 133);
            this.cbPhongHoc.Name = "cbPhongHoc";
            this.cbPhongHoc.Size = new System.Drawing.Size(85, 21);
            this.cbPhongHoc.TabIndex = 21;
            // 
            // cbNgayHoc
            // 
            this.cbNgayHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNgayHoc.FormattingEnabled = true;
            this.cbNgayHoc.Location = new System.Drawing.Point(78, 75);
            this.cbNgayHoc.Name = "cbNgayHoc";
            this.cbNgayHoc.Size = new System.Drawing.Size(98, 21);
            this.cbNgayHoc.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Tiết Học:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Phòng Học:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ngày Học:";
            // 
            // frmLichHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cbTietHoc);
            this.Controls.Add(this.cbPhongHoc);
            this.Controls.Add(this.cbNgayHoc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Name = "frmLichHoc";
            this.Text = "frmLichHoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTietHoc;
        private System.Windows.Forms.ComboBox cbPhongHoc;
        private System.Windows.Forms.ComboBox cbNgayHoc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
    }
}