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

namespace DKHP
{
    public partial class frmMain : Form
    {
        private static frmMain _instance;
        private static Object tk;


        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Exit();
        }
        public static frmMain Instance
        {
            // Uses lazy initialization.

            // Note: this is not thread safe.
            get
            {
                if (_instance == null)
                {
                    _instance = new frmMain();
                }

                return _instance;
            }

        }

        public static object Tk
        {
            get
            {
                return tk;
            }

            set
            {
                tk = value;
            }
        }

        public frmMain()
        {
            InitializeComponent();
            if (Tk is eSinhVien)
            {
                menuStripGV.Visible = false;
                menuStripNV.Visible = false;
                menuStripSV.Visible = true;
            }
            if (Tk is eGiangVien)
            {
                menuStripGV.Visible = true;
                menuStripNV.Visible = false;
                menuStripSV.Visible = false;
            }
            if (Tk is eNhanVienPDT)
            {
                menuStripGV.Visible = false;
                menuStripNV.Visible = true;
                menuStripSV.Visible = false;
            }
        }


        private void ShowPNMain(Form x)
        {
            pnMain.Controls.Clear();
            x.TopLevel = false;
            x.FormBorderStyle = FormBorderStyle.None;
            pnMain.Controls.Add(x);
            x.Dock = DockStyle.Fill;

            x.Show();
        }

        #region  Đăng Xuất, Thoát
        //Thoát
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin.Instance.Close();
            Application.Exit();
        }

        //Đăng Xuất
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin.Instance.Show();
        }
        #endregion
        #region Thông tin tài khoản, đổi mật khẩu
        //Xem thông tin tài khoản
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmTaiKhoan frm = new frmTaiKhoan(tk);
            ShowPNMain(frm);
        }
        //Dổi Mật Khẩu
        private void mnDMK2_Click(object sender, EventArgs e)
        {

        }
        //--------------------------------------------------------------------------------------//
        #endregion
        #region Nhân viên phòng đào tạo
        #region Học Phần
        private void mnDSHP_Click(object sender, EventArgs e)
        {
            frmHocPhan.instance.XemThongTin();
            ShowPNMain(frmHocPhan.instance);
        }

        private void mnThemHP_Click(object sender, EventArgs e)
        {
            frmHocPhan.instance.Them();
            ShowPNMain(frmHocPhan.instance);
        }

        private void mnChinhHP_Click(object sender, EventArgs e)
        {
            frmHocPhan.instance.ChinhSua();
            ShowPNMain(frmHocPhan.instance);
        }
        #endregion
        #region Lớp Học Phần
        private void mnDSLHP_Click(object sender, EventArgs e)
        {
            ShowPNMain(frmLopHocPhan.instance);
            frmLopHocPhan.instance.XemThongTin();

        }

        private void mnThemLHP_Click(object sender, EventArgs e)
        {
            ShowPNMain(frmLopHocPhan.instance);
            frmLopHocPhan.instance.Them();
        }

        private void mnChinhLHP_Click(object sender, EventArgs e)
        {
            ShowPNMain(frmLopHocPhan.instance);
            frmLopHocPhan.instance.ChinhSua();
        }
        #endregion
        #region Sinh Viên PDT

        private void mnDSSV_Click(object sender, EventArgs e)
        {
            frmSinhVien.instance.XemThongTin();
            ShowPNMain(frmSinhVien.instance);
        }

        private void mnDKHP_Click(object sender, EventArgs e)
        {
            frmDangKyHocPhan frm = new frmDangKyHocPhan(tk);
            ShowPNMain(frm);
        }
        #endregion
        #region Giảng Viên PDT
        private void mnDSGV_Click(object sender, EventArgs e)
        {
            frmGiangVien.instance.XemThongTin();
            ShowPNMain(frmGiangVien.instance);
        }
        #endregion
        #region Diem
        private void mnDiemSV_Click(object sender, EventArgs e)
        {
            ShowPNMain(frmDiemSV.Instance);
        }

        private void mnDiemLopHP_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #endregion

        //--------------------------------------------------------------------------------------//
        #region GiangVien
        //XemLichDay
        private void mnLichDay_Click(object sender, EventArgs e)
        {
            frmLichDay frm = new frmLichDay((eGiangVien)tk);
            ShowPNMain(frm);
        }
        //Nhap Diem
        private void mnNhapDiem_Click(object sender, EventArgs e)
        {

        }
        //Xem Danh Sach Lop
        private void xemDanhSáchLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        //--------------------------------------------------------------------------------------//

        #region Sinh Viên
        //Đăng ký học phần
        private void mnDKHPSV_Click(object sender, EventArgs e)
        {
            frmDangKyHocPhan frm = new frmDangKyHocPhan(tk);
            ShowPNMain(frm);
        }
        //Xem lịch học
        private void mnLichHoc_Click(object sender, EventArgs e)
        {

        }
        //Xem kết quả học tập
        private void mnKQHT_Click(object sender, EventArgs e)
        {

        }



        #endregion

        private void mnNVXemLichDay_Click(object sender, EventArgs e)
        {
            frmLichDay frm = new frmLichDay();
            ShowPNMain(frm);
        }
    }
}
