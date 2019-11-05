using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DKHP.ViewModels;
namespace DKHP
{
    public partial class frmDangKyHocPhanPN : Form
    {
        public eSinhVien eSV = new eSinhVien();
        LopHocPhanBLL LHP = new LopHocPhanBLL();
        List<LopHocPhanViewModels> lstLopHocPhan = new List<LopHocPhanViewModels>();
        List<NhomThucHanhViewModels> lstNhomThucHanh = new List<NhomThucHanhViewModels>();
        List<LichHocLTViewModels> lstLichLyThuyet = new List<LichHocLTViewModels>();
        List<LichHocTHViewModels> lstLichThucHanh = new List<LichHocTHViewModels>();
        List<DangKyHocPhanViewModels> lstHocPhanDangKy = new List<DangKyHocPhanViewModels>();
        public frmDangKyHocPhanPN(eSinhVien eSV)
        {
            InitializeComponent();
            this.eSV = eSV;

            #region cbNienKhoa
            List<eNienKhoa> lstNienKhoa = new NienKhoaBLL().GetAllNienKhoa();
            cbNamHocSearch.DataSource = lstNienKhoa;
            cbNamHocSearch.DisplayMember = "NienKhoa1";
            cbNamHocSearch.ValueMember = "ID_NienKhoa";
            cbHocKiSearch.SelectedIndex = 0;
            #endregion

        }
        public void LoadDanhSachDaDangKy()
        {
            lstHocPhanDangKy = new LopHocPhanBLL().GetAllHocPhanSinhVien(eSV.ID_SinhVien, int.Parse(cbHocKiSearch.SelectedItem.ToString().Trim()), cbNamHocSearch.Text.Trim()).Select(x => new DangKyHocPhanViewModels
            {
                ID_LopHocPhan = x.ID_LopHocPhan.Trim(),
                TenMonHoc = new HocPhanBLL().GetHocPhanByID(x.ID_HocPhan).TenMonHoc.Trim(),
                ID_NhomThucHanh = new DangKyHocPhanBLL().GetDangKyHocPhanByIDLopHocPhan(x.ID_LopHocPhan).ID_NhomThucHanh.Trim(),
                TenNhom = new NhomThucHanhBLL().GetTenNhomByID(new DangKyHocPhanBLL().GetDangKyHocPhanByIDLopHocPhan(x.ID_LopHocPhan).ID_NhomThucHanh.Trim()).Trim(),
                SoTinChi = new HocPhanBLL().GetHocPhanByID(x.ID_HocPhan).SoTC.Value,
                SoLuong = new DangKyHocPhanBLL().SoLuong(x.ID_LopHocPhan),
                TrangThai = x.TrangThai.Trim()
            }).ToList();
            dangKyHocPhanViewModelsBindingSource.DataSource = lstHocPhanDangKy;

        }
        public void LoadDSLopHocPhan()
        {
            lstLopHocPhan = new LopHocPhanBLL().SearchLopHocPhan("", "", cbHocKiSearch.SelectedItem.ToString().Trim(), cbNamHocSearch.Text.ToString().Trim()).Select(t => new LopHocPhanViewModels
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


            foreach(DangKyHocPhanViewModels x in lstHocPhanDangKy)
            {
                foreach(LopHocPhanViewModels t in lstLopHocPhan)
                {
                    if(x.ID_LopHocPhan==t.ID_LopHocPhan)
                    {
                        lstLopHocPhan.Remove(t);
                        break;
                    }
                }
            }

            lopHocPhanViewModelsBindingSource.DataSource = lstLopHocPhan;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadDanhSachDaDangKy();
            LoadDSLopHocPhan();
           
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                string idLopHP = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString().Trim();
               
                #region Load danh sách lịch lý thuyết
                lstLichLyThuyet = new LichHocBLL().GetLichHoc_LopHocPhan(idLopHP).Select(t => new LichHocLTViewModels
                {
                    ID_LichHoc_LopHP = t.ID_LichHoc_LopHP,
                    ID_LopHocPhan = t.ID_LopHocPhan,
                    ID_PhongHoc = t.ID_PhongHoc,
                    TenPhongHoc = new PhongHocBLL().GetPhongHocByID(t.ID_PhongHoc).TenPhongHoc,
                    NgayHoc = t.NgayHoc,
                    TietHoc = t.TietHoc
                }).ToList();
                lichHocLTViewModelsBindingSource.DataSource = lstLichLyThuyet;
                dataGridView3.ClearSelection();
                #endregion
             
                #region Load danh sách nhóm TH
                lstNhomThucHanh = new NhomThucHanhBLL().GetNhomByIDLopHocPhan(idLopHP).Select(m => new NhomThucHanhViewModels
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

                nhomThucHanhViewModelsBindingSource.DataSource = lstNhomThucHanh;
                dataGridView4.ClearSelection();
                #endregion


            }
            catch (Exception)
            {
            }
        }
        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string idLopTH = dataGridView4.Rows[dataGridView4.CurrentRow.Index].Cells[0].Value.ToString().Trim();
                lstLichThucHanh = new LichHocBLL().GetLichHoc_NhomThucHanh(idLopTH).Select(t => new LichHocTHViewModels
                {
                    ID_LichHoc_NhomTH = t.ID_LichHoc_NhomTH,
                    ID_NhomThucHanh = t.ID_NhomThucHanh,
                    ID_PhongHoc = t.ID_PhongHoc,
                    TenPhongHoc = new PhongHocBLL().GetPhongHocByID(t.ID_PhongHoc).TenPhongHoc,
                    NgayHoc = t.NgayHoc,
                    TietHoc = t.TietHoc
                }).ToList();
                lichHocTHViewModelsBindingSource.DataSource = lstLichThucHanh;
                dataGridView5.ClearSelection();
            }
            catch (Exception)
            {
            }
        }

