using BLL;
using DGVPrinterHelper;
using DKHP.ViewModels;
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

namespace DKHP
{
    public partial class frmDiemLopHocPhanGV : Form
    {
        public eGiangVien eGV { get; set; }
        List<DiemLopHocPhanViewModels> lstEdit = new List<DiemLopHocPhanViewModels>();
        public frmDiemLopHocPhanGV(eGiangVien x)
        {
            InitializeComponent();
            this.eGV = x;
            LoadTreeView();
        }
        public void LoadTreeView()
        {
            List<eNienKhoa> lstNienKhoa = new NienKhoaBLL().GetAllNienKhoa();
            int i = 0;
            foreach (eNienKhoa x in lstNienKhoa)
            {
                List<LopHocPhanViewModels> lstLopHP = new List<LopHocPhanViewModels>();
                TreeNode node = new TreeNode(x.NienKhoa1);
                node.Tag = x.ID_NienKhoa;
                treeLopHocPhan.Nodes.Add(node);
                TreeNode node1 = new TreeNode("Học Kỳ 1");
                node1.Tag = 1;
                treeLopHocPhan.Nodes[i].Nodes.Add(node1);
                lstLopHP = new LopHocPhanBLL().GetAllLopHocPhanGiangVien(eGV.ID_GiangVien, 1, x.NienKhoa1).Select(g => new LopHocPhanViewModels
                {
                    ID_GiangVien = g.ID_GiangVien,
                    HocKy = g.HocKy.Value,
                    ID_HocPhan = g.ID_HocPhan,
                    ID_LopHocPhan = g.ID_LopHocPhan,
                    ID_NhanVienPDT = g.ID_NhanVienPDT,
                    ID_NienKhoa = g.ID_NienKhoa,
                    NgayBatDau = g.NgayBatDau,
                    NgayKetThuc = g.NgayKetThuc,
                    NienKhoa = new NienKhoaBLL().GetNienKhoaByID(g.ID_NienKhoa.Value).NienKhoa1.Trim(),
                    SoLuong = g.SoLuong,
                    SoTiet = g.SoTiet,
                    TenGiangVien = new GiangVienBLL().GetGiangVienByID(g.ID_GiangVien).HoVaTen,
                    TenMonHoc = new HocPhanBLL().GetHocPhanByID(g.ID_HocPhan).TenMonHoc.Trim(),
                    TrangThai = g.TrangThai
                }).ToList();
                if (lstLopHP.Count > 0)
                {
                    foreach (LopHocPhanViewModels u in lstLopHP)
                    {
                        TreeNode nodeLHP = new TreeNode(u.ID_LopHocPhan + "   " + u.TenMonHoc);
                        nodeLHP.Tag = u.ID_LopHocPhan.Trim();
                        treeLopHocPhan.Nodes[i].Nodes[0].Nodes.Add(nodeLHP);
                    }
                }
                TreeNode node2 = new TreeNode("Học Kỳ 2");
                node1.Tag = 2;
                treeLopHocPhan.Nodes[i].Nodes.Add(node2);
                lstLopHP = new LopHocPhanBLL().GetAllLopHocPhanGiangVien(eGV.ID_GiangVien, 2, x.NienKhoa1).Select(g => new LopHocPhanViewModels
                {
                    ID_GiangVien = g.ID_GiangVien,
                    HocKy = g.HocKy.Value,
                    ID_HocPhan = g.ID_HocPhan,
                    ID_LopHocPhan = g.ID_LopHocPhan,
                    ID_NhanVienPDT = g.ID_NhanVienPDT,
                    ID_NienKhoa = g.ID_NienKhoa,
                    NgayBatDau = g.NgayBatDau,
                    NgayKetThuc = g.NgayKetThuc,
                    NienKhoa = new NienKhoaBLL().GetNienKhoaByID(g.ID_NienKhoa.Value).NienKhoa1.Trim(),
                    SoLuong = g.SoLuong,
                    SoTiet = g.SoTiet,
                    TenGiangVien = new GiangVienBLL().GetGiangVienByID(g.ID_GiangVien).HoVaTen,
                    TenMonHoc = new HocPhanBLL().GetHocPhanByID(g.ID_HocPhan).TenMonHoc.Trim(),
                    TrangThai = g.TrangThai
                }).ToList();
                if (lstLopHP.Count > 0)
                {
                    foreach (LopHocPhanViewModels u in lstLopHP)
                    {
                        TreeNode nodeLHP = new TreeNode(u.ID_LopHocPhan + "   " + u.TenMonHoc);
                        nodeLHP.Tag = u.ID_LopHocPhan.Trim();
                        treeLopHocPhan.Nodes[i].Nodes[1].Nodes.Add(nodeLHP);
                    }
                }

                TreeNode node3 = new TreeNode("Học Kỳ 3");
                node1.Tag = 3;
                treeLopHocPhan.Nodes[i].Nodes.Add(node3);
                lstLopHP = new LopHocPhanBLL().GetAllLopHocPhanGiangVien(eGV.ID_GiangVien, 3, x.NienKhoa1).Select(g => new LopHocPhanViewModels
                {
                    ID_GiangVien = g.ID_GiangVien,
                    HocKy = g.HocKy.Value,
                    ID_HocPhan = g.ID_HocPhan,
                    ID_LopHocPhan = g.ID_LopHocPhan,
                    ID_NhanVienPDT = g.ID_NhanVienPDT,
                    ID_NienKhoa = g.ID_NienKhoa,
                    NgayBatDau = g.NgayBatDau,
                    NgayKetThuc = g.NgayKetThuc,
                    NienKhoa = new NienKhoaBLL().GetNienKhoaByID(g.ID_NienKhoa.Value).NienKhoa1.Trim(),
                    SoLuong = g.SoLuong,
                    SoTiet = g.SoTiet,
                    TenGiangVien = new GiangVienBLL().GetGiangVienByID(g.ID_GiangVien).HoVaTen,
                    TenMonHoc = new HocPhanBLL().GetHocPhanByID(g.ID_HocPhan).TenMonHoc.Trim(),
                    TrangThai = g.TrangThai
                }).ToList();
                if (lstLopHP.Count > 0)
                {
                    foreach (LopHocPhanViewModels u in lstLopHP)
                    {
                        TreeNode nodeLHP = new TreeNode(u.ID_LopHocPhan + "   " + u.TenMonHoc);
                        nodeLHP.Tag = u.ID_LopHocPhan.Trim();
                        treeLopHocPhan.Nodes[i].Nodes[2].Nodes.Add(nodeLHP);
                    }
                }
                i++;
            }
        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {
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

        private void treeLopHocPhan_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoadDiem();
        }
        public void LoadDiem()
        {
            string idLopHP = "";
            if (treeLopHocPhan.SelectedNode != null)
            {
                if (treeLopHocPhan.SelectedNode.Tag == null)
                {
                    idLopHP = "";
                }
                else
                {
                    idLopHP = treeLopHocPhan.SelectedNode.Tag.ToString();
                }
            }
            if (idLopHP != "")
            {
                eLopHocPhan elhp = new LopHocPhanBLL().GetLopHocPhanbyID(idLopHP);
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
                    lbTenMH.Text = lopHP.TenMonHoc.Trim();
                    lbSoTC.Text = new HocPhanBLL().GetHocPhanByID(lopHP.ID_HocPhan).SoTC.ToString();
                    lbHocKy.Text = "Học kỳ " + lopHP.HocKy + " (" + lopHP.NienKhoa + ")";
                    lbIDLopHP.Text = lopHP.ID_LopHocPhan.Trim();

                    List<DiemLopHocPhanViewModels> lst = new DiemBLL().GetDiemLopHocPhan(idLopHP).Select(t => new DiemLopHocPhanViewModels
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
                    diemLopHocPhanViewModelsBindingSource.DataSource = null;
                    btnPrint.Visible = false;
                }
            }
        }
        private void txtIDLopHP_Enter(object sender, EventArgs e)
        {
            if (txtIDLopHP.Text == "Mã Lớp Học Phần")
            {
                txtIDLopHP.Text = "";
                txtIDLopHP.ForeColor = Color.Black;
            }
        }

        private void txtIDLopHP_Leave(object sender, EventArgs e)
        {
            if (txtIDLopHP.Text == "")
            {
                txtIDLopHP.Text = "Mã Lớp Học Phần";
                txtIDLopHP.ForeColor = Color.Silver;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string s = txtIDLopHP.Text.Trim();
            foreach (TreeNode x in treeLopHocPhan.Nodes)
            {
                foreach (TreeNode y in treeLopHocPhan.Nodes[x.Index].Nodes)
                {
                    foreach (TreeNode z in treeLopHocPhan.Nodes[x.Index].Nodes[y.Index].Nodes)
                    {
                        if (z.Tag.ToString() == s)
                        {
                            treeLopHocPhan.SelectedNode = z;
                            treeLopHocPhan.Refresh();
                            break;
                        }
                    }
                }
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
                e.Graphics.DrawString("Mã Lớp Học Phần: " + lbIDLopHP.Text.Trim(), new Font("Tahoma", 12), Brushes.Black, 200, 100);
                e.Graphics.DrawString("Tên Môn Học: " + lbTenMH.Text.Trim(), new Font("Tahoma", 12), Brushes.Black, 200, 120);
                e.Graphics.DrawString("Học Kỳ: " + lbHocKy.Text.Trim(), new Font("Tahoma", 12), Brushes.Black, 200, 140);
                e.Graphics.DrawString("Số Tín Chỉ: " + lbSoTC.Text.Trim(), new Font("Tahoma", 12), Brushes.Black, 200, 160);

                height = 200;
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            foreach (DiemLopHocPhanViewModels d in lstEdit)
            {
                eDiem diem = new eDiem();
                diem.ID_LopHocPhan = lbIDLopHP.Text.Trim();
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
            //if (temp != "")
            //{
            //    MessageBox.Show("Không thể sửa điểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    d.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = temp;
            //    return;
            //}
            string a = "";
            if (d.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                a = d.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Trim();
                int s = 0;
                if(int.TryParse(a,out s))
                {
                    if (int.Parse(a) < 0 || int.Parse(a) > 10)
                    {
                        MessageBox.Show("Điểm nhập vào không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        d.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = temp;
                        return;
                    }
                }    
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
                MessageBox.Show("Điểm nhập vào không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                d.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = temp;
            }
        }


    }
}
