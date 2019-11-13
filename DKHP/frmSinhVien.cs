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
            LoadDatagridView(svBLL.SearchAllSinhVien(txtIDSearch.Text.Trim(), txtTenSearch.Text.Trim()), dgvSinhVien);

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
        //cập nhật dữ liệu cho datagridview
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
            instance.txtID.ReadOnly = true;
            instance.txtTen.ReadOnly = true;
            instance.cbLop.Enabled = false;
            instance.txtPhone.ReadOnly = true;
            instance.txtMail.ReadOnly = true;
            instance.txtAddress.ReadOnly = true;
            instance.btnLuu.Visible = false;
            instance.btnHuy.Visible = false;
            instance.btnSua.Visible = true;
            instance.btnThem.Visible = true;
            ShowDataGrid();
        }
        public void Them()
        {
            btnChonAnh.Visible = true;
            groupBox1.Text = "Thêm Sinh Viên";
            instance.txtID.ReadOnly = true;
            instance.txtTen.ReadOnly = false;
            instance.cbLop.Enabled = true;
            instance.txtPhone.ReadOnly = false;
            instance.txtMail.ReadOnly = false;
            instance.txtAddress.ReadOnly = false;
            instance.btnLuu.Visible = true;
            instance.btnHuy.Visible = true;
            instance.btnSua.Visible = false;
            instance.btnThem.Visible = false;
            ShowDataGrid();
        }
        public void ChinhSua()
        {
            btnChonAnh.Visible = true;
            groupBox1.Text = "Chỉnh Sửa Sinh Viên";
            instance.txtID.ReadOnly = true;
            instance.txtTen.ReadOnly = false;
            instance.cbLop.Enabled = true;
            instance.txtPhone.ReadOnly = false;
            instance.txtMail.ReadOnly = false;
            instance.txtAddress.ReadOnly = false;
            instance.btnLuu.Visible = true;
            instance.btnHuy.Visible = true;
            instance.btnSua.Visible = false;
            instance.btnThem.Visible = false;
            ShowDataGrid();
        }

        private void ShowDataGrid()
        {
           if(dgvSinhVien.CurrentRow!=null)
            {

                if (groupBox1.Text != "Thêm Sinh Viên")
                {
                    SinhVienViewModels sv = new SinhVienViewModels(svBLL.GetSinhVienByID(dgvSinhVien.Rows[dgvSinhVien.CurrentRow.Index].Cells[0].Value.ToString()));
                    txtID.Text = sv.ID_SinhVien.Trim();
                    txtTen.Text = sv.HoVaTen.Trim();
                    cbLop.SelectedText = sv.TenLopNienChe.Trim();
                    txtPhone.Text = sv.SDT.Trim();
                    txtAddress.Text = sv.DiaChi.Trim();
                    txtMail.Text = sv.Mail.Trim();
                    txtMK.Text = sv.MatKhau.Trim();
                    if (sv.HinhAnh != null)
                    {
                        pictureBox1.Image = ByteToImg(Convert.ToBase64String(sv.HinhAnh));
                    }
                }

            }

        }
        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
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
            if (string.IsNullOrEmpty(txtTen.Text))
            {
                err.SetError(txtTen, "Không được để trống");
            }
            else
            {
                if (!Regex.IsMatch(txtTen.Text, @"^[A-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪỬỮỰỲỴÝỶỸ][a-zàáâãèéếêìíòóôõùúăđĩũơưăạảấầẩẫậắằẳẵặẹẻẽềềểễệỉịọỏốồổỗộớờởỡợụủứừửữựỳỵỷỹ]*(\s[A-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪỬỮỰỲỴÝỶỸ][a-zàáâãèéếêìíòóôõùúăđĩũơưăạảấầẩẫậắằẳẵặẹẻẽềềểễệỉịọỏốồổỗộớờởỡợụủứừửữựỳỵỷỹ]*)+$"))
                {
                    err.SetError(txtTen, "Tên không hợp lệ");
                }
                else
                {
                    err.SetError(txtTen, "");
                    kt++;
                }
            }
            //Phone
            if (string.IsNullOrEmpty(txtPhone.Text))
            {

                err.SetError(txtPhone, "Không được để trống");
            }
            else
            {
                if (!Regex.IsMatch(txtPhone.Text, @"^[0][1-9][0-9]+$"))
                {

                    err.SetError(txtPhone, "Số điện thoại không hợp lệ");
                }
                else
                {
                    err.SetError(txtPhone, "");
                    kt++;
                }
            }
            //Địa chỉ
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                err.SetError(txtAddress, "Không được để trống");
            }
            else
            {
                if (!Regex.IsMatch(txtAddress.Text, @"^[A-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪỬỮỰỲỴÝỶỸ1-9][a-zàáâãèéếêìíòóôõùúăđĩũơưăạảấầẩẫậắằẳẵặẹẻẽềềểễệỉịọỏốồổỗộớờởỡợụủứừửữựỳỵỷỹ1-9]*(\s[A-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪỬỮỰỲỴÝỶỸ1-9][a-zàáâãèéếêìíòóôõùúăđĩũơưăạảấầẩẫậắằẳẵặẹẻẽềềểễệỉịọỏốồổỗộớờởỡợụủứừửữựỳỵỷỹ1-9]*)+$"))
                {

                    err.SetError(txtAddress, "Tên không hợp lệ");
                }
                else
                {
                    err.SetError(txtAddress, "");
                    kt++;
                }
            }
            //email
            if (string.IsNullOrEmpty(txtMail.Text))
            {
                err.SetError(txtMail, "Không được để trống");
            }
            else
            {
                if (!Regex.IsMatch(txtMail.Text, ""))
                {

                    err.SetError(txtMail, "Email không hợp lệ");
                }
                else
                {
                    err.SetError(txtMail, "");
                    kt++;
                }
            }
            #endregion

            if (kt == 4)
            {
                eSinhVien sv = new eSinhVien();
                sv.HinhAnh = byteImage;
                sv.ID_SinhVien = txtID.Text.Trim();
                sv.HoVaTen = txtTen.Text.Trim();
                sv.ID_LopNienChe = cbLop.SelectedValue.ToString().Trim();
                sv.SDT = txtPhone.Text.Trim();
                sv.Mail = txtMail.Text.Trim();
                sv.DiaChi = txtAddress.Text.Trim();
                sv.MatKhau = txtMK.Text.Trim();

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
                        LoadDatagridView(svBLL.SearchAllSinhVien(txtIDSearch.Text.Trim(), txtTenSearch.Text.Trim()), dgvSinhVien);
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
                        LoadDatagridView(svBLL.SearchAllSinhVien(txtIDSearch.Text.Trim(), txtTenSearch.Text.Trim()), dgvSinhVien);
                        ShowDataGrid();
                    }
                }
            }

        }
        //Ẩn password
        private void btnHide_Click(object sender, EventArgs e)
        {
            txtMK.UseSystemPasswordChar = txtMK.UseSystemPasswordChar == true ? false : true;
        }
        //btnSearch
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadDatagridView(svBLL.SearchAllSinhVien(txtIDSearch.Text.Trim(), txtTenSearch.Text.Trim()), dgvSinhVien);
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadDatagridView(svBLL.SearchAllSinhVien(txtIDSearch.Text.Trim(), txtTenSearch.Text.Trim()), dgvSinhVien);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            instance.Them();
            btnHuy.Visible = true;
            btnLuu.Visible = true;
            btnSua.Visible = false;
            btnThem.Visible = false;

            pictureBox1.Image = Resources.book;
            txtID.Text = svBLL.CreateID();
            txtTen.Text = "";
            cbLop.SelectedIndex = 0;
            txtPhone.Text = "";
            txtMail.Text = "";
            txtAddress.Text = "";
            txtMK.Text = "123456";
            txtMK.ReadOnly = true;
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
