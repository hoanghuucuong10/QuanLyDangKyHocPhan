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

    public partial class frmDangNhap : Form
    {
        private static frmDangNhap _instance;
        TaiKhoanBLL loginBLL = new TaiKhoanBLL();


        public static frmDangNhap Instance
        {
            // Uses lazy initialization.

            // Note: this is not thread safe.
            get
            {
                if (_instance == null)
                {
                    _instance = new frmDangNhap();
                }

                return _instance;
            }

        }
        public frmDangNhap()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Object kq = loginBLL.Login(tbxUserName.Text.Trim(), tbxPW.Text.Trim());
            if (kq != null)
            {

                //form login-logout
                this.Hide();


                //Show pnButton
                if (kq is eSinhVien)
                {
                    frmMain.Tk = kq;
                    frmMain.Instance.menuStripSV.Visible = true;
                    frmMain.Instance.menuStripGV.Visible = false;
                    frmMain.Instance.menuStripNV.Visible = false;
                    frmMain.Instance.pnMain.Controls.Clear();
                    frmMain.Instance.Show();

                }
                else if (kq is eGiangVien)
                {
                    frmMain.Tk = kq;
                    frmMain.Instance.menuStripSV.Visible = false;
                    frmMain.Instance.menuStripGV.Visible = true;
                    frmMain.Instance.menuStripNV.Visible = false;
                    frmMain.Instance.pnMain.Controls.Clear();
                    frmMain.Instance.Show();
                }
                else if (kq is eNhanVienPDT)
                {
                    frmMain.Tk = kq;
                    frmMain.Instance.menuStripSV.Visible = false;
                    frmMain.Instance.menuStripGV.Visible = false;
                    frmMain.Instance.menuStripNV.Visible = true;
                    frmMain.Instance.pnMain.Controls.Clear();
                    frmMain.Instance.Show();

                }
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mât khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

    }
}
