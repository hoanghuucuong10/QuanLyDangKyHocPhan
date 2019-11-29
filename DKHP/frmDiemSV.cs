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
using DKHP.ViewModels;
using DGVPrinterHelper;

namespace DKHP
{
    public partial class frmDiemSV : Form
    {
        public eSinhVien eSV = new eSinhVien();
        SinhVienBLL svBLL = new SinhVienBLL();
        DiemBLL diemBLL = new DiemBLL();
        int pKT;
        public frmDiemSV(eSinhVien e)
        {
            InitializeComponent();
            this.eSV = e;
            btnSearch.Visible = false;
            txtID.ReadOnly = true;
            Load_dgvHeader();
            Search();
            pKT = 0;
        }
        public frmDiemSV()
        {
            InitializeComponent();
            Load_dgvHeader();
            pKT = 1;
        }
        public void Load_dgvHeader()
        {
            dgvHeader.EnableHeadersVisualStyles = false;
            dgvHeader.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            dgvHeader.AllowUserToResizeRows = false;
            dgvHeader.AllowUserToResizeColumns = false;
            dgvHeader.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dgvHeader.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dgvHeader.Columns[2].HeaderCell.Style.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dgvHeader.Columns[3].HeaderCell.Style.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dgvHeader.Columns[4].HeaderCell.Style.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dgvHeader.Columns[5].HeaderCell.Style.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dgvHeader.Columns[6].HeaderCell.Style.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dgvHeader.Columns[7].HeaderCell.Style.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dgvHeader.Columns[8].HeaderCell.Style.Font = new Font("Tahoma", 9, FontStyle.Bold);

            dgvHeader.Columns[0].HeaderCell.Style.ForeColor = Color.White;
            dgvHeader.Columns[1].HeaderCell.Style.ForeColor = Color.White;
            dgvHeader.Columns[2].HeaderCell.Style.ForeColor = Color.White;
            dgvHeader.Columns[3].HeaderCell.Style.ForeColor = Color.White;
            dgvHeader.Columns[4].HeaderCell.Style.ForeColor = Color.White;
            dgvHeader.Columns[5].HeaderCell.Style.ForeColor = Color.White;
            dgvHeader.Columns[6].HeaderCell.Style.ForeColor = Color.White;
            dgvHeader.Columns[7].HeaderCell.Style.ForeColor = Color.White;
            dgvHeader.Columns[8].HeaderCell.Style.ForeColor = Color.White;

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
        public void Search()
        {
            if (pKT == 1)
            {
                eSinhVien sv = new eSinhVien();
                sv = svBLL.GetSinhVienByID(txtID.Text.Trim());
                if (sv != null)
                {
                    eSV = sv;
                    this.eSV = sv;
                    txtAddress.Text = eSV.DiaChi;
                    txtLopNC.Text = new LopNienCheBLL().GetLopNienCheByID(eSV.ID_LopNienChe.Trim()).TenLop.Trim();
                    txtMail.Text = eSV.Mail;
                    txtPhone.Text = eSV.SDT;
                    txtTen.Text = eSV.HoVaTen;
                    if (eSV.HinhAnh != null)
                    {
                        picHinhAnh.Image = ByteToImg(Convert.ToBase64String(eSV.HinhAnh));
                    }
                    LoadDiem(sv.ID_SinhVien.Trim());
                    btnPrint.Visible = true;
                }
                else
                {
                    MessageBox.Show("Sai mã số sinh viên");
                    btnPrint.Visible = false;
                }
            }
            else
            {
                txtAddress.Text = eSV.DiaChi;
                txtLopNC.Text = new LopNienCheBLL().GetLopNienCheByID(eSV.ID_LopNienChe.Trim()).TenLop.Trim();
                txtMail.Text = eSV.Mail;
                txtPhone.Text = eSV.SDT;
                txtTen.Text = eSV.HoVaTen;
                if (eSV.HinhAnh != null)
                {
                    picHinhAnh.Image = ByteToImg(Convert.ToBase64String(eSV.HinhAnh));
                }
                LoadDiem(eSV.ID_SinhVien.Trim());
                btnPrint.Visible = true;
            }
        }
        //Search SV
        private void button1_Click(object sender, EventArgs e)
        {
            Search();
        }
        List<DiemSinhVienViewModels> lstDiem;
        List<string> lstHocKy = new List<string>();
        List<DiemSinhVienViewModels> lst = new List<DiemSinhVienViewModels>();
        public void LoadDiem(string id)
        {

            pnDiemSV.Controls.Clear();
            lst = new DiemBLL().GetDiemSV(id).Select(x => new DiemSinhVienViewModels
            {
                ID_LopHocPhan = x.ID_LopHocPhan.Trim(),
                TenMonHoc = new HocPhanBLL().GetHocPhanByID(new LopHocPhanBLL().GetLopHocPhanbyID(x.ID_LopHocPhan).ID_HocPhan.Trim()).TenMonHoc.Trim(),
                TK1 = x.TK1.ToString(),
                TK2 = x.TK2.ToString(),
                TK3 = x.TK3.ToString(),
                GK = x.GK.ToString(),
                CK = x.CK.ToString(),
                HocKy = new LopHocPhanBLL().GetLopHocPhanbyID(x.ID_LopHocPhan).HocKy.Value,
                NamHoc = new NienKhoaBLL().GetNienKhoaByID(new LopHocPhanBLL().GetLopHocPhanbyID(x.ID_LopHocPhan).ID_NienKhoa.Value).NienKhoa1.Trim()
            }).ToList();

            #region Xep loai
            foreach (DiemSinhVienViewModels x in lst)
            {
                if (x.TK1 != "" && x.TK2 != "" && x.TK3 != "" && x.GK != "" && x.CK != "")
                {
                    x.TongKet = (((float.Parse(x.TK1.Trim()) + float.Parse(x.TK2.Trim()) + float.Parse(x.TK3.Trim())) * 2 + float.Parse(x.GK.Trim()) * 3 + float.Parse(x.CK.Trim()) * 5) * 0.1).ToString();
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
               
                int kt = 0;
                foreach (string t in lstHocKy)
                {
                    if (t == "HK" + x.HocKy.ToString().Trim() + "(" + x.NamHoc.Trim() + ")")
                    {
                        kt = 1;
                        break;
                    }
                }
                if (kt == 0)
                {
                    lstHocKy.Add("HK" + x.HocKy.ToString().Trim() + "(" + x.NamHoc.Trim() + ")");
                }
                #endregion
            }
            foreach (string a in lstHocKy)
            {
                lstDiem = new List<DiemSinhVienViewModels>();

                foreach (DiemSinhVienViewModels diem in lst)
                {
                    if (a == "HK" + diem.HocKy.ToString().Trim() + "(" + diem.NamHoc.Trim() + ")")
                    {
                        lstDiem.Add(diem);
                    }
                }

                #region AddGrid
                if (lstDiem.Count > 0)
                {
                    Label labelHK = new Label();
                    labelHK.BorderStyle = BorderStyle.FixedSingle;
                    labelHK.Width = 820;
                    labelHK.BackColor = Color.Gray;
                    labelHK.TextAlign = ContentAlignment.MiddleCenter;
                    labelHK.Text = a;

                    pnDiemSV.Controls.Add(labelHK);
                    DataGridView d = new DataGridView();
                    LoadDgv(d);
                    #endregion
                }

            }
        }
     
        public void LoadDgv(DataGridView d)
        {
            d.BorderStyle = BorderStyle.FixedSingle;
            d.BackgroundColor = Color.White;
            d.RowHeadersVisible = false;
            d.ColumnHeadersVisible = false;
            d.Width = 820;
            d.ScrollBars = ScrollBars.None;
            d.AllowUserToResizeRows = false;
            d.AllowUserToResizeColumns = false;
            d.AllowUserToAddRows = false;
            d.AllowUserToDeleteRows = false;

            d.DataSource = lstDiem;
            d.Visible = true;

            pnDiemSV.Controls.Add(d);
            int daa = d.Rows.Count;
            #region chỉnh kích thước cột
            int sss = d.Columns.Count;

            d.Height = lstDiem.Count() * d.Rows[0].Height;
            d.Columns["HocKy"].Visible = false;
            d.Columns["NamHoc"].Visible = false;
            d.Columns[0].Width = 180;
            d.Columns[1].Width = 220;
            d.Columns[4].Width = 60;
            d.Columns[5].Width = 60;
            d.Columns[6].Width = 60;
            d.Columns[7].Width = 60;
            d.Columns[8].Width = 60;
            d.Columns[9].Width = 60;
            d.Columns[10].Width = 60;

            d.Columns[0].ReadOnly = true;
            d.Columns[1].ReadOnly = true;
            d.Columns[9].ReadOnly = true;
            d.Columns[10].ReadOnly = true;

            #endregion
        }
        Bitmap bm;
        int height = 0;
        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.HasMorePages = false;
            height = 100;
            if (isPageOne == 1)
            {
                e.Graphics.DrawString("Kết Quả Học Tập", new Font("Tahoma", 23, FontStyle.Bold), Brushes.Blue, 280, 50);
                e.Graphics.DrawString("Mã Số Sinh Viên: " + eSV.ID_SinhVien, new Font("Tahoma", 12), Brushes.Black, 200, 100);
                e.Graphics.DrawString("Họ Và Tên Sinh Viên: " + eSV.HoVaTen, new Font("Tahoma", 12), Brushes.Black, 200, 120);
                e.Graphics.DrawString("Lớp Niên Chế: " + new LopNienCheBLL().GetLopNienCheByID(eSV.ID_LopNienChe.Trim()).TenLop, new Font("Tahoma", 12), Brushes.Black, 200, 140);
                height = 200;
                isPageOne = 0;
            }
            //Header
            bm = new Bitmap(dgvHeader.Width, dgvHeader.Height);
            dgvHeader.DrawToBitmap(bm, new Rectangle(0, 0, dgvHeader.Width, dgvHeader.Height));

            int x = 0, y = 0;

            Bitmap bmTemp = bm.Clone(new Rectangle(x, y, 820, bm.Height), bm.PixelFormat);

            Bitmap bmHeaderTemp = new Bitmap(bmTemp.Width * 8 / 10, bmTemp.Height * 8 / 10);
            Graphics graphicHeader = Graphics.FromImage(bmHeaderTemp);
            graphicHeader.DrawImage(bmTemp, 0, 0, bmTemp.Width * 8 / 10, bmTemp.Height * 8 / 10);

            e.Graphics.DrawImage(bmHeaderTemp, 100, height);
            graphicHeader.Dispose();


            height += dgvHeader.Height * 8 / 10;

            while (controlIndex < pnDiemSV.Controls.Count)
            {
                var control = pnDiemSV.Controls[controlIndex];
                if (control is DataGridView)
                {
                    ((DataGridView)control).ClearSelection();
                    int flag = 0;
                    while (indexDatagrid < ((DataGridView)control).Rows.Count)
                    {
                        DataGridViewRow r = new DataGridViewRow();
                        r = ((DataGridView)control).Rows[indexDatagrid];

                        Bitmap bmc = new Bitmap(((DataGridView)control).Width, ((DataGridView)control).Height);
                        r.DataGridView.DrawToBitmap(bmc, new Rectangle(0, 0, ((DataGridView)control).Width, ((DataGridView)control).Height));


                        Bitmap CroppedImage = bmc.Clone(new Rectangle(0, indexDatagrid * r.Height, ((DataGridView)control).Width, r.Height), bmc.PixelFormat);

                        Bitmap bmLBTemp = new Bitmap(CroppedImage.Width * 8 / 10, CroppedImage.Height * 8 / 10);
                        Graphics graphicLB = Graphics.FromImage(bmLBTemp);
                        graphicLB.DrawImage(CroppedImage, 0, 0, CroppedImage.Width * 8 / 10, CroppedImage.Height * 8 / 10);

                        e.Graphics.DrawImage(bmLBTemp, 100, height);
                        graphicLB.Dispose();


                        height += r.Height * 8 / 10;

                        if (height >= e.PageBounds.Height - 100)
                        {
                            e.HasMorePages = true;
                            flag = 1;
                            break;
                        }
                        indexDatagrid++;
                        if (indexDatagrid == ((DataGridView)control).Rows.Count)
                        {
                            controlIndex++;
                        }
                    }
                    if (flag == 1)
                    {
                        break;
                    }
                }
                else if (control is Label)
                {
                    bm = new Bitmap(dgvHeader.Width, dgvHeader.Height);
                    ((Label)control).DrawToBitmap(bm, new Rectangle(0, 0, dgvHeader.Width, dgvHeader.Height));

                    Bitmap bmLBTemp = new Bitmap(bm.Width * 8 / 10, bm.Height * 8 / 10);
                    Graphics graphicLB = Graphics.FromImage(bmLBTemp);
                    graphicLB.DrawImage(bm, 0, 0, bm.Width * 8 / 10, bm.Height * 8 / 10);

                    e.Graphics.DrawImage(bmLBTemp, 100, height);
                    graphicLB.Dispose();

                    height += ((Label)control).Height * 8 / 10;

                    if (height >= e.PageBounds.Height - 100)
                    {
                        e.HasMorePages = true;
                        controlIndex++;
                        indexDatagrid = 0;
                        break;
                    }
                    controlIndex++;
                    indexDatagrid = 0;
                }

            }
        }
        int isPageOne = 0;
        int controlIndex = 0;
        int indexDatagrid = 0;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            isPageOne = 1;
            controlIndex = 0;
            indexDatagrid = 0;
            printPreView.Document = printDoc;

            if (printPreView.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }
    }
}
