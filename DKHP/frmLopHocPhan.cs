﻿using System;
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
        public int flagChinhsua = 0;

        public List<int> lstDelLichLT;
        public List<int> lstDelLichTH;
        public List<string> lstDelNhomTH;

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


        string _idPhongHoc = "";
        string _idGiangVien = "";
        string _namHoc = "";
        int _hocKy = 0;
        public frmLopHocPhan()
        {
            InitializeComponent();
            LoadDanhSachLopHocPhan(LHP.SearchLopHocPhan("", "", "", ""));
            LoadComboBox();
            LoadCBLichLyThuyet();
            flag = 0;

            lstDelLichLT = new List<int>();
            lstDelLichTH = new List<int>();
            lstDelNhomTH = new List<string>();
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
            GroupboxThongTin.Text = "Thông Tin Lớp Học Phần";
            txtID.Enabled = false;
            cbMonHoc.Enabled = false;
            cbGiangVien.Enabled = false;
            cbMaMH.Enabled = false;
            cbMaGV.Enabled = false;

            cbHocKy.Enabled = false;
            cbNamHoc.Enabled = false;
            cbTrangThai.Enabled = false;
            numSoTiet.Enabled = false;
            timeBD.Enabled = false;
            timeKT.Enabled = false;

            btnHuyLuuLichHoc.Visible = false;
            btnLuuLichHoc.Visible = false;
            btnThemLich.Visible = false;
            btnSuaLich.Visible = false;
            btnXoaLich.Visible = false;
            btnAddNhomTH.Visible = false;
            cbNgayHoc.Enabled = false;
            cbTietHoc.Enabled = false;
            cbPhong.Enabled = false;

            btnHuy.Visible = false;
            btnLuu.Visible = false;
            btnThem.Visible = true;
            btnSua.Visible = true;


            ShowDataGrid();

        }
        public void Them()
        {
            GroupboxThongTin.Text = "Thêm Lớp Học Phần";
            txtID.Text = LHP.CreateID();
            lstTH = new List<eNhomThucHanh>();
            lstLichLT = new List<eLichHoc_LopHocPhan>();
            nhomThucHanhViewModelsBindingSource.DataSource = null;
            lichHocLTViewModelsBindingSource.DataSource = null;

            txtID.Enabled = false;
            cbMonHoc.Enabled = true;
            cbGiangVien.Enabled = true;
            cbMaMH.Enabled = true;
            cbMaGV.Enabled = true;

            cbHocKy.Enabled = true;
            cbNamHoc.Enabled = true;
            cbTrangThai.Enabled = false;
            numSoTiet.Enabled = true;
            timeBD.Enabled = true;
            timeKT.Enabled = true;

            btnHuyLuuLichHoc.Visible = false;
            btnLuuLichHoc.Visible = false;
            btnThemLich.Visible = true;
            btnSuaLich.Visible = true;
            btnXoaLich.Visible = true;
            cbNgayHoc.Enabled = false;
            cbTietHoc.Enabled = false;
            cbPhong.Enabled = false;

            btnAddNhomTH.Visible = true;

            btnHuy.Visible = true;
            btnLuu.Visible = true;
            btnThem.Visible = false;
            btnSua.Visible = false;

            cbTrangThai.SelectedIndex = 0;



        }
        public void ChinhSua()
        {
            GroupboxThongTin.Text = "Chỉnh Sửa Lớp Học Phần";

            txtID.Enabled = false;

            cbMonHoc.Enabled = true;
            cbGiangVien.Enabled = true;
            cbMaMH.Enabled = true;
            cbMaGV.Enabled = true;

            cbHocKy.Enabled = true;
            cbNamHoc.Enabled = true;
            cbTrangThai.Enabled = true;
            numSoTiet.Enabled = true;
            timeBD.Enabled = true;
            timeKT.Enabled = true;

            btnHuyLuuLichHoc.Visible = false;
            btnLuuLichHoc.Visible = false;
            btnThemLich.Visible = true;
            btnSuaLich.Visible = true;
            btnXoaLich.Visible = true;
            cbNgayHoc.Enabled = false;
            cbTietHoc.Enabled = false;
            cbPhong.Enabled = false;


            btnAddNhomTH.Visible = true;

            btnHuy.Visible = true;
            btnLuu.Visible = true;
            btnThem.Visible = false;
            btnSua.Visible = false;

            if (cbTrangThai.SelectedItem.ToString() != "Lên Kế Hoạch" && cbTrangThai.SelectedItem.ToString()!="Đã Hủy") 
            {
                btnHuyLuuLichHoc.Visible = false;
                btnLuuLichHoc.Visible = false;
                btnThemLich.Visible = false;
                btnSuaLich.Visible = false;
                btnXoaLich.Visible = false;
                btnAddNhomTH.Visible = false;
                cbGiangVien.Enabled = false;
                cbMaGV.Enabled = false;
                numSoTiet.Enabled = false;
                cbMaMH.Enabled = false;
                cbMonHoc.Enabled = false;
                cbHocKy.Enabled = false;
                cbNamHoc.Enabled = false;
                timeBD.Enabled = false;
                timeKT.Enabled = false;


            }


        }
        private void dgvLopHocPhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GroupboxThongTin.Text != "Chỉnh Sửa Lớp Học Phần")
            {
                ShowDataGrid();
            }

        }
        private void LoadComboBox()
        {
            GiangVienBLL gv = new GiangVienBLL();
            cbGiangVien.DataSource = gv.GetAllGiangVien();
            cbGiangVien.DisplayMember = "HoVaTen";
            cbGiangVien.ValueMember = "ID_GiangVien";
            cbGiangVien.SelectedIndex = 1;


            cbMaGV.DataSource = gv.GetAllGiangVien();
            cbMaGV.ValueMember = "HoVaTen";
            cbMaGV.DisplayMember = "ID_GiangVien";
            cbMaGV.SelectedIndex = 1;

            HocPhanBLL hp = new HocPhanBLL();
            cbMonHoc.DataSource = hp.GetALLHocPhan();
            cbMonHoc.DisplayMember = "TenMonHoc";
            cbMonHoc.ValueMember = "ID_HocPhan";

            cbMaMH.DataSource = hp.GetALLHocPhan();
            cbMaMH.ValueMember = "TenMonHoc";
            cbMaMH.DisplayMember = "ID_HocPhan";

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
                    rowSelected = dgvLopHocPhan.CurrentRow.Index;
                }
                catch (Exception e)
                {

                }
                txtID.Text = dgvLopHocPhan.Rows[rowSelected].Cells[0].Value.ToString().Trim();
                lstTH = (new NhomThucHanhBLL()).GetNhomByIDLopHocPhan(txtID.Text);
                LoadDanhSachNhom(lstTH);

                cbMonHoc.SelectedValue = dgvLopHocPhan.Rows[rowSelected].Cells[13].Value.ToString().Trim();
                cbGiangVien.SelectedValue = dgvLopHocPhan.Rows[rowSelected].Cells[11].Value.ToString().Trim();
                cbHocKy.SelectedItem = dgvLopHocPhan.Rows[rowSelected].Cells[3].Value.ToString().Trim();
                cbNamHoc.SelectedValue = int.Parse(dgvLopHocPhan.Rows[rowSelected].Cells[12].Value.ToString().Trim());
                cbMaMH.SelectedItem = ((eHocPhan)(cbMonHoc.SelectedItem));
                cbMaGV.SelectedItem = ((eGiangVien)(cbGiangVien.SelectedItem));

                numSoTiet.Value = int.Parse(dgvLopHocPhan.Rows[rowSelected].Cells[5].Value.ToString().Trim());
                cbTrangThai.SelectedItem = dgvLopHocPhan.Rows[rowSelected].Cells[7].Value.ToString().Trim();
                DateTime x = Convert.ToDateTime(dgvLopHocPhan.Rows[rowSelected].Cells[8].Value.ToString().Trim());
                timeBD.Value = x;
                x = Convert.ToDateTime(dgvLopHocPhan.Rows[rowSelected].Cells[9].Value.ToString().Trim());
                timeKT.Value = x;

                lstLichLT = new LichHocBLL().GetLichHoc_LopHocPhan(txtID.Text.Trim());

                _idPhongHoc = cbPhong.SelectedValue.ToString();
                _idGiangVien = cbGiangVien.SelectedValue.ToString().Trim();
                _namHoc = cbNamHoc.SelectedValue.ToString().Trim();
                _hocKy = int.Parse(cbHocKy.SelectedItem.ToString().Trim());

                LoadLichHocLopHP();
            }
            else
            {

            }
        }



        //xem, chỉnh sửa thông tin nhóm thực hành
        private void dgvNhomTH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowSelected = dgvNhomTH.CurrentRow.Index;
                eNhomThucHanh n = new eNhomThucHanh();
                foreach (eNhomThucHanh x in lstTH)
                {
                    if (x.ID_NhomThucHanh == dgvNhomTH.Rows[rowSelected].Cells[0].Value.ToString().Trim())
                    {
                        n = x;
                        break;
                    }
                }
                if (n.LichHoc_NhomThucHanh == null)
                {
                    n.LichHoc_NhomThucHanh = new LichHocBLL().GetLichHoc_NhomThucHanh(n.ID_NhomThucHanh);
                }
                frmNhomThucHanh frm = new frmNhomThucHanh(n);
                frm.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            } 
        }

        private void btnAddNhomTH_Click(object sender, EventArgs e)
        {
            frmNhomThucHanh frm = new frmNhomThucHanh(txtID.Text.Trim());
            frm.ShowDialog();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            LoadDanhSachLopHocPhan(LHP.SearchLopHocPhan(txtIDLopHPSearch.Text.Trim(), txtTenMonHocSearch.Text.Trim(), cbHocKiSearch.Text.ToString(), cbNamHocSearch.Text.ToString()));

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            instance.Them();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(cbTrangThai.SelectedItem.ToString()=="Đã Mở Lớp" )
            {
                MessageBox.Show("Lớp học phần đang trong trạng thái "+ cbTrangThai.SelectedItem.ToString().Trim()+" không thể chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            instance.ChinhSua();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            eLopHocPhan lopHP = new eLopHocPhan();
            lopHP.ID_LopHocPhan = txtID.Text.Trim();
            lopHP.ID_HocPhan = cbMonHoc.SelectedValue.ToString().Trim();
            lopHP.HocKy = int.Parse(cbHocKy.SelectedItem.ToString().Trim());
            lopHP.ID_NienKhoa = int.Parse(cbNamHoc.SelectedValue.ToString().Trim());
            lopHP.ID_NhanVienPDT = ((eNhanVienPDT)frmMain.Tk).ID_NhanVienPDT.Trim();
            lopHP.ID_GiangVien = cbGiangVien.SelectedValue.ToString().Trim();
            lopHP.TrangThai = cbTrangThai.SelectedItem.ToString();
            lopHP.NgayBatDau = timeBD.Value;
            lopHP.NgayKetThuc = timeKT.Value;
            lopHP.SoTiet = int.Parse(numSoTiet.Value.ToString().Trim());
            if(lopHP.NgayBatDau>lopHP.NgayKetThuc)
            {
                MessageBox.Show("Ngày bắt đầu và ngày kết thúc không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dgvLichLT.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm lịch học lý thuyết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            if (GroupboxThongTin.Text == "Thêm Lớp Học Phần")
            {
                new LopHocPhanBLL().AddLopHocPhan(lopHP); //them lớp học phần
                foreach (eNhomThucHanh m in lstTH) //thêm nhóm thực hành
                {
                    new NhomThucHanhBLL().AddNewNhomThucHanh(m);

                    foreach (eLichHoc_NhomThucHanh n in m.LichHoc_NhomThucHanh) // thêm lịch của nhóm th
                    {
                        new LichHocBLL().AddLichTH(n);
                    }
                }
                foreach (eLichHoc_LopHocPhan n in lstLichLT) //thêm lịch lý thuyết
                {
                    int k = new LichHocBLL().AddLichLT(n);
                }
                MessageBox.Show("Thêm Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadDanhSachLopHocPhan(new LopHocPhanBLL().GetAllLopHocPhan());
                this.XemThongTin();
                ShowDataGrid();
            }
            else //------------------------------chỉnh sửa lớp học phần----------------------------------------------
            {

                if (GroupboxThongTin.Text == "Chỉnh Sửa Lớp Học Phần")
                {
                    string trangThai = LHP.GetTrangThai(txtID.Text.Trim()).Trim();
                    if(trangThai=="Đã Hủy")
                    {
                        bool kq = new LopHocPhanBLL().HuyLopHP(txtID.Text.Trim());
                    }
                    switch (trangThai)
                    {
                        case "":
                            {
                                MessageBox.Show("Vui lòng chọn trạng thái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        case "Chờ Sinh Viên Đăng Ký":
                            {
                                int soLuongDK = new DangKyHocPhanBLL().SoLuong(txtID.Text.Trim());
                                if (soLuongDK > 0) // đã có sinh viên đăng ký chỉ có thể chuyển sang trạng thái đã mở lớp
                                {
                                    if (cbTrangThai.SelectedItem.ToString() == "Đã Mở Lớp")
                                    {
                                        if(soLuongDK<30)
                                        {
                                            MessageBox.Show("Lớp học phần không đủ số lượng đăng ký, không thể mở lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            cbTrangThai.SelectedItem = "Chờ Sinh Viên Đăng Ký";
                                            return;
                                        }
                                    }else if(cbTrangThai.SelectedItem.ToString()!="Chờ Sinh Viên Đăng Ký")
                                    {
                                        MessageBox.Show("Lớp học phần đã có sinh viên đăng ký, không thể chuyển sang trạng thái "+ cbTrangThai.SelectedItem.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        cbTrangThai.SelectedItem = "Chờ Sinh Viên Đăng Ký";
                                        return;
                                    }
                                }
                                else //chưa có sinh viên đăng ký, có thể chuyển trạng thái (không thể chuyển sang đã mở lớp)
                                {
                                    if(cbTrangThai.SelectedItem.ToString() == "Đã Mở Lớp")
                                    {
                                        MessageBox.Show("Lớp học phần không đủ số lượng đăng ký, không thể mở lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        cbTrangThai.SelectedItem = "Chờ Sinh Viên Đăng Ký";
                                        return;
                                    }
                                }
                                break;
                            }
                        case "Đã Mở Lớp"://đã mở lớp không thể hủy, không thể chuyển trạng thái
                            {
                                if (cbTrangThai.SelectedItem.ToString() != "Đã Mở Lớp")
                                {
                                    MessageBox.Show("Lớp học phần đã mở không thể chỉnh sửa trạng thái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    cbTrangThai.SelectedItem = "Đã Mở Lớp";
                                    return;
                                }
                                break;
                            }
                        case "Đã Hủy":
                            {

                                if (cbTrangThai.SelectedItem.ToString() != "Đã Hủy" && cbTrangThai.SelectedItem.ToString()!="Lên Kế Hoạch")
                                {
                                    MessageBox.Show("Lớp học phần đã hủy không thể chỉnh sửa sang trạng thái "+ cbTrangThai.SelectedItem.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    cbTrangThai.SelectedItem = "Đã Hủy";
                                    return;
                                }
                                break;
                            }

                        case "Lên Kế Hoạch":
                            {
                                if (cbTrangThai.SelectedItem.ToString() == "Đã Mở Lớp")
                                {
                                    MessageBox.Show("Lớp học phần đang lên kế hoạch không thể chuyển sang trạng thái "+ cbTrangThai.SelectedItem.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    cbTrangThai.SelectedItem = "Lên Kế Hoạch";
                                    return;
                                }
                                break;
                            }
                    }
                }
                



                new LopHocPhanBLL().EditLopHocPhan(lopHP);

                foreach (eNhomThucHanh m in lstTH) //thêm nhóm thực hành
                {
                    new NhomThucHanhBLL().EditNhomThucHanh(m); //chưa có thì thêm mới, có rồi thì chỉnh sửa

                    if (m.LichHoc_NhomThucHanh != null)
                    {
                        foreach (eLichHoc_NhomThucHanh n in m.LichHoc_NhomThucHanh) // thêm lịch của nhóm th
                        {
                            new LichHocBLL().EditLichTH(n);
                        }
                    }
                }
                if (lstLichLT != null)
                {

                    foreach (eLichHoc_LopHocPhan n in lstLichLT) //thêm lịch lý thuyết
                    {
                        new LichHocBLL().EditLichLT(n);
                    }
                }
                //xóa
                foreach (int a in lstDelLichLT)
                {
                    if (a != -1)
                        new LichHocBLL().DelLichLT(a);

                }
                foreach (int a in lstDelLichTH)
                {
                    if (a != -1)
                        new LichHocBLL().DelLichTH(a);

                }
                foreach (string a in lstDelNhomTH)
                {
                    new NhomThucHanhBLL().DelNhomTH(a);
                }
                lstDelNhomTH.Clear();
                lstDelLichTH.Clear();
                lstDelLichLT.Clear();


                MessageBox.Show("Chỉnh sửa Thành Công");
                this.XemThongTin();
                LoadDanhSachLopHocPhan(new LopHocPhanBLL().GetAllLopHocPhan());
                ShowDataGrid();
            }


        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            instance.XemThongTin();
            lstDelNhomTH.Clear();
            lstDelLichTH.Clear();
            lstDelLichLT.Clear();

        }



        //----------------------------------------Lịch Học Lý Thuyết--------------------------------------------------------
        #region LichHocLyThuyet
        private void dgvLichLT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //LoadFormThongTinLichLT();
            try
            {

                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    cbNgayHoc.SelectedItem = dgvLichLT.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                    cbTietHoc.SelectedItem = dgvLichLT.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                    cbPhong.SelectedValue = dgvLichLT.Rows[e.RowIndex].Cells[5].Value.ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(dgvLichLT.Rows.Count.ToString());
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
                if (x.ID_LichHoc_LopHP == int.Parse(dgvLichLT.Rows[dgvLichLT.CurrentRow.Index].Cells[3].Value.ToString().Trim()))
                {
                    lstLichLT.Remove(x);
                    lstDelLichLT.Add(x.ID_LichHoc_LopHP);
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
                cbNgayHoc.SelectedItem = dgvLichLT.Rows[dgvLichLT.CurrentRow.Index].Cells[0].Value.ToString().Trim();
                cbTietHoc.SelectedItem = dgvLichLT.Rows[dgvLichLT.CurrentRow.Index].Cells[1].Value.ToString().Trim();
                cbPhong.SelectedValue = dgvLichLT.Rows[dgvLichLT.CurrentRow.Index].Cells[5].Value.ToString().Trim();
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

            eLichHoc_LopHocPhan lich = new eLichHoc_LopHocPhan();
            lich.ID_PhongHoc = cbPhong.SelectedValue.ToString().Trim();
            lich.TietHoc = cbTietHoc.SelectedItem.ToString();
            lich.NgayHoc = cbNgayHoc.SelectedItem.ToString();
            lich.ID_LopHocPhan = txtID.Text.Trim();

            //thêm lịch
            if (this.flag == 2)
            {


                lich.ID_LichHoc_LopHP = -1;

                foreach (eLichHoc_LopHocPhan x in lstLichLT)
                {
                    if (lich.ID_LichHoc_LopHP == x.ID_LichHoc_LopHP)
                    {
                        lich.ID_LichHoc_LopHP++;
                    }
                }

                #region kt lich trung 
                int f = 0;
                //kiểm tra lịch trùng trong list lịch lý thuyết 
                foreach (eLichHoc_LopHocPhan x in lstLichLT)
                {
                    if (lich.ID_PhongHoc == x.ID_PhongHoc && lich.NgayHoc == x.NgayHoc && lich.TietHoc == x.TietHoc)
                    {
                        f = 1;
                        break;
                    }
                    if (lich.ID_LichHoc_LopHP == x.ID_LichHoc_LopHP)
                        break;
                    if (x.TietHoc == "1-3" || x.TietHoc == "1-2" || x.TietHoc == "2-3" || x.TietHoc == "1-5")
                    {
                        if (lich.TietHoc == "1-3" || lich.TietHoc == "1-2" || lich.TietHoc == "2-3" || lich.TietHoc == "1-5")
                        {
                            f = 1;
                            break;
                        }
                    }
                    if (x.TietHoc == "4-6" || x.TietHoc == "5-6" || x.TietHoc == "4-5")
                    {
                        if (lich.TietHoc == "4-6" || lich.TietHoc == "4-5" || lich.TietHoc == "5-6" || lich.TietHoc == "1-5")
                        {
                            f = 1;
                            break;
                        }
                    }
                    if (x.TietHoc == "7-9" || x.TietHoc == "7-8" || x.TietHoc == "8-9" || x.TietHoc == "7-12")
                    {
                        if (lich.TietHoc == "7-9" || lich.TietHoc == "7-8" || lich.TietHoc == "8-9" || lich.TietHoc == "7-12")
                        {
                            f = 1;
                            break;
                        }
                    }
                    if (x.TietHoc == "10-12" || x.TietHoc == "10-11" || x.TietHoc == "11-12")
                    {
                        if (lich.TietHoc == "10-12" || lich.TietHoc == "10-11" || lich.TietHoc == "11-12" || lich.TietHoc == "7-12")
                        {
                            f = 1;
                            break;
                        }
                    }
                }
                //kiểm tra lịch trùng giảng viên
                if (new LichHocBLL().CheckLichTrungGiangVien(cbGiangVien.SelectedValue.ToString().Trim(), cbNgayHoc.SelectedItem.ToString().Trim(), cbTietHoc.SelectedItem.ToString().Trim(), int.Parse(cbHocKy.SelectedItem.ToString().Trim()), int.Parse(cbNamHoc.SelectedValue.ToString().Trim())))
                {
                    f = 1;
                }
                //thêm
                if (f != 1)
                {
                    lstLichLT.Add(lich);
                }
                else
                {
                    MessageBox.Show("Lịch bị trùng");
                }
                #endregion
                LoadLichHocLopHP();

                try
                {
                    cbNgayHoc.SelectedItem = dgvLichLT.Rows[dgvLichLT.CurrentRow.Index].Cells[0].Value.ToString().Trim();
                    cbTietHoc.SelectedItem = dgvLichLT.Rows[dgvLichLT.CurrentRow.Index].Cells[1].Value.ToString().Trim();
                    cbPhong.SelectedValue = dgvLichLT.Rows[dgvLichLT.CurrentRow.Index].Cells[5].Value.ToString().Trim();

                }
                catch (Exception)
                {

                }
            }
            else if (flag == 1)  // -----------------------------Sửa lịch-------------------------------------------
            {
                int index = lstLichLT.IndexOf(lstLichLT.Where(x => x.ID_LichHoc_LopHP == int.Parse(dgvLichLT.Rows[dgvLichLT.CurrentRow.Index].Cells[3].Value.ToString().Trim())).FirstOrDefault());
                int fl = 0;

                foreach (eLichHoc_LopHocPhan x in lstLichLT)
                {
                    if (lich.ID_LichHoc_LopHP != x.ID_LichHoc_LopHP)
                    {
                        if (x.TietHoc == "1-3" || x.TietHoc == "1-2" || x.TietHoc == "2-3" || x.TietHoc == "1-5")
                        {
                            if (lich.TietHoc == "1-3" || lich.TietHoc == "1-2" || lich.TietHoc == "2-3" || lich.TietHoc == "1-5")
                            {
                                fl = 1;
                                break;
                            }
                        }
                        if (x.TietHoc == "4-6" || x.TietHoc == "5-6" || x.TietHoc == "4-5")
                        {
                            if (lich.TietHoc == "4-6" || lich.TietHoc == "4-5" || lich.TietHoc == "5-6" || lich.TietHoc == "1-5")
                            {
                                fl = 1;
                                break;
                            }
                        }
                        if (x.TietHoc == "7-9" || x.TietHoc == "7-8" || x.TietHoc == "8-9" || x.TietHoc == "7-12")
                        {
                            if (lich.TietHoc == "7-9" || lich.TietHoc == "7-8" || lich.TietHoc == "8-9" || lich.TietHoc == "7-12")
                            {
                                fl = 1;
                                break;
                            }
                        }
                        if (x.TietHoc == "10-12" || x.TietHoc == "10-11" || x.TietHoc == "11-12")
                        {
                            if (lich.TietHoc == "10-12" || lich.TietHoc == "10-11" || lich.TietHoc == "11-12" || lich.TietHoc == "7-12")
                            {
                                fl = 1;
                                break;
                            }
                        }
                    }

                }

                if (lstLichLT[index].ID_LichHoc_LopHP == -1)
                {
                    if (new LichHocBLL().CheckLichTrungGiangVien(cbGiangVien.SelectedValue.ToString().Trim(), cbNgayHoc.SelectedItem.ToString().Trim(), cbTietHoc.SelectedItem.ToString().Trim(), int.Parse(cbHocKy.SelectedItem.ToString().Trim()), int.Parse(cbNamHoc.SelectedValue.ToString().Trim())))
                    {
                        fl = 1;
                    }
                }
                else
                {
                    if (new LichHocBLL().CheckLichUpdateGiangVien("LT", int.Parse(lstLichLT[index].ID_LichHoc_LopHP.ToString().Trim()), cbGiangVien.SelectedValue.ToString().Trim(), cbNgayHoc.SelectedItem.ToString().Trim(), cbTietHoc.SelectedItem.ToString().Trim(), int.Parse(cbHocKy.SelectedItem.ToString().Trim()), int.Parse(cbNamHoc.SelectedValue.ToString().Trim())))
                    {
                        fl = 1;
                    }

                }

                if (fl == 0)
                {
                    lstLichLT[index].NgayHoc = cbNgayHoc.SelectedItem.ToString().Trim();
                    lstLichLT[index].TietHoc = cbTietHoc.SelectedItem.ToString().Trim();
                    lstLichLT[index].ID_PhongHoc = cbPhong.SelectedValue.ToString().Trim();
                }
                else
                {
                    MessageBox.Show("Lịch bị trùng");
                }

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

        private void cbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbMaMH.SelectedValue = ((eHocPhan)(cbMonHoc.SelectedItem)).TenMonHoc.Trim();
            }
            catch (Exception)
            {

            }

        }

        private void cbGiangVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                cbMaGV.SelectedValue = ((eGiangVien)(cbGiangVien.SelectedItem)).HoVaTen.Trim();


            }
            catch (Exception)
            {

            }

        }

        private void cbMaMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbMonHoc.SelectedValue = ((eHocPhan)(cbMaMH.SelectedItem)).ID_HocPhan.Trim();
            }
            catch (Exception)
            {

            }

        }

        private void cbMaGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbGiangVien.SelectedValue = ((eGiangVien)(cbMaGV.SelectedItem)).ID_GiangVien.Trim();
            }
            catch (Exception)
            {

            }
        }

        private void cbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                MessageBox.Show("Tên giảng viên không tồn tại trong hệ thống");
                cbGiangVien.SelectedItem = cbGiangVien.Items[0];

            }
            catch (Exception ex)
            {

            }
        }

        private void cbMonHoc_Leave(object sender, EventArgs e)
        {
            try
            {
                foreach (eHocPhan t in cbMonHoc.Items)
                {
                    if (t.TenMonHoc.Trim().ToUpper().Contains(cbMonHoc.Text.Trim().ToUpper()))
                    {
                        cbMonHoc.SelectedItem = t;
                        return;
                    }
                }
                MessageBox.Show("Tên môn học không tồn tại trong hệ thống");
                cbMonHoc.SelectedItem = cbMonHoc.Items[0];
            }
            catch (Exception ex)
            {

            }
        }

        private void cbMaMH_Leave(object sender, EventArgs e)
        {
            try
            {
                foreach (eHocPhan t in cbMaMH.Items)
                {
                    if (t.ID_HocPhan.Trim().ToUpper().Contains(cbMaMH.Text.Trim().ToUpper()))
                    {
                        cbMaMH.SelectedItem = t;
                        return;
                    }
                }
                MessageBox.Show("Tên môn học không tồn tại trong hệ thống");
                cbMaMH.SelectedItem = cbMonHoc.Items[0];
            }
            catch (Exception ex)
            {

            }
        }

        private void cbMaGV_Leave(object sender, EventArgs e)
        {
            try
            {
                foreach (eGiangVien t in cbMaGV.Items)
                {
                    if (t.ID_GiangVien.Trim().ToUpper().Contains(cbMaGV.Text.Trim().ToUpper()))
                    {
                        cbMaGV.SelectedItem = t;
                        return;
                    }
                }
                MessageBox.Show("Mã giảng viên không tồn tại trong hệ thống");
                cbMaGV.SelectedItem = cbMaGV.Items[0];

            }
            catch (Exception ex)
            {

            }
        }

        private void cbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbMaGV_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(cbTrangThai.SelectedItem.ToString().Trim()=="Lên Kế Hoạch"|| cbTrangThai.SelectedItem.ToString().Trim() == "Đã Hủy")
            {
                bool kq = new LopHocPhanBLL().XoaLopHocPhan(txtID.Text.Trim());
                if(kq==true)
                {
                    MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachLopHocPhan(new LopHocPhanBLL().GetAllLopHocPhan());
                    this.XemThongTin();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                MessageBox.Show("Lớp học phần trong trạng thái "+cbTrangThai.SelectedItem.ToString()+" không thể xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
