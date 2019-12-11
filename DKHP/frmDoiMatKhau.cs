using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DKHP
{
    public partial class frmDoiMatKhau : Form
    {
        public object tk;
        string mk;
        public frmDoiMatKhau(object tk)
        {
            InitializeComponent();
            this.tk = tk;
            kt = 0;
            if (tk is eSinhVien)
            {
                mk = ((eSinhVien)tk).MatKhau.Trim();
            }
            else if (tk is eGiangVien)
            {
                mk = ((eGiangVien)tk).MatKhau.Trim();

            }
            else if (tk is eNhanVienPDT)
            {
                mk = ((eNhanVienPDT)tk).MatKhau.Trim();
            }

        }

        private void btnHideMKCu_Click(object sender, EventArgs e)
        {
            txtMKCu.UseSystemPasswordChar = txtMKCu.UseSystemPasswordChar == true ? false : true;
        }

        private void btnHideMKMoi_Click(object sender, EventArgs e)
        {
            txtMKMoi.UseSystemPasswordChar = txtMKMoi.UseSystemPasswordChar == true ? false : true;
        }

        private void btnHideXNMK_Click(object sender, EventArgs e)
        {
            txtXacNhanMK.UseSystemPasswordChar = txtXacNhanMK.UseSystemPasswordChar == true ? false : true;
        }
        int kt = 0;
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            kt = 0;
            #region Kiểm tra dữ liệu nhập
            //Mật khẩu hiện tại
            if (string.IsNullOrEmpty(txtMKCu.Text))
            {
                err.SetError(btnHideMKCu, "Không được để trống");
            }
            else
            {
                if (txtMKCu.Text != mk)
                {
                    err.SetError(btnHideMKCu, "Mật khẩu hiện tại không chính xác");
                }
                else
                {
                    err.SetError(btnHideMKCu, "");
                    kt++;
                }
            }
            //Mật khẩu mới
            if (string.IsNullOrEmpty(txtMKMoi.Text))
            {
                err.SetError(btnHideMKMoi, "Không được để trống");
            }
            else
            {
                if (!Regex.IsMatch(txtMKMoi.Text, "[a-zA-Z0-9]*"))
                {
                    err.SetError(btnHideMKMoi, "Mật khẩu mới không hợp lệ");
                }
                else
                {
                    err.SetError(btnHideMKMoi, "");
                    kt++;
                }
            }
            //Mật khẩu mới
            if (string.IsNullOrEmpty(txtXacNhanMK.Text))
            {
                err.SetError(btnHideXNMK, "Không được để trống");
            }
            else
            {
                if (!Regex.IsMatch(txtXacNhanMK.Text, txtMKMoi.Text))
                {
                    err.SetError(btnHideXNMK, "Mật khẩu xác nhận không khớp với mật khẩu mới");
                }
                else
                {
                    err.SetError(btnHideXNMK, "");
                    kt++;
                }
            }
            #endregion
            if(kt==3)
            {
                if(new TaiKhoanBLL().DoiMatKhau(tk, txtMKMoi.Text.Trim())==true)
                {
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   kt = 0;
                    this.Close();
                }else
                {
                    MessageBox.Show("Đổi mật khẩu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            err.Clear();
            this.Close();
        }

        private void txtMKCu_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMKCu.Text))
            {
                err.SetError(btnHideMKCu, "Không được để trống");
            }
            else
            {
                if (txtMKCu.Text != mk)
                {
                    err.SetError(btnHideMKCu, "Mật khẩu hiện tại không chính xác");
                }
                else
                {
                    err.SetError(btnHideMKCu, "");
                }
            }
        }

        private void txtMKMoi_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMKMoi.Text))
            {
                err.SetError(btnHideMKMoi, "Không được để trống");
            }
            else
            {
                if (!Regex.IsMatch(txtMKMoi.Text, "[a-zA-Z0-9]*"))
                {
                    err.SetError(btnHideMKMoi, "Mật khẩu mới không hợp lệ");
                }
                else
                {
                    err.SetError(btnHideMKMoi, "");
                }
            }
        }

        private void txtXacNhanMK_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtXacNhanMK.Text))
            {
                err.SetError(btnHideXNMK, "Không được để trống");
            }
            else
            {
                if (!Regex.IsMatch(txtXacNhanMK.Text, txtMKMoi.Text))
                {
                    err.SetError(btnHideXNMK, "Mật khẩu xác nhận không khớp với mật khẩu mới");
                }
                else
                {
                    err.SetError(btnHideXNMK, "");
                }
            }
        }
    }
}