        private void btDK_Click(object sender, EventArgs e)
        {
            string idLopHP;
            string idNhomTH;
            if (dataGridView1.Rows.Count==0) //hoc ky ko co hoc phan dang ky
            {
                return;
            }
            
            if(dataGridView1.Rows.Count > 0)
            {
                if(dataGridView3.Rows.Count==0)//Chưa chọn lớp học phần
                {
                    MessageBox.Show("Vui lòng chọn lớp học phần muốn đăng ký");
                    return;
                }
                if (dataGridView4.Rows.Count == 0)// khong co nhom thuc hanh
                {
                    idLopHP = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString().Trim();
                    idNhomTH = "";
                }else // co nhom thuc hanh
                {
                    if (dataGridView5.Rows.Count == 0) //chưa chọn nhóm thực hành
                    {
                        MessageBox.Show("Vui lòng chọn nhóm thực hành");
                        return;
                    }
                    idLopHP = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString().Trim();
                    idNhomTH = dataGridView4.Rows[dataGridView4.CurrentRow.Index].Cells[0].Value.ToString().Trim();
                }
                //Kiểm tra lịch trùng nếu sai thì thông báo và return
                bool kt = new LichHocBLL().CheckLichTrung(eSV.ID_SinhVien,idLopHP, idNhomTH, cbHocKiSearch.SelectedItem.ToString().Trim(), int.Parse( cbNamHocSearch.SelectedValue.ToString().Trim()));
                if (kt == true)
                {
                    MessageBox.Show("Không thể đăng ký vì bị trùng lịch");
                    return;
                }else//dang ky hoc phan
                {
                    bool k = new DangKyHocPhanBLL().DangKy(eSV.ID_SinhVien, idLopHP, idNhomTH);
                    if(k==true)
                    {
                        MessageBox.Show("Đăng Ký Thành Công");
                        LoadDanhSachDaDangKy();
                        LoadDSLopHocPhan();
                        dataGridView1.ClearSelection();
                        lichHocLTViewModelsBindingSource.DataSource = null;
                        nhomThucHanhViewModelsBindingSource.DataSource = null;
                        lichHocTHViewModelsBindingSource.DataSource = null;
                    }
                    else
                    {
                        MessageBox.Show("Đăng Ký Thất Bại");
                    }
                }


            }
            
            


        }

        private void btHDK_Click(object sender, EventArgs e)
        {
            if(dataGridView2.Rows.Count>0)
            {
                string idLopHP;
                idLopHP = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value.ToString().Trim();
                bool k = new DangKyHocPhanBLL().HuyDangKy(eSV.ID_SinhVien, idLopHP);
                if(k==true)
                {
                    MessageBox.Show("Hủy đăng ký thành công");
                    LoadDanhSachDaDangKy();
                    LoadDSLopHocPhan();
                    dataGridView1.ClearSelection();
                    lichHocLTViewModelsBindingSource.DataSource = null;
                    nhomThucHanhViewModelsBindingSource.DataSource = null;
                    lichHocTHViewModelsBindingSource.DataSource = null;
                }else
                {
                    MessageBox.Show("Hủy đăng ký không thành công");
                }
            }
            
        }
    }
}
