using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BLL;
using System.IO;
using DKHP.Properties;
using System.Text.RegularExpressions;

namespace DKHP
{
    public partial class frmTaiKhoan : Form
    {
        Object taiKhoan = new Object();
        int kt = 0;
        public frmTaiKhoan(Object tk)
        {
            InitializeComponent();
            taiKhoan = tk;
            Loadform();
        }
        public void Loadform()
        {
            if (taiKhoan is eSinhVien)
            {
                taiKhoan=(new SinhVienBLL().GetSinhVienByID(((eSinhVien)taiKhoan).ID_SinhVien));
                pictureBox1.Image = ByteToImg(Convert.ToBase64String(((eSinhVien)taiKhoan).HinhAnh));
                tbxTen.Text = ((eSinhVien)taiKhoan).HoVaTen.ToString().Trim();
                tbxAddress.Text = ((eSinhVien)taiKhoan).DiaChi.ToString().Trim();
                tbxMail.Text = ((eSinhVien)taiKhoan).Mail.ToString().Trim();
                tbxPhone.Text = ((eSinhVien)taiKhoan).SDT.ToString().Trim();
            }
            else if (taiKhoan is eNhanVienPDT)
            {
                taiKhoan = (new NhanVienBLL().GetNhanVienByID(((eNhanVienPDT)taiKhoan).ID_NhanVienPDT));
                tbxTen.Text = ((eNhanVienPDT)taiKhoan).HoVaTen.ToString().Trim();
                pictureBox1.Image = ByteToImg(Convert.ToBase64String(((eNhanVienPDT)taiKhoan).HinhAnh));
                tbxAddress.Text = ((eNhanVienPDT)taiKhoan).DiaChi.ToString().Trim();
                tbxMail.Text = ((eNhanVienPDT)taiKhoan).Mail.ToString().Trim();
                tbxPhone.Text = ((eNhanVienPDT)taiKhoan).SDT.ToString().Trim();
            }
            else
            {
                taiKhoan = (new GiangVienBLL().GetGiangVienByID(((eGiangVien)taiKhoan).ID_GiangVien));
                pictureBox1.Image = ByteToImg(Convert.ToBase64String(((eGiangVien)taiKhoan).HinhAnh));
                tbxTen.Text = ((eGiangVien)taiKhoan).HoVaTen.ToString().Trim();
                tbxAddress.Text = ((eGiangVien)taiKhoan).DiaChi.ToString().Trim();
                tbxMail.Text = ((eGiangVien)taiKhoan).Mail.ToString().Trim();
                tbxPhone.Text = ((eGiangVien)taiKhoan).SDT.ToString().Trim();
            }
        }
        private byte[] converImgToByte(string fileName)
        {
            FileStream fs;
            fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }
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
        public byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxTen.Text))
            {
                err.SetError(tbxTen, "Không được để trống");
                kt = 0;
            }
            else
            {
                if (!Regex.IsMatch(tbxTen.Text, @"^[A-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪỬỮỰỲỴÝỶỸ][a-zàáâãèéếêìíòóôõùúăđĩũơưăạảấầẩẫậắằẳẵặẹẻẽềềểễệỉịọỏốồổỗộớờởỡợụủứừửữựỳỵỷỹ]*(\s[A-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪỬỮỰỲỴÝỶỸ][a-zàáâãèéếêìíòóôõùúăđĩũơưăạảấầẩẫậắằẳẵặẹẻẽềềểễệỉịọỏốồổỗộớờởỡợụủứừửữựỳỵỷỹ]*)+$"))
                {

                    err.SetError(tbxTen, "Tên không hợp lệ");
                    kt = 0;
                }
                else
                {
                    err.SetError(tbxTen, "");
                    kt = 1;
                }
            }

            if (string.IsNullOrEmpty(tbxPhone.Text))
            {

                err.SetError(tbxPhone, "Không được để trống");
                kt = 0;
            }
            else
            {
                if (!Regex.IsMatch(tbxPhone.Text, @"^[0][1-9][0-9]+$"))
                {

                    err.SetError(tbxPhone, "Số điện thoại không hợp lệ");
                    kt = 0;
                }
                else
                {
                    err.SetError(tbxPhone, "");
                    kt = 1;
                }
            }
            if (string.IsNullOrEmpty(tbxAddress.Text))
            {
                err.SetError(tbxTen, "Không được để trống");
                kt = 0;
            }
            else
            {
                if (!Regex.IsMatch(tbxAddress.Text, @"^[A-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪỬỮỰỲỴÝỶỸ1-9][a-zàáâãèéếêìíòóôõùúăđĩũơưăạảấầẩẫậắằẳẵặẹẻẽềềểễệỉịọỏốồổỗộớờởỡợụủứừửữựỳỵỷỹ1-9]*(\s[A-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪỬỮỰỲỴÝỶỸ1-9][a-zàáâãèéếêìíòóôõùúăđĩũơưăạảấầẩẫậắằẳẵặẹẻẽềềểễệỉịọỏốồổỗộớờởỡợụủứừửữựỳỵỷỹ1-9]*)+$"))
                {

                    err.SetError(tbxAddress, "Tên không hợp lệ");
                    kt = 0;
                }
                else
                {
                    err.SetError(tbxAddress, "");
                    kt = 1;
                }
            }
             if (string.IsNullOrEmpty(tbxMail.Text))
            {
                err.SetError(tbxTen, "Không được để trống");
                kt = 0;
            }
            else
            {
                if (!Regex.IsMatch(tbxMail.Text, @"^([a-z0-9_\.-]+)@([\da-z\.-]+)\.([a-z\.]{2,6})$"))
                {

                    err.SetError(tbxMail, "Email không hợp lệ");
                    kt = 0;
                }
                else
                {
                    err.SetError(tbxMail, "");
                    kt = 1;
                }
            }

            



            if (kt==1)
            {
                if (taiKhoan is eSinhVien)
                {
                    eSinhVien x = new eSinhVien();
                    x.HinhAnh = ImageToByteArray(pictureBox1.Image);
                    x.HoVaTen = tbxTen.Text;
                    x.DiaChi = tbxAddress.Text;
                    x.Mail = tbxMail.Text;
                    x.SDT = tbxPhone.Text;
                    x.ID_LopNienChe = ((eSinhVien)taiKhoan).ID_LopNienChe;
                    x.ID_SinhVien = ((eSinhVien)taiKhoan).ID_SinhVien;
                    x.MatKhau = ((eSinhVien)taiKhoan).MatKhau;
                    if (new SinhVienBLL().EditSinhVien(x.ID_SinhVien, x) == true)
                    {
                        MessageBox.Show("Lưu Thành Công");
                        taiKhoan = x;
                        Loadform();
                        kt = 0;
                    }
                    else
                        MessageBox.Show("Lưu Thất Bại");

                }
                else if (taiKhoan is eNhanVienPDT)
                {

                    eNhanVienPDT x = new eNhanVienPDT();
                    x.HinhAnh = ImageToByteArray(pictureBox1.Image);
                    x.HoVaTen = tbxTen.Text;
                    x.DiaChi = tbxAddress.Text;
                    x.Mail = tbxMail.Text;
                    x.SDT = tbxPhone.Text;
                    x.ID_NhanVienPDT = ((eNhanVienPDT)taiKhoan).ID_NhanVienPDT;
                    x.MatKhau = ((eNhanVienPDT)taiKhoan).MatKhau;
                    if (new NhanVienBLL().EditNhanVien(x) == 1)
                    {
                        MessageBox.Show("Lưu Thành Công");
                        taiKhoan = x;
                        Loadform();
                        kt = 0;
                    }
                    else
                        MessageBox.Show("Lưu Thất Bại");
                }
                else
                {
                    eGiangVien x = new eGiangVien();
                    x.HinhAnh = ImageToByteArray(pictureBox1.Image);
                    x.HoVaTen = tbxTen.Text;
                    x.DiaChi = tbxAddress.Text;
                    x.Mail = tbxMail.Text;
                    x.SDT = tbxPhone.Text;
                    x.ID_GiangVien = ((eGiangVien)taiKhoan).ID_GiangVien;
                    x.TrinhDo = ((eGiangVien)taiKhoan).TrinhDo;
                    x.MatKhau = ((eGiangVien)taiKhoan).MatKhau;
                    if (new GiangVienBLL().EditGiangVien(x.ID_GiangVien, x) == true)
                    {
                        MessageBox.Show("Lưu Thành Công");
                        taiKhoan = x;
                        Loadform();
                        kt = 0;
                    }
                    else
                        MessageBox.Show("Lưu Thất Bại");
                }
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Loadform();
        }
        string fileName = "";
        byte[] byteImage = { };
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                fileName = openFile.FileName;
                string type = fileName.Substring(fileName.LastIndexOf("."));

                if (type == ".png" || type == ".jpg" || type == ".jpeg" || type == ".jpe" || type == ".jfif")
                {
                    string s = Convert.ToBase64String(converImgToByte(fileName));
                    byteImage = Convert.FromBase64String(s);
                    pictureBox1.Image = ByteToImg(s);
                }
                else
                {
                    MessageBox.Show("Khong phai file Hinh anh");
                    pictureBox1.Image = Resources.book;

                }
            }
        }
    }
}
