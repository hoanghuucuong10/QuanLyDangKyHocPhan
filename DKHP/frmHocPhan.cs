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
using System.Text.RegularExpressions;
using DKHP.ViewModels;

namespace DKHP
{
    public partial class frmHocPhan : Form
    {
        private static frmHocPhan _instance;
        int kt = 0;
        HocPhanBLL hocPhanBLL = new HocPhanBLL();


        public static frmHocPhan instance
        {
            // uses lazy initialization.

            // note: this is not thread safe.
            get
            {
                if (_instance == null)
                {
                    _instance = new frmHocPhan();
                }

                return _instance;
            }

        }


        public frmHocPhan()
        {
            InitializeComponent();
            LoadDatagridView(hocPhanBLL.GetALLHocPhan(), dgvHocPhan);
        }

        public void LoadDatagridView(List<eHocPhan> lst, DataGridView dgv)
        {
            List<HocPhanViewModels> lstHP = lst.Select(t => new HocPhanViewModels(t)).ToList(); 
            dgv.DataSource = lstHP;
       
            dgv.Columns["ID_HocPhan"].HeaderText = "Mã Học Phần";
            dgv.Columns[0].Width = 200;
            dgv.Columns["TenMonHoc"].HeaderText = "Tên Môn Học";
            dgv.Columns[1].Width = 300;
            dgv.Columns["SoTC"].HeaderText = "Số Tín Chỉ";
            dgv.Columns[2].Width = 200;

            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.BackgroundColor = Color.White;
        }

        public void XemThongTin()
        {
            groupBox1.Text = "Thông Tin Học Phần";
            instance.tbxID.ReadOnly = true;
            instance.tbxTenMonHoc.ReadOnly = true;
            instance.numSoTC.ReadOnly = true;

        }

        public void Them()
        {
            groupBox1.Text = "Thêm Học Phần";
            instance.tbxID.ReadOnly = true;
            instance.tbxTenMonHoc.ReadOnly = false;
            instance.numSoTC.ReadOnly = false;
            instance.btnLuu.Visible = true;
            instance.btnHuy.Visible = true;

            ShowDataGrid();
        }

        public void ChinhSua()
        {

            groupBox1.Text = "Chỉnh Sửa Học Phần";
            instance.tbxID.ReadOnly = true;
            instance.tbxTenMonHoc.ReadOnly = false;
            instance.numSoTC.ReadOnly = false;
            instance.btnLuu.Visible = true;
            instance.btnHuy.Visible = true;

            ShowDataGrid();

        }

        private void ShowDataGrid()
        {
            int rowSelected = 0;
            try
            {
                rowSelected = dgvHocPhan.CurrentRow.Index;
            }
            catch (Exception e)
            {

            }


            if (groupBox1.Text != "Thêm Học Phần")
            {
                eHocPhan hp = hocPhanBLL.GetHocPhanByID(dgvHocPhan.Rows[rowSelected].Cells[0].Value.ToString());
                tbxID.Text = hp.ID_HocPhan;
                tbxTenMonHoc.Text = hp.TenMonHoc;
                numSoTC.Value = hp.SoTC.Value;
            }
        }



        private void btnHuy_Click(object sender, EventArgs e)
        {
            instance.XemThongTin();
            btnHuy.Visible = false;
            btnLuu.Visible = false;
            btnThem.Visible = true;
            btnSua.Visible = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            kt = 0;
            if (string.IsNullOrEmpty(tbxTenMonHoc.Text))
            {
                err.SetError(tbxTenMonHoc, "Không được để trống");
            }
            else
            {
                if (!Regex.IsMatch(tbxTenMonHoc.Text, @"^[a-zA-Z_ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéếêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ\s]+$"))
                {
                    err.SetError(tbxTenMonHoc, "Tên không hợp lệ");
                }
                else
                {
                    err.SetError(tbxTenMonHoc, "");
                    kt++;
                }
            }

            if (numSoTC.Value <= 0)
            {
                err.SetError(numSoTC, "Số tín chỉ phải lớn hơn 0");
            }
            else
            {
                err.SetError(numSoTC, "");
                kt++;
            }

            if (kt == 2)
            {
                eHocPhan hp = new eHocPhan();
                hp.ID_HocPhan = tbxID.Text.Trim();
                hp.TenMonHoc = tbxTenMonHoc.Text.Trim();
                hp.SoTC = int.Parse(numSoTC.Value.ToString());



                if (groupBox1.Text == "Thêm Học Phần")
                {
                    if (hocPhanBLL.AddNewHocPhan(hp) == null)
                    {
                        MessageBox.Show("Lưu Thất Bại!!!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thành Công");
                        kt = 0;
                        LoadDatagridView(hocPhanBLL.GetALLHocPhan(), dgvHocPhan);
                        ShowDataGrid();
                    }
                }
                else
                {
                    if (hocPhanBLL.EditHocPhan(hp.ID_HocPhan, hp) == null)
                    {
                        MessageBox.Show("Lưu Thất Bại!!!");
                    }
                    else
                    {
                        MessageBox.Show("Chỉnh Sửa Thành Công");
                        kt = 0;
                        LoadDatagridView(hocPhanBLL.GetALLHocPhan(), dgvHocPhan);
                        ShowDataGrid();
                    }
                }
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            instance.ChinhSua();
            btnHuy.Visible = true;
            btnLuu.Visible = true;
            btnSua.Visible = false;
            btnThem.Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            instance.Them();
            btnHuy.Visible = true;
            btnLuu.Visible = true;
            btnSua.Visible = false;
            btnThem.Visible = false;

            tbxID.Text = hocPhanBLL.CreateID();
            tbxTenMonHoc.Text = "";
            numSoTC.Value = 0;
        }

        private void dgvHocPhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowDataGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadDatagridView(hocPhanBLL.SearchHocPhan(tbxIDSearch.Text.Trim(), tbTenSearch.Text.Trim()),dgvHocPhan);
        }


    }
}
