using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entities;
using System.Globalization;

namespace DKHP
{
    public partial class frmLichDay : Form
    {
        public eGiangVien eGV = new eGiangVien();
        public frmLichDay(eGiangVien gV)
        {
            InitializeComponent();
            this.eGV = gV;
            btnSearch.Visible = false;
            cbNamHocSearch.DataSource = new NienKhoaBLL().GetAllNienKhoa();
            cbNamHocSearch.ValueMember = "ID_NienKhoa";
            cbNamHocSearch.DisplayMember = "NienKhoa1";

        }
        public frmLichDay()
        {
            InitializeComponent();
            cbNamHocSearch.DataSource = new NienKhoaBLL().GetAllNienKhoa();
            cbNamHocSearch.ValueMember = "ID_NienKhoa";
            cbNamHocSearch.DisplayMember = "NienKhoa1";

        }
        private void btnSearchGV_Click(object sender, EventArgs e)
        {
            eGiangVien x = new GiangVienBLL().GetGiangVienByID(txtID.Text.Trim());
            if (x!=null)
            {
                this.eGV = x;
                txtMail.Text = x.Mail.Trim();
                txtPhone.Text = x.SDT.Trim();
                txtTen.Text = x.HoVaTen.Trim();
                txtTrinhDo.Text = x.TrinhDo.Trim();
                txtAddress.Text = x.DiaChi.Trim();
            }
        }
        public void ClearPN()
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel3.Controls.Clear();
            panel4.Controls.Clear();
            panel5.Controls.Clear();
            panel6.Controls.Clear();
            panel7.Controls.Clear();
            panel8.Controls.Clear();
            panel9.Controls.Clear();
            panel10.Controls.Clear();
            panel11.Controls.Clear();
            panel12.Controls.Clear();
            panel13.Controls.Clear();
            panel14.Controls.Clear();
            panel15.Controls.Clear();
            panel16.Controls.Clear();
            panel17.Controls.Clear();
            panel18.Controls.Clear();
            panel19.Controls.Clear();
            panel20.Controls.Clear();
            panel21.Controls.Clear();
            panel22.Controls.Clear();
            panel23.Controls.Clear();
            panel24.Controls.Clear();
            panel25.Controls.Clear();
            panel26.Controls.Clear();
            panel27.Controls.Clear();
            panel28.Controls.Clear();
            panel29.Controls.Clear();
            panel30.Controls.Clear();
            panel31.Controls.Clear();
            panel32.Controls.Clear();
            panel33.Controls.Clear();
            panel34.Controls.Clear();
            panel35.Controls.Clear();
        }
        public void AddPanelTH(eLichHoc_NhomThucHanh x)
        {
            eLopHocPhan a = new LopHocPhanBLL().GetHocPhanByIDNhomTH(x.ID_NhomThucHanh);
            eNhomThucHanh b = new NhomThucHanhBLL().GetNhomByID(x.ID_NhomThucHanh);
            ePhongHoc c = new PhongHocBLL().GetPhongHocByID(x.ID_PhongHoc);
            eHocPhan d = new HocPhanBLL().GetHocPhanByID(a.ID_HocPhan);
            frmPnLich pnLich = new frmPnLich(a.ID_LopHocPhan.Trim(), d.TenMonHoc.Trim(), new GiangVienBLL().GetGiangVienByID(a.ID_GiangVien).HoVaTen.Trim(), x.TietHoc, c.TenPhongHoc, b.TenNhom.Trim(), b.NgayBatDau.Value.ToShortDateString(), b.NgayKetThuc.Value.ToShortDateString());
            pnLich.TopLevel = false;
            pnLich.FormBorderStyle = FormBorderStyle.None;
            pnLich.Visible = true;
            if (x.NgayHoc == "Thứ Hai" && x.TietHoc == "1-3")
            {
                panel1.Controls.Add(pnLich);
            }
            if (x.NgayHoc == "Thứ Ba" && x.TietHoc == "1-3")
            {
                panel2.Controls.Add(pnLich);
            }
            if (x.NgayHoc == "Thứ Tư" && x.TietHoc == "1-3")
            {
                panel3.Controls.Add(pnLich);
            }
            if (x.NgayHoc == "Thứ Năm" && x.TietHoc == "1-3")
            {
                panel4.Controls.Add(pnLich);
            }
            if (x.NgayHoc == "Thứ Sáu" && x.TietHoc == "1-3")
            {
                panel5.Controls.Add(pnLich);
            }
            if (x.NgayHoc == "Thứ Bảy" && x.TietHoc == "1-3")
            {
                panel6.Controls.Add(pnLich);
            }
            if (x.NgayHoc == "Chủ Nhật" && x.TietHoc == "1-3")
            {
                panel7.Controls.Add(pnLich);
            }
            //
            if (x.NgayHoc == "Thứ Hai" && x.TietHoc == "4-6")
            {
                panel8.Controls.Add(pnLich);
            }
            if (x.NgayHoc == "Thứ Ba" && x.TietHoc == "4-6")
            {
                panel9.Controls.Add(pnLich);
            }
            if (x.NgayHoc == "Thứ Tư" && x.TietHoc == "4-6")
            {
                panel10.Controls.Add(pnLich);
            }
            if (x.NgayHoc == "Thứ Năm" && x.TietHoc == "4-6")
            {
                panel11.Controls.Add(pnLich);
            }
            if (x.NgayHoc == "Thứ Sáu" && x.TietHoc == "4-6")
            {
                panel12.Controls.Add(pnLich);
            }
            if (x.NgayHoc == "Thứ Bảy" && x.TietHoc == "4-6")
            {
                panel13.Controls.Add(pnLich);
            }
            if (x.NgayHoc == "Chủ Nhật" && x.TietHoc == "4-6")
            {
                panel14.Controls.Add(pnLich);
            }
            //7-9
            if (x.NgayHoc == "Thứ Hai" && x.TietHoc == "7-9")
            {
                panel15.Controls.Add(pnLich);
            }
            if (x.NgayHoc == "Thứ Ba" && x.TietHoc == "7-9")
            {
                panel16.Controls.Add(pnLich);
            }
            if (x.NgayHoc == "Thứ Tư" && x.TietHoc == "7-9")
            {
                panel17.Controls.Add(pnLich);
            }
            if (x.NgayHoc == "Thứ Năm" && x.TietHoc == "7-9")
            {
                panel18.Controls.Add(pnLich);
            }
            if (x.NgayHoc == "Thứ Sáu" && x.TietHoc == "7-9")
            {
                panel19.Controls.Add(pnLich);
            }
            if (x.NgayHoc == "Thứ Bảy" && x.TietHoc == "7-9")
            {
                panel20.Controls.Add(pnLich);
            }
            if (x.NgayHoc == "Chủ Nhật" && x.TietHoc == "7-9")
            {
                panel21.Controls.Add(pnLich);
            }
            //10-12
            if (x.NgayHoc == "Thứ Hai" && x.TietHoc == "10-12")
            {
                panel22.Controls.Add(pnLich);
            }
            if (x.NgayHoc == "Thứ Ba" && x.TietHoc == "10-12")
            {
                panel23.Controls.Add(pnLich);
            }
            if (x.NgayHoc == "Thứ Tư" && x.TietHoc == "10-12")
            {
                panel24.Controls.Add(pnLich);
            }
            if (x.NgayHoc == "Thứ Năm" && x.TietHoc == "10-12")
            {
                panel25.Controls.Add(pnLich);
            }
            if (x.NgayHoc == "Thứ Sáu" && x.TietHoc == "10-12")
            {
                panel26.Controls.Add(pnLich);
            }
            if (x.NgayHoc == "Thứ Bảy" && x.TietHoc == "10-12")
            {
                panel27.Controls.Add(pnLich);
            }
            if (x.NgayHoc == "Chủ Nhật" && x.TietHoc == "10-12")
            {
                panel28.Controls.Add(pnLich);
            }
            //13-15
            if (x.NgayHoc == "Thứ Hai" && x.TietHoc == "13-15")
            {
                panel29.Controls.Add(pnLich);
            }
            if (x.NgayHoc == "Thứ Ba" && x.TietHoc == "13-15")
            {
                panel30.Controls.Add(pnLich);
            }
            if (x.NgayHoc == "Thứ Tư" && x.TietHoc == "13-15")
            {
                panel31.Controls.Add(pnLich);
            }
            if (x.NgayHoc == "Thứ Năm" && x.TietHoc == "13-15")
            {
                panel32.Controls.Add(pnLich);
            }
            if (x.NgayHoc == "Thứ Sáu" && x.TietHoc == "13-15")
            {
                panel33.Controls.Add(pnLich);
            }
            if (x.NgayHoc == "Thứ Bảy" && x.TietHoc == "13-15")
            {
                panel34.Controls.Add(pnLich);
            }
            if (x.NgayHoc == "Chủ Nhật" && x.TietHoc == "13-15")
            {
                panel35.Controls.Add(pnLich);
            }

        }
        public void AddPanelLT(eLopHocPhan a)
        {
        }

        public void LoadLichDay(int hocKy,string namHoc)
        {
            ClearPN();
            List<eLichHoc_LopHocPhan> lstLichLT = new LichHocBLL().GetLichHocLyThuyet_GiangVien(eGV.ID_GiangVien, int.Parse(cbHocKiSearch.Text.Trim()), int.Parse(cbNamHocSearch.SelectedValue.ToString().Trim()));
            List<eLichHoc_NhomThucHanh> lstLichTH = new LichHocBLL().GetLichHocThucHanh_GiangVien(eGV.ID_GiangVien, int.Parse(cbHocKiSearch.Text.Trim()), int.Parse(cbNamHocSearch.SelectedValue.ToString().Trim())); ;
            foreach(eLichHoc_NhomThucHanh x in lstLichTH)
            {
                AddPanelTH(x);
                
            }
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            int hocKy = int.Parse(cbHocKiSearch.SelectedItem.ToString().Trim());
            string namHoc = cbNamHocSearch.Text.Trim();
            LoadLichDay(hocKy, namHoc);
        }


    }
}
