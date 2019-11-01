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

namespace DKHP
{
    public partial class frmLopHocPhan : Form
    {
        private static frmLopHocPhan _instance;
        public List<eNhomThucHanh> lstTH = new List<eNhomThucHanh>();

        //  LopHocPhanBLL hocPhanBLL = new LopHocPhanBLL();
        public static frmLopHocPhan instance
        {
            // uses lazy initialization.

            // note: this is not thread safe.
            get
            {
                if (_instance == null)
                {
                    _instance = new frmLopHocPhan();
                }

                return _instance;
            }

        }
        LopHocPhanBLL LHP = new LopHocPhanBLL();

        public frmLopHocPhan()
        {
            InitializeComponent();
            LoadDanhSachLopHocPhan(LHP.SearchLopHocPhan(tbIDLopHPSearch.Text.Trim(), tbIDMonHocSearch.Text.Trim(), cbHocKiSearch.Text.ToString(), cbNamHocSearch.Text.ToString()));
            LoadComboBox();

            #region cbb
            //cbNgayHoc.Items.Add("Thứ Hai");
            //cbNgayHoc.Items.Add("Thứ Ba");
            //cbNgayHoc.Items.Add("Thứ Tư");
            //cbNgayHoc.Items.Add("Thứ Năm");
            //cbNgayHoc.Items.Add("Thứ Sáu");
            //cbNgayHoc.Items.Add("Thứ Bảy");
            //cbNgayHoc.Items.Add("Chủ Nhật");
            #endregion




        }
        public void LoadDanhSachLopHocPhan(List<eLopHocPhan> lst)
        {
           // eLopHocPhanBindingSource.DataSource = lst;
        }
        public void LoadDanhSachNhom(List<eNhomThucHanh> lst)
        {
           // eLopThucHanhBindingSource.DataSource = lst;
        }
        public void XemThongTin()
        {
            btnAddNhomTH.Visible = false;
            btnHuy.Visible = false;
            btnLuu.Visible = false;
            groupBox1.Text = "Thông Tin Lớp Học Phần";
            ShowDataGrid();
            cbMonHoc.Enabled = false;
            cbGiangVien.Enabled = false;
            cbHocKy.Enabled = false;
            cbNamHoc.Enabled = false;

            cbTrangThai.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;

        }
        public void Them()
        {
            groupBox1.Text = "Thêm Lớp Học Phần";
            tbID.Text = LHP.CreateID();
            ShowDataGrid();
            btnAddNhomTH.Visible = true;
            btnHuy.Visible = true;
            btnLuu.Visible = true;
            cbMonHoc.Enabled = true;
            cbGiangVien.Enabled = true;
            cbHocKy.Enabled = true;
            cbNamHoc.Enabled = true;
            cbTrangThai.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }
        public void ChinhSua()
        {
            groupBox1.Text = "Chỉnh Sửa Lớp Học Phần";
            ShowDataGrid();
            btnAddNhomTH.Visible = true;
            btnHuy.Visible = true;
            btnLuu.Visible = true;
            cbMonHoc.Enabled = true;
            cbGiangVien.Enabled = true;
            cbHocKy.Enabled = true;
            cbNamHoc.Enabled = true;
            cbTrangThai.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowDataGrid();
        }
        private void LoadComboBox()
        {
            //GiangVienBLL gv = new GiangVienBLL();
            //cbGiangVien.DataSource = gv.GetAllGiangVien();
            //cbGiangVien.DisplayMember = "hoVaTen";
            //cbGiangVien.ValueMember = "id_GiangVien";

            //PhongHocBLL ph = new PhongHocBLL();
            //cbPhongHoc.DataSource = ph.GetAllPhongHoc();
            //cbPhongHoc.DisplayMember = "tenPhong";
            //cbPhongHoc.ValueMember = "id_PhongHoc";


            //HocPhanBLL hp = new HocPhanBLL();
            //cbMonHoc.DataSource = hp.GetALLHocPhan();
            //cbMonHoc.DisplayMember = "tenMonHoc";
            //cbMonHoc.ValueMember = "id_HocPhan";

            //int a = DateTime.Now.Year;
            //int n = 0;
            //List<string> lstItem = new List<string>();
            //foreach (eLopHocPhan x in LHP.GetAllLopHocPhan())
            //{
            //    n = 0;
            //    foreach (string t in lstItem)
            //    {
            //        if (x.namHoc.Trim() == t.Trim())
            //        {
            //            n = 1;
            //        }
            //    }
            //    if (n == 0)
            //    {
            //        lstItem.Add(x.namHoc.Trim());
            //    }
            //}
            //n = 0;
            //foreach (string t in lstItem)
            //{
            //    if ((a + "-" + (a + 1)) == t.Trim())
            //    {
            //        n = 1;
            //    }
            //}
            //if (n == 0)
            //{
            //    lstItem.Add(a + "-" + (a + 1));
            //}
            //n = 0;
            //foreach (string t in lstItem)
            //{
            //    if (((a + 1) + "-" + (a + 2)) == t.Trim())
            //    {
            //        n = 1;
            //    }
            //}
            //if (n == 0)
            //{
            //    lstItem.Add((a + 1) + "-" + (a + 2));
            //}
            //n = 0;
            //foreach (string t in lstItem)
            //{
            //    if (((a + 2) + "-" + (a + 3)) == t.Trim())
            //    {
            //        n = 1;
            //    }
            //}
            //if (n == 0)
            //{
            //    lstItem.Add((a + 2) + "-" + (a + 3));
            //}



            //cbNamHoc.DataSource = lstItem;
            //cbNamHocSearch.DataSource = lstItem;

        }
        private void ShowDataGrid()
        {
            if (groupBox1.Text != "Thêm Lớp Học Phần")
            {
                int rowSelected = 0;
                try
                {
                    rowSelected = dataGridView1.CurrentRow.Index;
                }
                catch (Exception e)
                {

                }
                tbID.Text = dataGridView1.Rows[rowSelected].Cells[0].Value.ToString().Trim();
                lstTH = (new NhomThucHanhBLL()).GetNhomByIDLopHocPhan(tbID.Text);
                LoadDanhSachNhom(lstTH);

                cbMonHoc.SelectedValue = dataGridView1.Rows[rowSelected].Cells[12].Value.ToString().Trim();
                cbGiangVien.SelectedValue = dataGridView1.Rows[rowSelected].Cells[14].Value.ToString().Trim();
                cbHocKy.SelectedItem = dataGridView1.Rows[rowSelected].Cells[3].Value.ToString().Trim();
                cbNamHoc.SelectedItem = dataGridView1.Rows[rowSelected].Cells[4].Value.ToString().Trim();
                cbTrangThai.SelectedItem = dataGridView1.Rows[rowSelected].Cells[10].Value.ToString().Trim();
                DateTime x = Convert.ToDateTime(dataGridView1.Rows[rowSelected].Cells[5].Value.ToString().Trim());
                dateTimePicker1.Value = x;
                x = Convert.ToDateTime(dataGridView1.Rows[rowSelected].Cells[6].Value.ToString().Trim());
                dateTimePicker2.Value = x;
            }
            else
            {
                lstTH = new List<eNhomThucHanh>();
                LoadDanhSachNhom(lstTH);
                tbID.Text = LHP.CreateID();
                cbMonHoc.Text = "";
                cbGiangVien.Text = "";
                cbHocKy.SelectedIndex = -1;
                cbNamHoc.SelectedIndex = -1;
                cbTrangThai.SelectedIndex = 0;
            }
        }
        private void cbGiangVien_Leave(object sender, EventArgs e)
        {
            //try
            //{
            //    foreach (eGiangVien t in cbGiangVien.Items)
            //    {
            //        if (t.hoVaTen.Trim().ToUpper().Contains(cbGiangVien.Text.Trim().ToUpper()))
            //        {
            //            cbGiangVien.SelectedItem = t;
            //            return;
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{

            //}
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            //List<eNhomThucHanh> lst = lstTH;
            //eLopHocPhan lopHP = new eLopHocPhan();
            //lopHP.ID_LopHocPhan = tbID.Text.Trim();
            //lopHP.ID_HocPhan = cbMonHoc.SelectedValue.ToString();
            //lopHP.ID_NhanVienPDT = ((eNhanVienPDT)frmMain.Tk).id_NhanVien;
            //lopHP.ID_GiangVien = cbGiangVien.SelectedValue.ToString();
            //lopHP.ID_PhongHoc = cbPhongHoc.SelectedValue.ToString();
            //lopHP.HocPhan.TenMonHoc = cbPhongHoc.Text;
            //lopHP.NienKhoa.NienKhoa1 = cbNamHoc.Text;
            //lopHP.HocKy = int.Parse(cbHocKy.Text);
            //lopHP.LichHoc_LopHocPhan. = cbNgayHoc.Text;
            //lopHP.LichHoc_LopHocPhan = cbTietHoc.Text;
            //lopHP.tenGiangVien = cbGiangVien.Text;
            //lopHP.tenPhongHoc = cbPhongHoc.Text;
            //lopHP.trangThai = cbTrangThai.Text;
            //lopHP.NgayBD = dateTimePicker1.Value;
            //lopHP.NgayKT = dateTimePicker2.Value;
            //lopHP.ListNhomTH = lst;

            //NhomThucHanhBLL nhomTHBLL = new NhomThucHanhBLL();
            //if (groupBox1.Text == "Thêm Lớp Học Phần")
            //{
            //    if (LHP.AddLopHocPhan(lopHP.id_LopHocPhan, lopHP) == 1)
            //    {
            //        if (lopHP.ListNhomTH.Count != 0)
            //        {
            //            foreach (eNhomThucHanh x in lstTH)
            //            {
            //                if (nhomTHBLL.GetNhomByID(x.id_LopThucHanh) != null)
            //                {

            //                }
            //                else
            //                {
            //                    int a = nhomTHBLL.AddNewNhomThucHanh(x);
            //                }
            //            }
            //        }
            //        MessageBox.Show("Thêm Thành Công");
            //        ShowDataGrid();
            //    }
            //    else
            //        MessageBox.Show("Thêm Không Thành Công");

            //}
            //else
            //{

            //    if (LHP.EditLopHocPhan(lopHP.id_LopHocPhan, lopHP) == 1)
            //    {
            //        if (lopHP.ListNhomTH.Count != 0)
            //        {
            //            foreach (eNhomThucHanh x in lopHP.ListNhomTH)
            //            {
            //                if(nhomTHBLL.GetNhomByID(x.id_LopThucHanh)!=null)
            //                {
            //                    nhomTHBLL.EditNhomThucHanh(x);
            //                }else
            //                {
            //                    nhomTHBLL.AddNewNhomThucHanh(x);
            //                }        
            //            }
            //        }
            //        MessageBox.Show("Chỉnh Sửa Thành Công");
            //        ShowDataGrid();
            //    }
            //    else
            //        MessageBox.Show("Chỉnh Sửa Không Thành Công");
            //}
            //LHP = new LopHocPhanBLL();
            //LoadDanhSachLopHocPhan(LHP.SearchLopHocPhan(tbIDLopHPSearch.Text.Trim(), tbIDMonHocSearch.Text.Trim(), cbHocKiSearch.Text.ToString(), cbNamHocSearch.Text.ToString()));

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ShowDataGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadDanhSachLopHocPhan(LHP.SearchLopHocPhan(tbIDLopHPSearch.Text.Trim(), tbIDMonHocSearch.Text.Trim(), cbHocKiSearch.Text.ToString(), cbNamHocSearch.Text.ToString()));
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowSelected = dataGridView2.CurrentRow.Index;
            frmNhomThucHanh frm = new frmNhomThucHanh(dataGridView2.Rows[rowSelected].Cells[0].Value.ToString().Trim());
            frm.ShowDialog();
        }

        private void btnAddNhomTH_Click(object sender, EventArgs e)
        {
            frmNhomThucHanh frm = new frmNhomThucHanh();
            frm.ShowDialog();
        }

    }
}
