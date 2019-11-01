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
using DKHP.ViewModels;

namespace DKHP
{
    public partial class frmSinhVien : Form
    {
        private static frmSinhVien _instance;

        SinhVienBLL svBLL = new SinhVienBLL();
        LopNienCheBLL lopncBLL = new LopNienCheBLL();
        int kt = 0;
        string fileName = "";
        byte[] byteImage = { };

        public static frmSinhVien instance
        {
            // uses lazy initialization.

            // note: this is not thread safe.
            get
            {
                if (_instance == null)
                {
                    _instance = new frmSinhVien();
                }

                return _instance;
            }

        }
        public frmSinhVien()
        {
            InitializeComponent();
            LoadDatagridView(svBLL.SearchAllSinhVien(tbxSearch.Text.Trim(), tbTenSearch.Text.Trim()), dataGridView1);

            LoadComboBox();
            byteImage = ImageToByteArray(pictureBox1.Image);
        }
        private void LoadComboBox()
        {
            List<eLopNienChe> lst = lopncBLL.GetAllLopNienChe();
            cbLop.DataSource = lst;
            cbLop.DisplayMember = "TenLop";
            cbLop.ValueMember = "ID_LopNienChe";
            cbLop.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void LoadDatagridView(List<eSinhVien> lst, DataGridView dgv)
        {
            List<SinhVienViewModels> lstView = lst.Select(t => new SinhVienViewModels(t)).ToList();
            dgv.DataSource = lstView;
            dgv.ReadOnly = true;


            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.BackgroundColor = Color.White;
        }

        public void XemThongTin()
        {
            btnChonAnh.Visible = false;
            groupBox1.Text = "Thông Tin Sinh Viên";
            instance.tbxID.ReadOnly = true;
            instance.tbxTen.ReadOnly = true;
            instance.cbLop.Enabled = false;
            instance.tbxPhone.ReadOnly = true;
            instance.tbxMail.ReadOnly = true;
            instance.tbxAddress.ReadOnly = true;
            instance.btnLuu.Visible = false;
            instance.btnHuy.Visible = false;
            ShowDataGrid();
        }
        public void Them()
        {
            btnChonAnh.Visible = true;
            groupBox1.Text = "Thêm Sinh Viên";
            instance.tbxID.ReadOnly = true;
            instance.tbxTen.ReadOnly = false;
            instance.cbLop.Enabled = true;
            instance.tbxPhone.ReadOnly = false;
            instance.tbxMail.ReadOnly = false;
            instance.tbxAddress.ReadOnly = false;
            instance.btnLuu.Visible = true;
            instance.btnHuy.Visible = true;
            ShowDataGrid();
        }
        public void ChinhSua()
        {
            btnChonAnh.Visible = true;
            groupBox1.Text = "Chỉnh Sửa Sinh Viên";
            instance.tbxID.ReadOnly = true;
            instance.tbxTen.ReadOnly = false;
            instance.cbLop.Enabled = true;
            instance.tbxPhone.ReadOnly = false;
            instance.tbxMail.ReadOnly = false;
            instance.tbxAddress.ReadOnly = false;
            instance.btnLuu.Visible = true;
            instance.btnHuy.Visible = true;
            ShowDataGrid();
        }

        private void ShowDataGrid()
        {
            int rowSelected = 0;
            try
            {
                rowSelected = dataGridView1.CurrentRow.Index;
            }
            catch (Exception e)
            {

            }

            if (groupBox1.Text != "Thêm Sinh Viên")
            {
                SinhVienViewModels sv = new SinhVienViewModels(svBLL.GetSinhVienByID(dataGridView1.Rows[rowSelected].Cells[0].Value.ToString()));
                tbxID.Text = sv.ID_SinhVien.Trim();
                tbxTen.Text = sv.HoVaTen.Trim();
                cbLop.SelectedText = sv.TenLopNienChe.Trim();
                tbxPhone.Text = sv.SDT.Trim();
                tbxAddress.Text = sv.DiaChi.Trim();
                tbxMail.Text = sv.Mail.Trim();
                tbxMK.Text = sv.MatKhau.Trim();
                if (sv.HinhAnh != null)
                {
                    pictureBox1.Image = ByteToImg(Convert.ToBase64String(sv.HinhAnh));
                }
            }

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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
        #region Images
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
        #endregion
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
                if (!Regex.IsMatch(tbxMail.Text, ""))
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

            if (kt == 4)
            {
                eSinhVien sv = new eSinhVien();
                sv.HinhAnh = byteImage;
                sv.ID_SinhVien = tbxID.Text.Trim();
                sv.HoVaTen = tbxTen.Text.Trim();
                sv.ID_LopNienChe = cbLop.SelectedValue.ToString().Trim();
                sv.SDT = tbxPhone.Text.Trim();
                sv.Mail = tbxMail.Text.Trim();
                sv.DiaChi = tbxAddress.Text.Trim();
                sv.MatKhau = tbxMK.Text.Trim();

                if (groupBox1.Text == "Thêm Sinh Viên")
                {
                    if (svBLL.AddNewSinhVien(sv) == false)
                    {
                        MessageBox.Show("Lưu Thất Bại!!!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thành Công");
                        kt = 0;
                        LoadDatagridView(svBLL.SearchAllSinhVien(tbxSearch.Text.Trim(), tbTenSearch.Text.Trim()), dataGridView1);
                        ShowDataGrid();
                        pictureBox1.Image = Resources.book;
                    }
                }
                else
                {
                    if (svBLL.EditSinhVien(sv.ID_SinhVien, sv) == false)
                    {
                        MessageBox.Show("Lưu Thất Bại!!!");
                    }
                    else
                    {
                        MessageBox.Show("Chỉnh Sửa Thành Công");
                        kt = 0;
                        LoadDatagridView(svBLL.SearchAllSinhVien(tbxSearch.Text.Trim(), tbTenSearch.Text.Trim()), dataGridView1);
                        ShowDataGrid();
                    }
                }
            }

        }
        //Ẩn password
        private void btnHide_Click(object sender, EventArgs e)
        {
            tbxMK.UseSystemPasswordChar = tbxMK.UseSystemPasswordChar == true ? false : true;
        }
        //btnSearch
        private void button1_Click(object sender, EventArgs e)
        {
            LoadDatagridView(svBLL.SearchAllSinhVien(tbxSearch.Text.Trim(), tbTenSearch.Text.Trim()), dataGridView1);
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadDatagridView(svBLL.SearchAllSinhVien(tbxSearch.Text.Trim(), tbTenSearch.Text.Trim()), dataGridView1);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            instance.Them();
            btnHuy.Visible = true;
            btnLuu.Visible = true;
            btnSua.Visible = false;
            btnThem.Visible = false;

            pictureBox1.Image = Resources.book;
            tbxID.Text = svBLL.CreateID();
            tbxTen.Text = "";
            cbLop.SelectedIndex = 0;
            tbxPhone.Text = "";
            tbxMail.Text = "";
            tbxAddress.Text = "";
            tbxMK.Text = "123456";
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
    }
}
