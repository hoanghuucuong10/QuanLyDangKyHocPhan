﻿using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DKHP
{
    public partial class frmDangKyHocPhan : Form
    {
        private object taiKhoan;
        public frmDangKyHocPhan(object tk)
        {
            InitializeComponent();
            this.taiKhoan = tk;
            if(tk is eSinhVien)
            {
                btnSearch.Visible = false;
                tbxID.ReadOnly = true;
                frmDangKyHocPhanPN frm = new frmDangKyHocPhanPN((eSinhVien)tk);
                frm.TopLevel = false;
                frm.Visible = true;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                panel1.Controls.Clear();
                panel1.Controls.Add(frm);

                eSinhVien sv = (eSinhVien)tk;
                tbxID.Text = sv.ID_SinhVien;
              //  tbxLopNC.Text = sv.LopNienChe.;
                tbxTen.Text = sv.HoVaTen;
                tbxAddress.Text = sv.DiaChi;
                tbxMail.Text = sv.Mail;
                tbxPhone.Text = sv.SDT;

                if (sv.HinhAnh != null)
                {
                    pictureBox1.Image = ByteToImg(Convert.ToBase64String(sv.HinhAnh));
                }
            }
            else
            {
                btnSearch.Visible = true;
                tbxID.ReadOnly = false;
            }
        }
        SinhVienBLL svBLL = new SinhVienBLL();
        private Image ByteToImg(string byteString)
        {
            try
            {
                byte[] imgBytes = Convert.FromBase64String(byteString);
                MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
                ms.Write(imgBytes, 0, imgBytes.Length);
                Image image = Image.FromStream(ms, true);
                return image;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            eSinhVien sv = new eSinhVien();
            sv = svBLL.GetSinhVienByID(tbxID.Text.Trim());
            if (sv != null)
            {
               
             //   tbxLopNC.Text = sv.LopNienChe.TenLop;   
                tbxTen.Text = sv.HoVaTen;
                tbxAddress.Text = sv.DiaChi;
                tbxMail.Text = sv.Mail;
                tbxPhone.Text = sv.SDT;
                if (sv.HinhAnh != null)
                {
                    pictureBox1.Image = ByteToImg(Convert.ToBase64String(sv.HinhAnh));
                }

                frmDangKyHocPhanPN frm = new frmDangKyHocPhanPN(sv);
                frm.TopLevel = false;
                frm.Visible = true;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                panel1.Controls.Clear();
                panel1.Controls.Add(frm);
            }
            else
            {
                MessageBox.Show("Sai mã số sinh viên");
            }
        }
    }
}