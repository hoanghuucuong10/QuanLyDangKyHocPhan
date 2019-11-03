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
using DKHP.ViewModels;
namespace DKHP
{
    public partial class frmLopHocPhan : Form
    {
        private static frmLopHocPhan _instance;
        public List<eNhomThucHanh> lstTH = new List<eNhomThucHanh>();
        public List<eLichHoc_LopHocPhan> lstLichLT = new List<eLichHoc_LopHocPhan>();
        int flag;
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
            LoadDanhSachLopHocPhan(LHP.SearchLopHocPhan("", "", "", ""));
            LoadComboBox();
            LoadCBLichLyThuyet();

            flag = 0;


        }
        public void LoadLichHocLopHP()
        {
            List<LichHocLTViewModels> lst = lstLichLT.Select(t => new LichHocLTViewModels
            {
                ID_LichHoc_LopHP = t.ID_LichHoc_LopHP,
                ID_LopHocPhan = t.ID_LopHocPhan,
                ID_PhongHoc = t.ID_PhongHoc,
                TenPhongHoc = new PhongHocBLL().GetPhongHocByID(t.ID_PhongHoc).TenPhongHoc,
                NgayHoc = t.NgayHoc,
                TietHoc = t.TietHoc
            }).ToList();
            lichHocLTViewModelsBindingSource.DataSource = lst;
        }
        public void LoadDanhSachLopHocPhan(List<eLopHocPhan> lst)
        {
            List<LopHocPhanViewModels> ls = lst.Select(t => new LopHocPhanViewModels
            {
                HocKy = t.HocKy,
                ID_GiangVien = t.ID_GiangVien.Trim(),
                ID_HocPhan = t.ID_HocPhan.Trim(),
                ID_LopHocPhan = t.ID_LopHocPhan.Trim(),
                ID_NhanVienPDT = t.ID_NhanVienPDT.Trim(),
                ID_NienKhoa = t.ID_NienKhoa,
                NgayBatDau = t.NgayBatDau,
                NgayKetThuc = t.NgayKetThuc,
                NienKhoa = new NienKhoaBLL().GetNienKhoaByID(t.ID_NienKhoa.Value).NienKhoa1.Trim(),
                SoTiet = t.SoTiet.Value,
                SoLuong = t.SoLuong,
                TenGiangVien = new GiangVienBLL().GetGiangVienByID(t.ID_GiangVien.Trim()).HoVaTen.Trim(),
                TenMonHoc = new HocPhanBLL().GetHocPhanByID(t.ID_HocPhan).TenMonHoc.Trim(),
                TrangThai = t.TrangThai.Trim()
            }).ToList();
            lopHocPhanViewModelsBindingSource.DataSource = ls;
        }
        public void LoadDanhSachNhom(List<eNhomThucHanh> lst)
        {
            List<NhomThucHanhViewModels> ls = lst.Select(m => new NhomThucHanhViewModels
            {
                ID_NhomThucHanh = m.ID_NhomThucHanh,
                ID_LopHocPhan = m.ID_LopHocPhan,
                TenNhom = m.TenNhom,
                ID_GiangVien = m.ID_GiangVien,
                NgayBatDau = m.NgayBatDau,
                NgayKetThuc = m.NgayKetThuc,
                SoLuong = m.SoLuong,
                SoTiet = m.SoTiet,
                TenGiangVien = new GiangVienBLL().GetGiangVienByID(m.ID_GiangVien).HoVaTen
            }).ToList();

            nhomThucHanhViewModelsBindingSource.DataSource = ls;
        }
        public void XemThongTin()
        {
            btnAddNhomTH.Visible = false;
            btnHuy.Visible = false;
            btnLuu.Visible = false;
            GroupboxThongTin.Text = "Thông Tin Lớp Học Phần";
            ShowDataGrid();
            cbMonHoc.Enabled = false;
            cbGiangVien.Enabled = false;
            cbHocKy.Enabled = false;
            cbNamHoc.Enabled = false;

            cbTrangThai.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;

            cbPhong.Enabled = false;
            cbTietHoc.Enabled = false;
            cbNgayHoc.Enabled = false;
            btnThemLich.Visible = false;
            btnHuyLuuLichHoc.Visible = false;
            btnLuuLichHoc.Visible = false;
            btnXoaLich.Visible = false;
            btnSuaLich.Visible = false;

        }
        public void Them()
        {
            GroupboxThongTin.Text = "Thêm Lớp Học Phần";
            tbID.Text = LHP.CreateID();
            lstTH = new List<eNhomThucHanh>();
            LoadDanhSachNhom(lstTH);
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
            GroupboxThongTin.Text = "Chỉnh Sửa Lớp Học Phần";
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
            GiangVienBLL gv = new GiangVienBLL();
            cbGiangVien.DataSource = gv.GetAllGiangVien();
            cbGiangVien.DisplayMember = "HoVaTen";
            cbGiangVien.ValueMember = "ID_GiangVien";

            HocPhanBLL hp = new HocPhanBLL();
            cbMonHoc.DataSource = hp.GetALLHocPhan();
            cbMonHoc.DisplayMember = "TenMonHoc";
            cbMonHoc.ValueMember = "ID_HocPhan";

            cbNamHoc.DataSource = new NienKhoaBLL().GetAllNienKhoa();
            cbNamHoc.DisplayMember = "NienKhoa1";
            cbNamHoc.ValueMember = "ID_NienKhoa";

            cbNamHocSearch.DataSource = new NienKhoaBLL().GetAllNienKhoa();
            cbNamHocSearch.DisplayMember = "NienKhoa1";
            cbNamHocSearch.ValueMember = "ID_NienKhoa";


        }
        private void ShowDataGrid()
        {
            if (GroupboxThongTin.Text != "Thêm Lớp Học Phần")
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

                cbMonHoc.SelectedValue = dataGridView1.Rows[rowSelected].Cells[13].Value.ToString().Trim();
                cbGiangVien.SelectedValue = dataGridView1.Rows[rowSelected].Cells[11].Value.ToString().Trim();
                cbHocKy.SelectedItem = dataGridView1.Rows[rowSelected].Cells[3].Value.ToString().Trim();
                cbNamHoc.SelectedValue = int.Parse(dataGridView1.Rows[rowSelected].Cells[12].Value.ToString().Trim());

                cbTrangThai.SelectedItem = dataGridView1.Rows[rowSelected].Cells[7].Value.ToString().Trim();
                DateTime x = Convert.ToDateTime(dataGridView1.Rows[rowSelected].Cells[8].Value.ToString().Trim());
                dateTimePicker1.Value = x;
                x = Convert.ToDateTime(dataGridView1.Rows[rowSelected].Cells[9].Value.ToString().Trim());
                dateTimePicker2.Value = x;

                lstLichLT = new LichHocBLL().GetLichHoc_LopHocPhan(tbID.Text.Trim());
                LoadLichHocLopHP();
            }
            else
            {

            }
        }
        private void cbGiangVien_Leave(object sender, EventArgs e)
        {
            try
            {
                foreach (eGiangVien t in cbGiangVien.Items)
                {
                    if (t.HoVaTen.Trim().ToUpper().Contains(cbGiangVien.Text.Trim().ToUpper()))
                    {
                        cbGiangVien.SelectedItem = t;
                        return;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }


        //xem, chỉnh sửa thông tin nhóm thực hành
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowSelected = dataGridView2.CurrentRow.Index;
            eNhomThucHanh n = new eNhomThucHanh();
            n.ID_GiangVien = dataGridView2.Rows[rowSelected].Cells[8].Value.ToString().Trim();
            n.ID_LopHocPhan = dataGridView2.Rows[rowSelected].Cells[1].Value.ToString().Trim();
            n.ID_NhomThucHanh = dataGridView2.Rows[rowSelected].Cells[0].Value.ToString().Trim();
            n.NgayBatDau = DateTime.Parse(dataGridView2.Rows[rowSelected].Cells[6].Value.ToString().Trim());
            n.NgayKetThuc = DateTime.Parse(dataGridView2.Rows[rowSelected].Cells[7].Value.ToString().Trim());
            n.SoLuong = int.Parse(dataGridView2.Rows[rowSelected].Cells[5].Value.ToString().Trim());
            n.SoTiet = int.Parse(dataGridView2.Rows[rowSelected].Cells[4].Value.ToString().Trim());
            n.TenNhom = dataGridView2.Rows[rowSelected].Cells[3].Value.ToString().Trim();

            frmNhomThucHanh frm = new frmNhomThucHanh(n);
            frm.ShowDialog();
        }

        private void btnAddNhomTH_Click(object sender, EventArgs e)
        {
            frmNhomThucHanh frm = new frmNhomThucHanh(tbID.Text.Trim());
            frm.ShowDialog();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            LoadDanhSachLopHocPhan(LHP.SearchLopHocPhan(tbIDLopHPSearch.Text.Trim(), tbTenMonHocSearch.Text.Trim(), cbHocKiSearch.Text.ToString(), cbNamHocSearch.Text.ToString()));

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnHuy.Visible = true;
            btnLuu.Visible = true;
            btnThem.Visible = false;
            btnSua.Visible = false;
            instance.Them();

            cbPhong.Enabled = true;
            cbTietHoc.Enabled = true;
            cbNgayHoc.Enabled = true;
            btnThemLich.Visible = true;
            btnHuyLuuLichHoc.Visible = false;
            btnLuuLichHoc.Visible = false;
            btnXoaLich.Visible = true;
            btnSuaLich.Visible = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnHuy.Visible = true;
            btnLuu.Visible = true;
            btnThem.Visible = false;
            btnSua.Visible = false;
            instance.ChinhSua();

            cbPhong.Enabled = true;
            cbTietHoc.Enabled = true;
            cbNgayHoc.Enabled = true;
            btnThemLich.Visible = true;
            btnHuyLuuLichHoc.Visible = false;
            btnLuuLichHoc.Visible = false;
            btnXoaLich.Visible = true;
            btnSuaLich.Visible = true;

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            eLopHocPhan lopHP = new eLopHocPhan();
            lopHP.ID_LopHocPhan = tbID.Text.Trim();
            lopHP.ID_HocPhan = cbMonHoc.SelectedValue.ToString().Trim();
            lopHP.HocKy = int.Parse(cbHocKy.SelectedItem.ToString().Trim());
            lopHP.ID_NienKhoa = int.Parse(cbNamHoc.SelectedValue.ToString().Trim());
            lopHP.ID_NhanVienPDT = ((eNhanVienPDT)frmMain.Tk).ID_NhanVienPDT.Trim();
            lopHP.ID_GiangVien = cbGiangVien.SelectedValue.ToString().Trim();
            lopHP.TrangThai = cbTrangThai.SelectedItem.ToString();
            lopHP.NgayBatDau = dateTimePicker1.Value;
            lopHP.NgayKetThuc = dateTimePicker2.Value;
            lopHP.SoTiet=int.Parse(numSoTiet.Value.ToString().Trim());

            if(GroupboxThongTin.Text== "Thêm Lớp Học Phần")
            {
                new LopHocPhanBLL().AddLopHocPhan(lopHP);
                foreach(eNhomThucHanh m in lstTH)
                {
                    new NhomThucHanhBLL().AddNewNhomThucHanh(m);

                    foreach(eLichHoc_NhomThucHanh n in m.LichHoc_NhomThucHanh)
                    {
                        new LichHocBLL().AddLichTH(n);
                    }
                }
                foreach(eLichHoc_LopHocPhan n in lstLichLT)
                {
                    new LichHocBLL().AddLichLT(n);
                }
                MessageBox.Show("Thêm Thành Công");
                LoadDanhSachLopHocPhan(new LopHocPhanBLL().GetAllLopHocPhan());
            }
           




            cbPhong.Enabled = true;
            cbTietHoc.Enabled = true;
            cbNgayHoc.Enabled = true;
            btnThemLich.Visible = true;
            btnHuyLuuLichHoc.Visible = false;
            btnLuuLichHoc.Visible = false;
            btnXoaLich.Visible = true;
            btnSuaLich.Visible = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            instance.XemThongTin();
            ShowDataGrid();

            lstTH = new List<eNhomThucHanh>();
            LoadDanhSachNhom(lstTH);

            tbID.Text = LHP.CreateID();
            cbMonHoc.Text = "";
            cbGiangVien.Text = "";
            cbHocKy.SelectedIndex = -1;
            cbNamHoc.SelectedIndex = -1;
            cbTrangThai.SelectedIndex = 0;

            btnHuy.Visible = false;
            btnLuu.Visible = false;
            btnThem.Visible = true;
            btnSua.Visible = true;
            instance.XemThongTin();

            cbPhong.Enabled = false;
            cbTietHoc.Enabled = false;
            cbNgayHoc.Enabled = false;
            btnThemLich.Visible = false;
            btnHuyLuuLichHoc.Visible = false;
            btnLuuLichHoc.Visible = false;
            btnXoaLich.Visible = false;
            btnSuaLich.Visible = false;
        }



        //----------------------------------------Lịch Học Lý Thuyết--------------------------------------------------------
        #region LichHocLyThuyet
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
        private void btnXoaLich_Click(object sender, EventArgs e)
        {
            if (lstLichLT.Count == 0)
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

            foreach (eLichHoc_LopHocPhan x in lstLichLT)
            {
                if (x.ID_LichHoc_LopHP == int.Parse(dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[3].Value.ToString().Trim()))
                {
                    lstLichLT.Remove(x);
                    break;
                }
            }
            LoadLichHocLopHP();
        }

        private void btnSuaLich_Click(object sender, EventArgs e)
        {
            if (lstLichLT.Count == 0)
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
            this.flag = 2;
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
                eLichHoc_LopHocPhan lich = new eLichHoc_LopHocPhan();

                lich.ID_LichHoc_LopHP = new LichHocBLL().GetLichHoc_LopHocPhan(tbID.Text.Trim()).Count;
                foreach (eLichHoc_LopHocPhan x in lstLichLT)
                {
                    if (lich.ID_LichHoc_LopHP == x.ID_LichHoc_LopHP)
                    {
                        lich.ID_LichHoc_LopHP++;
                    }
                }

                lich.ID_PhongHoc = cbPhong.SelectedValue.ToString().Trim();
                lich.TietHoc = cbTietHoc.SelectedItem.ToString();
                lich.NgayHoc = cbNgayHoc.SelectedItem.ToString();
                lich.ID_LopHocPhan = tbID.Text.Trim();

                //kiểm tra lịch trùng trong list lịch lý thuyết 
                int f = 0;
                foreach (eLichHoc_LopHocPhan x in lstLichLT)
                {
                    if (lich.ID_PhongHoc == x.ID_PhongHoc && lich.NgayHoc == x.NgayHoc && lich.TietHoc == x.TietHoc)
                    {
                        f = 1;
                        break;
                    }
                }
                if (f != 1)
                {
                    lstLichLT.Add(lich);
                }
                else
                {
                    MessageBox.Show("Lịch bị trùng");
                }
                LoadLichHocLopHP();

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
            else if (flag == 1)  // Sửa
            {


                int index = lstLichLT.IndexOf(lstLichLT.Where(x => x.ID_LichHoc_LopHP == int.Parse(dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[3].Value.ToString().Trim())).FirstOrDefault());
                lstLichLT[index].NgayHoc = cbNgayHoc.SelectedItem.ToString().Trim();
                lstLichLT[index].TietHoc = cbTietHoc.SelectedItem.ToString().Trim();
                lstLichLT[index].ID_PhongHoc = cbPhong.SelectedValue.ToString().Trim();

                LoadLichHocLopHP();
            }
        }

        private void btnHuyLuuLichHoc_Click(object sender, EventArgs e)
        {
            this.flag = 0;
            cbPhong.Enabled = false;
            cbNgayHoc.Enabled = false;
            cbTietHoc.Enabled = false;

            btnLuuLichHoc.Visible = false;
            btnHuyLuuLichHoc.Visible = false;
            btnThemLich.Visible = true;
            btnSuaLich.Visible = true;
            btnXoaLich.Visible = true;

        }
        //load dữ liệu cho combobox lịch học lý thuyết
        public void LoadCBLichLyThuyet()
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


    }
}
