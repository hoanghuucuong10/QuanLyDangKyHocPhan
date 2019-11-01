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
using System.IO;

namespace DKHP
{
    public partial class frmDiemSV : Form
    {
        private static frmDiemSV _instance;
        SinhVienBLL svBLL = new SinhVienBLL();
        DiemBLL diemBLL = new DiemBLL();
        public static frmDiemSV Instance
        {
            // Uses lazy initialization.

            // Note: this is not thread safe.
            get
            {
                if (_instance == null)
                {
                    _instance = new frmDiemSV();
                }

                return _instance;
            }

        }

        public frmDiemSV()
        {
            InitializeComponent();
        }

        private Image ByteToImg(string byteString)
        {
            try
            {
                byte[] imgBytes = Convert.FromBase64String(byteString);
                MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
                ms.Write(imgBytes, 0, imgBytes.Length);
                Image image = Image.FromStream(ms, true);
                return image;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        //Search SV
        private void button1_Click(object sender, EventArgs e)
        {
            eSinhVien sv = new eSinhVien();
            sv = svBLL.GetSinhVienByID(tbxID.Text.Trim());
            if(sv!=null)
            {
                tbxAddress.Text = sv.DiaChi;
          //      tbxLopNC.Text = sv.LopNienChe.TenLop;
                tbxMail.Text = sv.Mail;
                tbxPhone.Text = sv.SDT;
                tbxTen.Text = sv.HoVaTen;
                if (sv.HinhAnh != null)
                {
                    pictureBox1.Image = ByteToImg(Convert.ToBase64String(sv.HinhAnh));
                }
                ShowDataGridView(diemBLL.GetDiemSV(sv.ID_SinhVien), dataGridView1);
            }
            else
            {
                MessageBox.Show("Sai mã số sinh viên");
            }
        }
        private void ShowDataGridView(List<eDiem> lst, DataGridView dgv)
        {
            dgv.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgv.MultiSelect = false;
            dgv.BackgroundColor = Color.White;
            if (lst.Count == 0)
            {
                MessageBox.Show("Không có điểm");
                return;
            }
            else
            {
                dgv.DataSource = dgv;

                dgv.Columns["id_LopHP"].HeaderText = "Mã Lớp Học Phần";
                dgv.Columns["id_LopHP"].Width = 80;

                dgv.Columns["tenHP"].HeaderText = "Tên Môn Học";
                dgv.Columns["tenHP"].Width = 140;

             

                dgv.Columns["tk1"].HeaderText = "Điểm Thường Kỳ 1";
                dgv.Columns["tk1"].Width = 80;

                dgv.Columns["tk2"].HeaderText = "Điểm Thường Kỳ 2";
                dgv.Columns["tk2"].Width = 80;

                dgv.Columns["tk3"].HeaderText = "Điểm Thường Kỳ 3";
                dgv.Columns["tk3"].Width = 80;

                dgv.Columns["gk"].HeaderText = "Điểm Giữa Kỳ";
                dgv.Columns["gk"].Width = 80;

                dgv.Columns["ck"].HeaderText = "Điểm Cuối Kỳ";
                dgv.Columns["ck"].Width = 80;

                dgv.Columns["tb"].HeaderText = "Điểm Trung Bình";
                dgv.Columns["tb"].Width = 80;


                dgv.Columns["id_SinhVien"].Visible = false;
                dgv.Columns["hoTenSV"].Visible = false;
                dgv.Columns["tenLopNC"].Visible = false;
                dgv.Columns["hocKy"].Visible = false;
                dgv.Columns["namHoc"].Visible = false;
                dgv.Columns["tenGiangVien"].Visible = false;
                
            }
           
        }
    }
}
