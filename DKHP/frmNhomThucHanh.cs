using BLL;
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
namespace DKHP
{
    public partial class frmNhomThucHanh : Form
    {
        public eNhomThucHanh lTH = new eNhomThucHanh();

        NhomThucHanhBLL nTH = new NhomThucHanhBLL();
        //thêm nhóm th
        public frmNhomThucHanh()
        {
            InitializeComponent();
            LoadCCB();
            btnXoa.Visible = false;
            lTH.ID_NhomThucHanh = nTH.CreateID();
            tbMaLHP.Text= frmLopHocPhan.instance.dataGridView1.Rows[frmLopHocPhan.instance.dataGridView1.CurrentRow.Index].Cells[10].Value.ToString().Trim();
            cbMonHoc.SelectedValue = frmLopHocPhan.instance.dataGridView1.Rows[frmLopHocPhan.instance.dataGridView1.CurrentRow.Index].Cells[10].Value.ToString().Trim();

        }

        //sửa nhóm th
        public frmNhomThucHanh(string id)
        {
            InitializeComponent();
            LoadCCB();
            lTH = nTH.GetNhomByID(id);
            tbMaLHP.Text = lTH.ID_LopHocPhan.Trim();
            numNhom.Enabled = false;
            if (frmLopHocPhan.instance.groupBox1.Text == "Thông Tin Lớp Học Phần")
            {
                btnLuu.Visible = false;
                btnXoa.Visible = false;
                cbMonHoc.Enabled = false;
                cbGiangVien.Enabled = false;
                cbNgayHoc.Enabled = false;
                cbPhongHoc.Enabled = false;
                cbTietHoc.Enabled = false;
                numNhom.Enabled = false;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }else
            {
                btnLuu.Visible = true;
                btnXoa.Visible = true;
                cbMonHoc.Enabled = false;
                cbGiangVien.Enabled = true;
                cbNgayHoc.Enabled = true;
                cbPhongHoc.Enabled = true;
                cbTietHoc.Enabled = true;
                numNhom.Enabled = false;
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }

            LopHocPhanBLL hpBLL = new LopHocPhanBLL();
            List<eLopHocPhan> s = hpBLL.SearchLopHocPhan(lTH.ID_LopHocPhan.Trim(), "", "", "");
            int a = cbMonHoc.ValueMember.IndexOf(s[0].ID_HocPhan.Trim());

            cbMonHoc.SelectedValue = frmLopHocPhan.instance.cbMonHoc.SelectedValue;
            cbGiangVien.SelectedValue = frmLopHocPhan.instance.dataGridView2.Rows[frmLopHocPhan.instance.dataGridView2.CurrentRow.Index].Cells[5].Value.ToString().Trim();
            numNhom.Value = int.Parse(frmLopHocPhan.instance.dataGridView2.Rows[frmLopHocPhan.instance.dataGridView2.CurrentRow.Index].Cells[4].Value.ToString().Trim());
            cbNgayHoc.SelectedItem = frmLopHocPhan.instance.dataGridView2.Rows[frmLopHocPhan.instance.dataGridView2.CurrentRow.Index].Cells[8].Value.ToString().Trim();
            cbTietHoc.SelectedItem = frmLopHocPhan.instance.dataGridView2.Rows[frmLopHocPhan.instance.dataGridView2.CurrentRow.Index].Cells[9].Value.ToString().Trim();
            cbPhongHoc.SelectedValue = (new PhongHocBLL().GetPhongHocByName( frmLopHocPhan.instance.dataGridView2.Rows[frmLopHocPhan.instance.dataGridView2.CurrentRow.Index].Cells[7].Value.ToString().Trim())).ID_PhongHoc.Trim();
            dateTimePicker1.Value = Convert.ToDateTime(frmLopHocPhan.instance.dataGridView2.Rows[frmLopHocPhan.instance.dataGridView2.CurrentRow.Index].Cells[10].Value.ToString().Trim());
            dateTimePicker2.Value = Convert.ToDateTime(frmLopHocPhan.instance.dataGridView2.Rows[frmLopHocPhan.instance.dataGridView2.CurrentRow.Index].Cells[11].Value.ToString().Trim());


        }
        public void LoadCCB()
        {
            cbNgayHoc.Items.Add("Thứ Hai");
            cbNgayHoc.Items.Add("Thứ Ba");
            cbNgayHoc.Items.Add("Thứ Tư");
            cbNgayHoc.Items.Add("Thứ Năm");
            cbNgayHoc.Items.Add("Thứ Sáu");
            cbNgayHoc.Items.Add("Thứ Bảy");
            cbNgayHoc.Items.Add("Chủ Nhật");

            GiangVienBLL gv = new GiangVienBLL();
            cbGiangVien.DataSource = gv.GetAllGiangVien();
            cbGiangVien.DisplayMember = "hoVaTen";
            cbGiangVien.ValueMember = "id_GiangVien";

            PhongHocBLL ph = new PhongHocBLL();
            cbPhongHoc.DataSource = ph.GetAllPhongHoc();
            cbPhongHoc.DisplayMember = "tenPhong";
            cbPhongHoc.ValueMember = "id_PhongHoc";


            HocPhanBLL hp = new HocPhanBLL();
            cbMonHoc.DataSource = hp.GetALLHocPhan();
            cbMonHoc.DisplayMember = "tenMonHoc";
            cbMonHoc.ValueMember = "id_HocPhan";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //string m= lTH.ID_NhomThucHanh;
            //lTH.ID_GiangVien = cbGiangVien.SelectedValue.ToString().Trim();
            //lTH.GiangVien.te = cbGiangVien.Text.ToString().Trim();
            //lTH.id_PhongHoc = cbPhongHoc.SelectedValue.ToString().Trim();
            //lTH.tenPhong = cbPhongHoc.Text.ToString().Trim();
            //lTH.ngayHoc = cbNgayHoc.SelectedItem.ToString().Trim();
            //lTH.tietHoc = cbTietHoc.SelectedItem.ToString().Trim();
            //lTH.id_LopHocPhan = frmLopHocPhan.instance.tbID.Text;
            //lTH.tenMonHoc = frmLopHocPhan.instance.cbMonHoc.Text.ToString().Trim();
            //lTH.tenNhom = int.Parse(numNhom.Value.ToString());
            //lTH.NgayBD = dateTimePicker1.Value;
            //lTH.NgayKT = dateTimePicker2.Value;
           
            //List<eNhomThucHanh> lst = frmLopHocPhan.instance.lstTH;
            //int flag = 0;
            //foreach (eNhomThucHanh x in lst)
            //{
            //    if (lTH.id_LopThucHanh == x.id_LopThucHanh)
            //    {
            //        x.id_GiangVien = lTH.id_GiangVien;
            //        x.id_LopHocPhan = lTH.id_LopHocPhan;
            //        x.id_PhongHoc = lTH.id_PhongHoc;
            //        x.ngayHoc = lTH.ngayHoc;
            //        x.tenGiangVien = lTH.tenGiangVien;
            //        x.tenMonHoc = lTH.tenMonHoc;
            //        x.tenNhom = lTH.tenNhom;
            //        x.tenPhong = lTH.tenPhong;
            //        x.tietHoc = lTH.tietHoc;
            //        x.NgayBD = lTH.NgayBD;
            //        x.NgayKT = lTH.NgayKT;
            //        flag = 1;
            //    }
            //}
            //if(flag==0)
            //{
            //    lst.Add(lTH);
            //}

            //frmLopHocPhan.instance.lstTH = lst;
            //frmLopHocPhan.instance.LoadDanhSachNhom(lst);
            //frmLopHocPhan.instance.dataGridView2.Refresh();
            //this.Close();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //if (nTH.DelNhomTH(lTH.id_LopThucHanh) == 1)
            //{
            //    MessageBox.Show("Xóa thành công!!!");
            //    this.Close();
            //    frmLopHocPhan.instance.LoadDanhSachNhom(nTH.GetNhomByIDLopHocPhan(frmLopHocPhan.instance.tbID.Text.Trim()));
            //}
            //else
            //{
            //    MessageBox.Show("Xóa không thành công!!!");
            //}

        }
    }
}
