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
using BLL;
using Entities;
using DKHP.Properties;
using System.Text.RegularExpressions;
using DKHP.ViewModels;

namespace DKHP
{
    public partial class frmGiangVien : Form
    {
        private static frmGiangVien _instance;

        GiangVienBLL gvBLL = new GiangVienBLL();
        int kt = 0;
        string filePath = "";
        byte[] byteImage = { };

        public static frmGiangVien instance
        {
            // uses lazy initialization.

            // note: this is not thread safe.
            get
            {
                if (_instance == null)
                {
                    _instance = new frmGiangVien();
                }

                return _instance;
            }

        }
        public frmGiangVien()
        {
            InitializeComponent();
            LoadDatagridView(gvBLL.SearchAllGiangVien(txtIDSearch.Text.Trim(), txtTenSearch.Text.Trim()), dgvGiangVien);
            byteImage = converterDemo(pictureBox1.Image);
          
        }
    
        public void LoadDatagridView(List<eGiangVien> lst, DataGridView dgv)
        {
            List<GiangVienViewModels> lstGV = lst.Select(t => new GiangVienViewModels(t)).ToList();
            dgv.DataSource = lstGV;
            dgv.ReadOnly = true;  

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.BackgroundColor = Color.White;
        }
        #region Images
       
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                filePath = openFile.FileName;
                string s = Convert.ToBase64String(converImgToByte(filePath));
                byteImage = Convert.FromBase64String(s);
                pictureBox1.Image = ByteToImg(s);
            }
        }

        private byte[] converImgToByte(string fileName)
        {
            FileStream fs;
            byte[] picbyte;
            try
            {
                
                fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                picbyte = new byte[fs.Length];
                fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
                return picbyte;
            }catch(Exception e)
            {
                return null;
            }
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
        public static byte[] converterDemo(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }
        #endregion

        public void XemThongTin()
        {
            btnChonAnh.Visible = false;
            groupBoxThongTinGiangVien.Text = "Thông Tin Giảng Viên";
            instance.tbxID.ReadOnly = true;
            instance.tbxTen.ReadOnly = true;
            instance.tbTrinhDo.Enabled = false;
            instance.tbxPhone.ReadOnly = true;
            instance.tbxMail.ReadOnly = true;
            instance.tbxAddress.ReadOnly = true;
            instance.btnLuu.Visible = false;
            instance.btnHuy.Visible = false;
            instance.tbxMK.ReadOnly = true;
            instance.btnThem.Visible = true;
            instance.btnSua.Visible = true;
           
        }

        public void Them()
        {
            btnChonAnh.Visible = true;
            groupBoxThongTinGiangVien.Text = "Thêm Giảng Viên";
            instance.tbxID.ReadOnly = true;
            instance.tbxTen.ReadOnly = false;
            instance.tbTrinhDo.Enabled = true;
            instance.tbxPhone.ReadOnly = false;
            instance.tbxMail.ReadOnly = false;
            instance.tbxAddress.ReadOnly = false;
            instance.btnLuu.Visible = true;
            instance.btnHuy.Visible = true;
            instance.tbxMK.ReadOnly = false;
            ShowDataGrid();
        }

        public void ChinhSua()
        {
            btnChonAnh.Visible = true;
            groupBoxThongTinGiangVien.Text = "Chỉnh Sửa Giảng Viên";
            instance.tbxID.ReadOnly = true;
            instance.tbxTen.ReadOnly = false;
            instance.tbTrinhDo.Enabled = true;
            instance.tbxPhone.ReadOnly = false;
            instance.tbxMail.ReadOnly = false;
            instance.tbxAddress.ReadOnly = false;
            instance.btnLuu.Visible = true;
            instance.btnHuy.Visible = true;
            instance.tbxMK.ReadOnly = false;
            ShowDataGrid();

        }
        //Lấy giá trị trên datagridview xổ sang form thông tin
        private void ShowDataGrid()
        {
            int rowSelected = 0;
            try
            {
                rowSelected = dgvGiangVien.CurrentRow.Index;
            }
            catch (Exception e)
            {

            }


            if (groupBoxThongTinGiangVien.Text != "Thêm Giảng Viên")
            {
                GiangVienViewModels gv = new GiangVienViewModels( gvBLL.GetGiangVienByID(dgvGiangVien.Rows[rowSelected].Cells[0].Value.ToString()));
                tbxID.Text = gv.ID_GiangVien.Trim();
                tbxTen.Text = gv.HoVaTen.Trim();
                tbTrinhDo.Text = gv.TrinhDo.Trim();
                tbxPhone.Text = gv.SDT.Trim();
                tbxAddress.Text = gv.DiaChi.Trim();
                tbxMail.Text = gv.Mail.Trim();
                tbxMK.Text = gv.MatKhau.Trim();
                if (gv.HinhAnh != null)
                {
                    pictureBox1.Image = ByteToImg(Convert.ToBase64String(gvBLL.GetGiangVienByID(tbxID.Text.Trim()).HinhAnh));
                }
            }
        }

        private void dgvGiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowDataGrid();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            instance.XemThongTin();
            btnHuy.Visible = false;
            btnLuu.Visible = false;
            btnThem.Visible = true;
            btnSua.Visible = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            kt = 0;
            #region Kiểm tra dữ liệu nhập
            //Tên
            if (string.IsNullOrEmpty(tbxTen.Text))
            {
                err.SetError(tbxTen, "Không được để trống");
            }
            else
            {
                if (!Regex.IsMatch(tbxTen.Text, @"^[A-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪỬỮỰỲỴÝỶỸ][a-zàáâãèéếêìíòóôõùúăđĩũơưăạảấầẩẫậắằẳẵặẹẻẽềềểễệỉịọỏốồổỗộớờởỡợụủứừửữựỳỵỷỹ]*(\s[A-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪỬỮỰỲỴÝỶỸ][a-zàáâãèéếêìíòóôõùúăđĩũơưăạảấầẩẫậắằẳẵặẹẻẽềềểễệỉịọỏốồổỗộớờởỡợụủứừửữựỳỵỷỹ]*)+$"))
                {
                    err.SetError(tbxTen, "Tên không hợp lệ");
                }
                else
                {
                    err.SetError(tbxTen, "");
                    kt++;
                }
            }
            //Trình độ
            if (string.IsNullOrEmpty(tbTrinhDo.Text))
            {
                err.SetError(tbTrinhDo, "Không được để trống");
            }
            else
            {
                if (!Regex.IsMatch(tbTrinhDo.Text, @"^[A-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪỬỮỰỲỴÝỶỸ][a-zàáâãèéếêìíòóôõùúăđĩũơưăạảấầẩẫậắằẳẵặẹẻẽềềểễệỉịọỏốồổỗộớờởỡợụủứừửữựỳỵỷỹ]*(\s[A-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪỬỮỰỲỴÝỶỸ][a-zàáâãèéếêìíòóôõùúăđĩũơưăạảấầẩẫậắằẳẵặẹẻẽềềểễệỉịọỏốồổỗộớờởỡợụủứừửữựỳỵỷỹ]*)+$"))
                {
                    err.SetError(tbTrinhDo, "Trình độ không hợp lệ");
                }
                else
                {
                    err.SetError(tbxTen, "");
                    kt++;
                }
            }
            //Phone
            if (string.IsNullOrEmpty(tbxPhone.Text))
            {

                err.SetError(tbxPhone, "Không được để trống");
            }
            else
            {
                if (!Regex.IsMatch(tbxPhone.Text, @"^[0][1-9][0-9]+$"))
                {
                    err.SetError(tbxPhone, "Số điện thoại không hợp lệ");
                }
                else
                {
                    err.SetError(tbxPhone, "");
                    kt++;
                }
            }
            //Địa chỉ
            if (string.IsNullOrEmpty(tbxAddress.Text))
            {
                err.SetError(tbxAddress, "Không được để trống");
            }
            else
            {
                if (!Regex.IsMatch(tbxAddress.Text, @"^[A-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪỬỮỰỲỴÝỶỸ1-9][a-zàáâãèéếêìíòóôõùúăđĩũơưăạảấầẩẫậắằẳẵặẹẻẽềềểễệỉịọỏốồổỗộớờởỡợụủứừửữựỳỵỷỹ1-9]*(\s[A-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪỬỮỰỲỴÝỶỸ1-9][a-zàáâãèéếêìíòóôõùúăđĩũơưăạảấầẩẫậắằẳẵặẹẻẽềềểễệỉịọỏốồổỗộớờởỡợụủứừửữựỳỵỷỹ1-9]*)+$"))
                {
                    err.SetError(tbxAddress, "Tên không hợp lệ");
                }
                else
                {
                    err.SetError(tbxAddress, "");
                    kt++;
                }
            }
            //email
            if (string.IsNullOrEmpty(tbxMail.Text))
            {
                err.SetError(tbxMail, "Không được để trống");
            }
            else
            {
                if (!Regex.IsMatch(tbxMail.Text, @"^([a-z0-9_\.-]+)@([\da-z\.-]+)\.([a-z\.]{2,6})$"))
                {

                    err.SetError(tbxMail, "Email không hợp lệ");
                }
                else
                {
                    err.SetError(tbxMail, "");
                    kt++;
                }
            }
            #endregion
            if (kt==5)
            {
                eGiangVien gv = new eGiangVien();
                gv.HinhAnh = byteImage;
                gv.ID_GiangVien = tbxID.Text.Trim();
                gv.HoVaTen = tbxTen.Text.Trim();
                gv.TrinhDo = tbTrinhDo.Text.Trim();
                gv.SDT = tbxPhone.Text.Trim();
                gv.Mail = tbxMail.Text.Trim();
                gv.DiaChi = tbxAddress.Text.Trim();
                gv.MatKhau = tbxMK.Text.Trim();
                gv.HinhAnh = byteImage;

                if (groupBoxThongTinGiangVien.Text == "Thêm Giảng Viên")
                {
                    if (gvBLL.AddNewGiangVien(gv) == false)
                    {
                        MessageBox.Show("Lưu Thất Bại!!!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thành Công");
                        kt = 0;
                        LoadDatagridView(gvBLL.SearchAllGiangVien(txtIDSearch.Text.Trim(), txtTenSearch.Text.Trim()), dgvGiangVien);
                        ShowDataGrid();
                        pictureBox1.Image = Resources.book;
                        XemThongTin();
                    }
                }
                else
                {
                    if (gvBLL.EditGiangVien(gv.ID_GiangVien, gv) == false)
                    {
                        MessageBox.Show("Lưu Thất Bại!!!");
                    }
                    else
                    {
                        MessageBox.Show("Chỉnh Sửa Thành Công");
                        kt = 0;
                        LoadDatagridView(gvBLL.SearchAllGiangVien(txtIDSearch.Text.Trim(), txtTenSearch.Text.Trim()), dgvGiangVien);
                        ShowDataGrid();
                        XemThongTin();
                    }
                }
            }
           
        }
        //Search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadDatagridView(gvBLL.SearchAllGiangVien(txtIDSearch.Text.Trim(),txtTenSearch.Text.Trim()), dgvGiangVien);
        }
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadDatagridView(gvBLL.SearchAllGiangVien(txtIDSearch.Text.Trim(), txtTenSearch.Text.Trim()), dgvGiangVien);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            tbxMK.UseSystemPasswordChar = tbxMK.UseSystemPasswordChar == true ? false : true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            instance.Them();
            btnHuy.Visible = true;
            btnLuu.Visible = true;
            btnSua.Visible = false;
            btnThem.Visible = false;

            pictureBox1.Image = Resources.book;
            tbxID.Text = gvBLL.CreateID();
            tbxTen.Text = "";
            tbxPhone.Text = "";
            tbxMail.Text = "";
            tbxAddress.Text = "";
            tbxMK.Text = "123456";
            tbTrinhDo.Text = "";
            tbxMK.ReadOnly = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            instance.ChinhSua();
            btnHuy.Visible = true;
            btnLuu.Visible = true;
            btnSua.Visible = false;
            btnThem.Visible = false;
        }

        private void dgvGiangVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
