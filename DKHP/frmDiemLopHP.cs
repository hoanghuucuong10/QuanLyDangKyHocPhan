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
        List<DiemLopHocPhanViewModels> lstEdit = new List<DiemLopHocPhanViewModels>();
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
            LoadDiem();
        }
        public void LoadDiem()
        {
            string id = tbIDLopHP.Text.Trim();
            eLopHocPhan elhp = new LopHocPhanBLL().GetLopHocPhanbyID(id);
            if (elhp != null)
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
                lbMonHoc.Text ="Tên Môn Học: "+ lopHP.TenMonHoc.Trim();
                lbSoTC.Text = "Số Tín Chỉ: " +new HocPhanBLL().GetHocPhanByID(lopHP.ID_HocPhan).SoTC.ToString();
                lbHocKy.Text = "Học kỳ: "+"Kỳ " + lopHP.HocKy + " (" + lopHP.NienKhoa + ")";
                lbGiangVien.Text = "Giảng Viên: " + lopHP.TenGiangVien;
 

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
                foreach (DiemLopHocPhanViewModels x in lst)
                {
                    if (x.TK1 != "" && x.TK2 != "" && x.TK3 != "" && x.GK != "" && x.CK != "")
                    {
                        x.TongKet = (((float.Parse(x.TK1.Trim()) + float.Parse(x.TK2.Trim()) + float.Parse(x.TK3.Trim())) / 3 * 2 + float.Parse(x.GK.Trim()) * 3 + float.Parse(x.CK.Trim()) * 5) * 0.1).ToString();
                        if (float.Parse(x.TongKet.Trim()) <= 3)
                            x.XepLoai = "E";
                        else if (float.Parse(x.TongKet.Trim()) < 5)
                            x.XepLoai = "D";
                        else if (float.Parse(x.TongKet.Trim()) < 6.5)
                            x.XepLoai = "C";
                        else if (float.Parse(x.TongKet.Trim()) < 8)
                            x.XepLoai = "B";
                        else if (float.Parse(x.TongKet.Trim()) <= 10)
                            x.XepLoai = "A";
                        else
                            x.XepLoai = "";
                    }
                    else
                    {
                        x.XepLoai = "";
                        x.TongKet = "";
                    }
                }
                if (lst != null)
                {
                    diemLopHocPhanViewModelsBindingSource.DataSource = lst;
                    btnPrint.Visible = true;
                }

            }
            else
            {
                MessageBox.Show("Mã lớp học phần không đúng");
                diemLopHocPhanViewModelsBindingSource.DataSource = null;
                btnPrint.Visible = false;

                lbMonHoc.Text = "Tên Môn Học: ";
                lbSoTC.Text = "Số Tín Chỉ: ";
                lbHocKy.Text = "Học kỳ: ";
                lbGiangVien.Text = "Giảng Viên: ";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            foreach (DiemLopHocPhanViewModels d in lstEdit)
            {
                eDiem diem = new eDiem();
                diem.ID_LopHocPhan = tbIDLopHP.Text.Trim();
                diem.ID_SinhVien = d.ID_SinhVien;
                if (d.TK1 != "")
                {
                    diem.TK1 = double.Parse(d.TK1.Trim());
                }
                if (d.TK2 != "")
                {
                    diem.TK2 = double.Parse(d.TK2.Trim());
                }
                if (d.TK3 != "")
                {
                    diem.TK3 = double.Parse(d.TK3.Trim());
                }
                if (d.GK != "")
                {
                    diem.GK = double.Parse(d.GK.Trim());
                }
                if (d.CK != "")
                {
                    diem.CK = double.Parse(d.CK.Trim());
                }
                new DiemBLL().EditDiemLopHP(diem);
            }
            MessageBox.Show("Đã Lưu");
            btnLuu.Visible = false;
            btnHuy.Visible = false;
            lstEdit = new List<DiemLopHocPhanViewModels>();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadDiem();
            lstEdit = new List<DiemLopHocPhanViewModels>();
            btnHuy.Visible = false;
            btnLuu.Visible = false;
        }
        string temp = "";
        private void dgvDiem_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridView d = sender as DataGridView;
            temp = d.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        private void dgvDiem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView d = sender as DataGridView;
            string a = "";
            if (d.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                a = d.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Trim();
            }
            double x = 0;

            if (double.TryParse(a, out x) || a == "")
            {
                string idSinhVien = "";
                string tk1 = "";
                string tk2 = "";
                string tk3 = "";
                string gk = "";
                string ck = "";
                string tongKet = "";
                string xepLoai = "";
                if (d.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    idSinhVien = d.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                }
                if (d.Rows[e.RowIndex].Cells[4].Value != null)
                {
                    tk1 = d.Rows[e.RowIndex].Cells[4].Value.ToString().Trim();
                }
                if (d.Rows[e.RowIndex].Cells[5].Value != null)
                {
                    tk2 = d.Rows[e.RowIndex].Cells[5].Value.ToString().Trim();
                }
                if (d.Rows[e.RowIndex].Cells[6].Value != null)
                {
                    tk3 = d.Rows[e.RowIndex].Cells[6].Value.ToString().Trim();
                }
                if (d.Rows[e.RowIndex].Cells[7].Value != null)
                {
                    gk = d.Rows[e.RowIndex].Cells[7].Value.ToString().Trim();
                }
                if (d.Rows[e.RowIndex].Cells[8].Value != null)
                {
                    ck = d.Rows[e.RowIndex].Cells[8].Value.ToString().Trim();
                }
                if (d.Rows[e.RowIndex].Cells[9].Value != null)
                {
                    tongKet = d.Rows[e.RowIndex].Cells[9].Value.ToString().Trim();
                }
                if (d.Rows[e.RowIndex].Cells[10].Value != null)
                {
                    xepLoai = d.Rows[e.RowIndex].Cells[10].Value.ToString().Trim();
                }

                DiemLopHocPhanViewModels diemEdit = new DiemLopHocPhanViewModels
                {
                    ID_SinhVien = idSinhVien,
                    TK1 = tk1,
                    TK2 = tk2,
                    TK3 = tk3,
                    GK = gk,
                    CK = ck,
                    TongKet = tongKet,
                    XepLoai = xepLoai,
                };

                if (diemEdit.TK1 != "" && diemEdit.TK2 != "" && diemEdit.TK3 != "" && diemEdit.GK != "" && diemEdit.CK != "")
                {
                    diemEdit.TongKet = (((float.Parse(diemEdit.TK1.Trim()) + float.Parse(diemEdit.TK2.Trim()) + float.Parse(diemEdit.TK3.Trim())) / 3 * 2 + float.Parse(diemEdit.GK.Trim()) * 3 + float.Parse(diemEdit.CK.Trim()) * 5) * 0.1).ToString();
                    if (float.Parse(diemEdit.TongKet.Trim()) <= 3)
                        diemEdit.XepLoai = "E";
                    else if (float.Parse(diemEdit.TongKet.Trim()) < 5)
                        diemEdit.XepLoai = "D";
                    else if (float.Parse(diemEdit.TongKet.Trim()) < 6.5)
                        diemEdit.XepLoai = "C";
                    else if (float.Parse(diemEdit.TongKet.Trim()) < 8)
                        diemEdit.XepLoai = "B";
                    else if (float.Parse(diemEdit.TongKet.Trim()) <= 10)
                        diemEdit.XepLoai = "A";
                    else
                        diemEdit.XepLoai = "";
                }
                else
                {
                    diemEdit.XepLoai = "";
                    diemEdit.TongKet = "";
                }

                d.Rows[e.RowIndex].Cells[9].Value = diemEdit.TongKet;
                d.Rows[e.RowIndex].Cells[10].Value = diemEdit.XepLoai;

                btnLuu.Visible = true;
                btnHuy.Visible = true;
                int flag = 0;
                foreach (DiemLopHocPhanViewModels t in lstEdit)
                {
                    flag = 0;
                    if (t.ID_SinhVien == diemEdit.ID_SinhVien)
                    {
                        t.TK1 = diemEdit.TK1;
                        t.TK2 = diemEdit.TK2;
                        t.TK3 = diemEdit.TK3;
                        t.GK = diemEdit.GK;
                        t.CK = diemEdit.CK;
                        t.TongKet = diemEdit.TongKet;
                        t.XepLoai = diemEdit.XepLoai;
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    lstEdit.Add(diemEdit);
                }
            }
            else
            {
                MessageBox.Show("Nhập sai");
                d.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = temp;
            }
        }

        int isPageOne = 0;

        int indexDatagrid = 0;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            isPageOne = 1;

            indexDatagrid = 0;
            printPreView.Document = printDoc;

            if (printPreView.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }
        Bitmap bm;
        int height = 0;
        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.HasMorePages = false;
            height = 100;
            if (isPageOne == 1)
            {
                e.Graphics.DrawString("Bảng Điểm Lớp Học Phần", new Font("Tahoma", 23, FontStyle.Bold), Brushes.Blue, 280, 50);
                e.Graphics.DrawString("Mã Lớp Học Phần: " + tbIDLopHP.Text.Trim(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Gray, 200, 100);
                e.Graphics.DrawString(lbMonHoc.Text.Trim(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Gray, 200, 120);
                e.Graphics.DrawString(lbGiangVien.Text.Trim(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Gray, 200, 140);
                e.Graphics.DrawString(lbHocKy.Text.Trim(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Gray, 200, 160);
                e.Graphics.DrawString(lbSoTC.Text.Trim(), new Font("Tahoma", 12, FontStyle.Bold), Brushes.Gray, 200, 180);

                height = 220;
                isPageOne = 0;
            }
            //Header
            bm = new Bitmap(dgvDiem.Width, dgvDiem.Height);
            dgvDiem.DrawToBitmap(bm, new Rectangle(0, 0, dgvDiem.Width, dgvDiem.ColumnHeadersHeight));
            int x = 0, y = 0;

            Bitmap bmTemp = bm.Clone(new Rectangle(x, y, 1150, bm.Height), bm.PixelFormat);

            Bitmap bmHeaderTemp = new Bitmap(bmTemp.Width * 6 / 10, bmTemp.Height * 6 / 10);
            Graphics graphicHeader = Graphics.FromImage(bmHeaderTemp);
            graphicHeader.DrawImage(bmTemp, 0, 0, bmTemp.Width * 6 / 10, bmTemp.Height * 6 / 10);

            e.Graphics.DrawImage(bmHeaderTemp, 70, height);
            graphicHeader.Dispose();


            height += dgvDiem.ColumnHeadersHeight * 6 / 10;




            dgvDiem.ClearSelection();
            int flag = 0;
            while (indexDatagrid < dgvDiem.Rows.Count)
            {

                Bitmap bmc = new Bitmap(dgvDiem.Width, dgvDiem.Height);
                dgvDiem.DrawToBitmap(bmc, new Rectangle(0, 0, dgvDiem.Width, dgvDiem.Height));


                Bitmap CroppedImage = bmc.Clone(new Rectangle(0, indexDatagrid * dgvDiem.Rows[0].Height + dgvDiem.ColumnHeadersHeight, dgvDiem.Width, dgvDiem.Rows[0].Height), bmc.PixelFormat);

                Bitmap bmLBTemp = new Bitmap(CroppedImage.Width * 6 / 10, CroppedImage.Height * 6 / 10);
                Graphics graphicLB = Graphics.FromImage(bmLBTemp);
                graphicLB.DrawImage(CroppedImage, 0, 0, CroppedImage.Width * 6 / 10, CroppedImage.Height * 6 / 10);

                e.Graphics.DrawImage(bmLBTemp, 70, height);
                graphicLB.Dispose();


                height += dgvDiem.Rows[0].Height * 6 / 10;

                if (height >= e.PageBounds.Height - 100)
                {
                    e.HasMorePages = true;
                    flag = 1;
                    break;
                }
                indexDatagrid++;

            }

        }

    }
}

