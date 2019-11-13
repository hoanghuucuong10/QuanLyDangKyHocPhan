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
using DKHP.ViewModels;
namespace DKHP
{
    public partial class frmNhomThucHanh : Form
    {
        NhomThucHanhBLL nTH = new NhomThucHanhBLL();
        public int flag { get; set; }
        public eNhomThucHanh nhomTH { get; set; }
        //thêm nhóm th
        public frmNhomThucHanh(string id_LopHP)
        {
            InitializeComponent();
            LoadCBB();
            LoadCBLich();
            this.flag = 0;
            btnXoa.Visible = false;
            nhomTH = new eNhomThucHanh();
            nhomTH.ID_LopHocPhan = id_LopHP;
            nhomTH.ID_NhomThucHanh = nTH.CreateID();
            nhomTH.LichHoc_NhomThucHanh = new List<eLichHoc_NhomThucHanh>();
            foreach (eNhomThucHanh x in frmLopHocPhan.instance.lstTH)
            {
                if (nhomTH.ID_NhomThucHanh == x.ID_NhomThucHanh)
                {
                    string id = nhomTH.ID_NhomThucHanh;
                    string numStr = id.Substring(2);
                    int num = int.Parse(numStr) + 1;

                    numStr = num.ToString();
                    while (numStr.Count() != 8)
                    {
                        numStr = "0" + numStr;
                    }
                    numStr = "th" + numStr;
                    nhomTH.ID_NhomThucHanh = numStr;
                }
            }
            tbIDTH.Text = nhomTH.ID_NhomThucHanh.Trim();
            tbMaLHP.Text = id_LopHP.Trim();

        }

