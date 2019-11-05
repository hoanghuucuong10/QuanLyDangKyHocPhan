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

        public frmDangKyHocPhanPN(eSinhVien eSV)
        {
            InitializeComponent();
            this.eSV = eSV;

            #region cbNienKhoa
            List<eNienKhoa> lstNienKhoa = new NienKhoaBLL().GetAllNienKhoa();
            cbNamHocSearch.DataSource = lstNienKhoa;
            cbNamHocSearch.DisplayMember = "NienKhoa1";
            cbNamHocSearch.ValueMember =  "ID_NienKhoa";
            cbHocKiSearch.SelectedIndex = 0;
            #endregion

        }

        public void LoadDSLopHocPhan()
        {
            List<LopHocPhanViewModels> lstLHP = new LopHocPhanBLL().SearchLopHocPhan( "","" , cbHocKiSearch.SelectedItem.ToString().Trim(), cbNamHocSearch.Text.ToString().Trim()).Select(t => new LopHocPhanViewModels
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

            lopHocPhanViewModelsBindingSource.DataSource = lstLHP;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadDSLopHocPhan();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                string idLopHP = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString().Trim();
                #region Load danh sách lịch lý thuyết
                List<LichHocLTViewModels> lstLichLT = new LichHocBLL().GetLichHoc_LopHocPhan(idLopHP).Select(t=>new LichHocLTViewModels {
                    ID_LichHoc_LopHP = t.ID_LichHoc_LopHP,
                    ID_LopHocPhan = t.ID_LopHocPhan,
                    ID_PhongHoc = t.ID_PhongHoc,
                    TenPhongHoc = new PhongHocBLL().GetPhongHocByID(t.ID_PhongHoc).TenPhongHoc,
                    NgayHoc = t.NgayHoc,
                    TietHoc = t.TietHoc
                }).ToList();
                lichHocLTViewModelsBindingSource.DataSource = lstLichLT;
                #endregion
                #region Load danh sách nhóm TH
                List<NhomThucHanhViewModels> lstNhomTH = new NhomThucHanhBLL().GetNhomByIDLopHocPhan(idLopHP).Select(m => new NhomThucHanhViewModels
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

                nhomThucHanhViewModelsBindingSource.DataSource = lstNhomTH;
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
                List<LichHocTHViewModels> lstLichTH = new LichHocBLL().GetLichHoc_NhomThucHanh(idLopTH).Select(t => new LichHocTHViewModels
                {
                    ID_LichHoc_NhomTH = t.ID_LichHoc_NhomTH,
                    ID_NhomThucHanh = t.ID_NhomThucHanh,
                    ID_PhongHoc = t.ID_PhongHoc,
                    TenPhongHoc = new PhongHocBLL().GetPhongHocByID(t.ID_PhongHoc).TenPhongHoc,
                    NgayHoc = t.NgayHoc,
                    TietHoc = t.TietHoc
                }).ToList();
                nhomThucHanhViewModelsBindingSource.DataSource = lstLichTH;
            }
            catch (Exception)
            {
            }
           
        }
    }
}
