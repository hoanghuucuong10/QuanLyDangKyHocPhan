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
        public int flagChinhsua = 0;
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
            GroupboxThongTin.Text = "Thông Tin Lớp Học Phần";
            txtID.Enabled = false;
            cbMonHoc.Enabled = false;
            cbGiangVien.Enabled = false;
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





        }
        public void ChinhSua()
        {
            GroupboxThongTin.Text = "Chỉnh Sửa Lớp Học Phần";

            txtID.Enabled = false;
            cbMonHoc.Enabled = true;
            cbGiangVien.Enabled = true;
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

        }
        private void dgvLopHocPhan_CellClick(object sender, DataGridViewCellEventArgs e)
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

                numSoTiet.Value = int.Parse(dgvLopHocPhan.Rows[rowSelected].Cells[5].Value.ToString().Trim());
                cbTrangThai.SelectedItem = dgvLopHocPhan.Rows[rowSelected].Cells[7].Value.ToString().Trim();
                DateTime x = Convert.ToDateTime(dgvLopHocPhan.Rows[rowSelected].Cells[8].Value.ToString().Trim());
                timeBD.Value = x;
                x = Convert.ToDateTime(dgvLopHocPhan.Rows[rowSelected].Cells[9].Value.ToString().Trim());
                timeKT.Value = x;

                lstLichLT = new LichHocBLL().GetLichHoc_LopHocPhan(txtID.Text.Trim());
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
        private void dgvNhomTH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
                    new LichHocBLL().AddLichLT(n);
                }
                MessageBox.Show("Thêm Thành Công");
                
                LoadDanhSachLopHocPhan(new LopHocPhanBLL().GetAllLopHocPhan());
                ShowDataGrid();
            }
            else //chỉnh sửa lớp học phần
            {
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
                MessageBox.Show("Chỉnh sửa Thành Công");

                LoadDanhSachLopHocPhan(new LopHocPhanBLL().GetAllLopHocPhan());
                ShowDataGrid();
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
            //thêm
            if (this.flag == 2)
            {
                eLichHoc_LopHocPhan lich = new eLichHoc_LopHocPhan();

                lich.ID_LichHoc_LopHP = new LichHocBLL().CreateIDLyThuyet();

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
                lich.ID_LopHocPhan = txtID.Text.Trim();

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
                    cbNgayHoc.SelectedItem = dgvLichLT.Rows[dgvLichLT.CurrentRow.Index].Cells[0].Value.ToString().Trim();
                    cbTietHoc.SelectedItem = dgvLichLT.Rows[dgvLichLT.CurrentRow.Index].Cells[1].Value.ToString().Trim();
                    cbPhong.SelectedValue = dgvLichLT.Rows[dgvLichLT.CurrentRow.Index].Cells[5].Value.ToString().Trim();

                }
                catch (Exception)
                {

                }
            }
            else if (flag == 1)  // Sửa
            {


                int index = lstLichLT.IndexOf(lstLichLT.Where(x => x.ID_LichHoc_LopHP == int.Parse(dgvLichLT.Rows[dgvLichLT.CurrentRow.Index].Cells[3].Value.ToString().Trim())).FirstOrDefault());
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