        //sửa nhóm th
        public frmNhomThucHanh(eNhomThucHanh n)
        {
            InitializeComponent();
            LoadCBB();
            LoadCBLich();
            this.flag = 0;
            this.nhomTH = n;
            if(nhomTH.LichHoc_NhomThucHanh==null)
            {
                nhomTH.LichHoc_NhomThucHanh = new List<eLichHoc_NhomThucHanh>();
            }

            numNhom.Enabled = false;
            if (frmLopHocPhan.instance.GroupboxThongTin.Text == "Thông Tin Lớp Học Phần")
            {
                btnLuu.Visible = false;
                btnXoa.Visible = false;
                cbGiangVien.Enabled = true;
                numSoTiet.Enabled = true;
                numNhom.Enabled = true;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
            else
            {
                btnLuu.Visible = true;
                btnXoa.Visible = true;
                cbGiangVien.Enabled = false;
                numSoTiet.Enabled = false;
                numNhom.Enabled = false;
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
            tbIDTH.Text = n.ID_NhomThucHanh.Trim();
            tbMaLHP.Text = n.ID_LopHocPhan.Trim();

            cbGiangVien.SelectedValue = nhomTH.ID_GiangVien.Trim();
            numNhom.Value = int.Parse(nhomTH.TenNhom);
            numSoTiet.Value = nhomTH.SoTiet.Value;
            dateTimePicker1.Value = nhomTH.NgayBatDau.Value;
            dateTimePicker2.Value = nhomTH.NgayKetThuc.Value;


            LoadDSLichHocNhomTH();
        }
        
        public void LoadCBB()
        {
            GiangVienBLL gv = new GiangVienBLL();
            cbGiangVien.DataSource = gv.GetAllGiangVien();
            cbGiangVien.DisplayMember = "HoVaTen";
            cbGiangVien.ValueMember = "ID_GiangVien";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            nhomTH.ID_GiangVien = cbGiangVien.SelectedValue.ToString().Trim();
            nhomTH.TenNhom = numNhom.Value.ToString();
            nhomTH.SoTiet = int.Parse(numSoTiet.Value.ToString().Trim());
            nhomTH.SoLuong = new DangKyHocPhanBLL().SoLuongNhomTH(nhomTH.ID_NhomThucHanh);
            nhomTH.NgayBatDau = dateTimePicker1.Value;
            nhomTH.NgayKetThuc = dateTimePicker2.Value;
            
            List<eNhomThucHanh> lst = frmLopHocPhan.instance.lstTH;
            int f = 0;
            //nhóm thực hành đã có trong lst (chỉnh sửa nhóm thực hành)
            foreach (eNhomThucHanh x in lst)
            {
                if (nhomTH.ID_NhomThucHanh == x.ID_NhomThucHanh)
                {
                    x.ID_GiangVien = nhomTH.ID_GiangVien;
                    x.ID_LopHocPhan = nhomTH.ID_LopHocPhan;
                    x.LichHoc_NhomThucHanh = nhomTH.LichHoc_NhomThucHanh;
                    x.TenNhom = nhomTH.TenNhom;
                    x.SoLuong = nhomTH.SoLuong;
                    x.NgayBatDau = nhomTH.NgayBatDau;
                    x.NgayKetThuc = nhomTH.NgayKetThuc;
                    x.LichHoc_NhomThucHanh = nhomTH.LichHoc_NhomThucHanh;
                    f = 1;
                }
            }
            if (f == 0)//nhóm thực hành mới
            {
                lst.Add(nhomTH);
            }

            frmLopHocPhan.instance.lstTH = lst;
            frmLopHocPhan.instance.LoadDanhSachNhom(lst);
            frmLopHocPhan.instance.dgvNhomTH.Refresh();
            this.Close();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            List<eNhomThucHanh> lst = frmLopHocPhan.instance.lstTH;
            foreach (eNhomThucHanh t in lst)
            {
                if (t.ID_NhomThucHanh == nhomTH.ID_NhomThucHanh)
                {
                    lst.Remove(t);
                    break;
                }
            }
            frmLopHocPhan.instance.lstTH = lst;
            frmLopHocPhan.instance.LoadDanhSachNhom(lst);
            frmLopHocPhan.instance.dgvNhomTH.Refresh();
            this.Close();
        }
        //------------------------------------Lich Hoc Thuc Hanh------------------------------------------------
        #region LichHoc
        private void btnXoaLich_Click(object sender, EventArgs e)
        {
            if (nhomTH.LichHoc_NhomThucHanh.Count == 0)
            {
                MessageBox.Show("Không có lịch để xóa");
                return;
            }
            cbPhong.Enabled = false;
            cbNgayHoc.Enabled = false;
            cbTietHoc.Enabled = false;

            btnLuuLichHoc.Visible = false;
            btnHuyLuuLichHoc.Visible = false;
            btnThemLich.Visible = true;
            btnSuaLich.Visible = true;
            btnXoaLich.Visible = true;

            foreach (eLichHoc_NhomThucHanh x in nhomTH.LichHoc_NhomThucHanh)
            {
                if (x.ID_LichHoc_NhomTH == int.Parse(dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[3].Value.ToString().Trim()))
                {
                    nhomTH.LichHoc_NhomThucHanh.Remove(x);
                    break;
                }
            }

            LoadDSLichHocNhomTH();
        }

        private void btnSuaLich_Click(object sender, EventArgs e)
        {
            if (nhomTH.LichHoc_NhomThucHanh.Count == 0)
            {
                MessageBox.Show("Không có lịch để sửa");
                return;
            }
            this.flag = 1;
            cbPhong.Enabled = true;
            cbNgayHoc.Enabled = true;
            cbTietHoc.Enabled = true;

            btnLuuLichHoc.Visible = true;
            btnHuyLuuLichHoc.Visible = true;
            btnThemLich.Visible = false;
            btnSuaLich.Visible = false;
            btnXoaLich.Visible = false;

            try
            {
                cbNgayHoc.SelectedItem = dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[0].Value.ToString().Trim();
                cbTietHoc.SelectedItem = dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[1].Value.ToString().Trim();
                cbPhong.SelectedValue = dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[5].Value.ToString().Trim();
            }
            catch (Exception)
            {
            }
        }
        private void btnThemLich_Click(object sender, EventArgs e)
        {
            flag = 2;
            cbPhong.Enabled = true;
            cbNgayHoc.Enabled = true;
            cbTietHoc.Enabled = true;

            btnLuuLichHoc.Visible = true;
            btnHuyLuuLichHoc.Visible = true;
            btnThemLich.Visible = false;
            btnSuaLich.Visible = false;
            btnXoaLich.Visible = false;




        }
        private void btnLuuLichHoc_Click(object sender, EventArgs e)
        {
            cbPhong.Enabled = false;
            cbNgayHoc.Enabled = false;
            cbTietHoc.Enabled = false;

            btnLuuLichHoc.Visible = false;
            btnHuyLuuLichHoc.Visible = false;
            btnThemLich.Visible = true;
            btnSuaLich.Visible = true;
            btnXoaLich.Visible = true;


            //thêm
            if (this.flag == 2)
            {
                eLichHoc_NhomThucHanh lich = new eLichHoc_NhomThucHanh();

                lich.ID_LichHoc_NhomTH = -1;
           


                lich.ID_PhongHoc = cbPhong.SelectedValue.ToString().Trim();
                lich.TietHoc = cbTietHoc.SelectedItem.ToString();
                lich.NgayHoc = cbNgayHoc.SelectedItem.ToString();
                lich.ID_NhomThucHanh = tbIDTH.Text.Trim();

                //kiểm tra lịch trùng trong list lịch 
                int f = 0;
                if(nhomTH.LichHoc_NhomThucHanh!=null)
                {

                    foreach (eLichHoc_NhomThucHanh x in nhomTH.LichHoc_NhomThucHanh)
                    {
                        if (lich.ID_PhongHoc == x.ID_PhongHoc && lich.NgayHoc == x.NgayHoc && lich.TietHoc == x.TietHoc)
                        {
                            f = 1;
                            break;
                        }
                    }
                }
                if (f != 1)
                {
                    nhomTH.LichHoc_NhomThucHanh.Add(lich);
                }
                else
                {
                    MessageBox.Show("Lịch bị trùng");
                }
                LoadDSLichHocNhomTH();
                
            }
            else if (flag == 1)  // Sửa
            {
                int index = nhomTH.LichHoc_NhomThucHanh.IndexOf(nhomTH.LichHoc_NhomThucHanh.Where(x => x.ID_LichHoc_NhomTH == int.Parse(dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[3].Value.ToString().Trim())).FirstOrDefault());
                nhomTH.LichHoc_NhomThucHanh[index].NgayHoc = cbNgayHoc.SelectedItem.ToString().Trim();
                nhomTH.LichHoc_NhomThucHanh[index].TietHoc = cbTietHoc.SelectedItem.ToString().Trim();
                nhomTH.LichHoc_NhomThucHanh[index].ID_PhongHoc = cbPhong.SelectedValue.ToString().Trim();
                LoadDSLichHocNhomTH();
            }
        }
        public void LoadDSLichHocNhomTH()
        {
            List<LichHocTHViewModels> lss = nhomTH.LichHoc_NhomThucHanh.Select(x=>new LichHocTHViewModels {
                ID_LichHoc_NhomTH=x.ID_LichHoc_NhomTH,
                ID_NhomThucHanh=x.ID_NhomThucHanh,
                ID_PhongHoc=x.ID_PhongHoc,
                NgayHoc=x.NgayHoc,
                TenPhongHoc=new PhongHocBLL().GetPhongHocByID(x.ID_PhongHoc).TenPhongHoc.ToString().Trim(),
                TietHoc=x.TietHoc.Trim()
            }).ToList();
            lichHocTHViewModelsBindingSource.DataSource = null;
            lichHocTHViewModelsBindingSource.DataSource = lss;
        }
        private void btnHuyLuuLichHoc_Click(object sender, EventArgs e)
        {
            cbPhong.Enabled = false;
            cbNgayHoc.Enabled = false;
            cbTietHoc.Enabled = false;

            btnLuuLichHoc.Visible = false;
            btnHuyLuuLichHoc.Visible = false;
            btnThemLich.Visible = true;
            btnSuaLich.Visible = true;
            btnXoaLich.Visible = true;





        }
        //load dữ liệu cho combobox lịch học
        public void LoadCBLich()
        {
            #region TietHoc
            cbTietHoc.Items.Add("1-3");
            cbTietHoc.Items.Add("1-2");
            cbTietHoc.Items.Add("2-3");

            cbTietHoc.Items.Add("4-6");
            cbTietHoc.Items.Add("4-5");
            cbTietHoc.Items.Add("5-6");

            cbTietHoc.Items.Add("1-6");

            cbTietHoc.Items.Add("7-9");
            cbTietHoc.Items.Add("7-8");
            cbTietHoc.Items.Add("8-9");

            cbTietHoc.Items.Add("10-12");
            cbTietHoc.Items.Add("10-11");
            cbTietHoc.Items.Add("11-12");
            #endregion
            #region cbbngayHoc
            cbNgayHoc.Items.Add("Thứ Hai");
            cbNgayHoc.Items.Add("Thứ Ba");
            cbNgayHoc.Items.Add("Thứ Tư");
            cbNgayHoc.Items.Add("Thứ Năm");
            cbNgayHoc.Items.Add("Thứ Sáu");
            cbNgayHoc.Items.Add("Thứ Bảy");
            cbNgayHoc.Items.Add("Chủ Nhật");
            #endregion
            #region cbbPhongHoc
            cbPhong.DataSource = new PhongHocBLL().GetAllPhongHoc();
            cbPhong.DisplayMember = "TenPhongHoc";
            cbPhong.ValueMember = "ID_PhongHoc";
            #endregion
            cbTietHoc.SelectedIndex = 0;
            cbNgayHoc.SelectedIndex = 0;
        }

        #endregion

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //LoadFormThongTinLichLT();
            try
            {

                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    cbNgayHoc.SelectedItem = dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                    cbTietHoc.SelectedItem = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                    cbPhong.SelectedValue = dataGridView3.Rows[e.RowIndex].Cells[5].Value.ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(dataGridView3.Rows.Count.ToString());
            }
        }

        private void frmNhomThucHanh_Load(object sender, EventArgs e)
        {

        }
    }
}
