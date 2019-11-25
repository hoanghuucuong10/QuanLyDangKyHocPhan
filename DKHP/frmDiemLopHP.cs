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
using BLL;
using Entities;

namespace DKHP
{
    public partial class frmDiemLopHP : Form
    {
        public frmDiemLopHP()
        {
            InitializeComponent();

            dgvDiem.EnableHeadersVisualStyles = false;
            dgvDiem.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            dgvDiem.AllowUserToResizeRows = false;
            dgvDiem.AllowUserToResizeColumns = false;
            dgvDiem.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dgvDiem.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dgvDiem.Columns[2].HeaderCell.Style.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dgvDiem.Columns[3].HeaderCell.Style.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dgvDiem.Columns[4].HeaderCell.Style.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dgvDiem.Columns[5].HeaderCell.Style.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dgvDiem.Columns[6].HeaderCell.Style.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dgvDiem.Columns[7].HeaderCell.Style.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dgvDiem.Columns[8].HeaderCell.Style.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dgvDiem.Columns[9].HeaderCell.Style.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dgvDiem.Columns[10].HeaderCell.Style.Font = new Font("Tahoma", 9, FontStyle.Bold);

            dgvDiem.Columns[0].HeaderCell.Style.ForeColor = Color.White;
            dgvDiem.Columns[1].HeaderCell.Style.ForeColor = Color.White;
            dgvDiem.Columns[2].HeaderCell.Style.ForeColor = Color.White;
            dgvDiem.Columns[3].HeaderCell.Style.ForeColor = Color.White;
            dgvDiem.Columns[4].HeaderCell.Style.ForeColor = Color.White;
            dgvDiem.Columns[5].HeaderCell.Style.ForeColor = Color.White;
            dgvDiem.Columns[6].HeaderCell.Style.ForeColor = Color.White;
            dgvDiem.Columns[7].HeaderCell.Style.ForeColor = Color.White;
            dgvDiem.Columns[8].HeaderCell.Style.ForeColor = Color.White;
            dgvDiem.Columns[9].HeaderCell.Style.ForeColor = Color.White;
            dgvDiem.Columns[10].HeaderCell.Style.ForeColor = Color.White;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = tbIDLopHP.Text.Trim();
            eLopHocPhan elhp = new LopHocPhanBLL().GetLopHocPhanbyID(id);
            if(elhp!=null)
            {
                LopHocPhanViewModels lopHP = new LopHocPhanViewModels
                {
                    ID_LopHocPhan = elhp.ID_LopHocPhan.Trim(),
                    HocKy = elhp.HocKy,
                    ID_GiangVien = elhp.ID_GiangVien.Trim(),
                    TenGiangVien = new GiangVienBLL().GetGiangVienByID(elhp.ID_GiangVien.Trim()).HoVaTen.Trim(),
                    ID_HocPhan = elhp.ID_HocPhan,
                    ID_NhanVienPDT = elhp.ID_NhanVienPDT,
                    ID_NienKhoa = elhp.ID_NienKhoa,
                    NgayBatDau = elhp.NgayBatDau,
                    NgayKetThuc = elhp.NgayKetThuc,
                    NienKhoa = new NienKhoaBLL().GetNienKhoaByID(elhp.ID_NienKhoa.Value).NienKhoa1,
                    SoLuong = elhp.SoLuong,
                    SoTiet = elhp.SoTiet,
                    TenMonHoc = new HocPhanBLL().GetHocPhanByID(elhp.ID_HocPhan.Trim()).TenMonHoc.Trim(),
                    TrangThai = elhp.TrangThai
                };
                lbTenMonHoc.Text = lopHP.TenMonHoc.Trim();
                lbSoTC.Text = new HocPhanBLL().GetHocPhanByID(lopHP.ID_HocPhan).SoTC.ToString();
                lbHocKi.Text = "Học kỳ " + lopHP.HocKy + " (" + lopHP.NienKhoa + ")";

                List<DiemLopHocPhanViewModels> lst = new DiemBLL().GetDiemLopHocPhan(id).Select(t => new DiemLopHocPhanViewModels
                {
                    ID_SinhVien = t.ID_SinhVien,
                    HoVaTen = new SinhVienBLL().GetSinhVienByID(t.ID_SinhVien).HoVaTen,
                    TenLopNienChe = new LopNienCheBLL().GetLopNienCheByID(new SinhVienBLL().GetSinhVienByID(t.ID_SinhVien).ID_LopNienChe.Trim()).TenLop.Trim(),
                    TenNhom = new NhomThucHanhBLL().GetNhomSV(t.ID_LopHocPhan, t.ID_SinhVien),
                    TK1 = t.TK1.ToString(),
                    TK2 = t.TK2.ToString(),
                    TK3 = t.TK3.ToString(),
                    CK = t.CK.ToString(),
                    GK = t.GK.ToString(),
                }).OrderByDescending(s => s.HoVaTen).ToList();

                if(lst!=null)
                {
                    diemLopHocPhanViewModelsBindingSource.DataSource = lst;
                }
                
            }else
            {
                MessageBox.Show("Mã lớp học phần không đúng");
                diemLopHocPhanViewModelsBindingSource.DataSource = null;
            }
           
        }
        public void LoadDiem(string id)
        {

        }
    }
}
