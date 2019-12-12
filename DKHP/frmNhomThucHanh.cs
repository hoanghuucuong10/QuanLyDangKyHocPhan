using BLL;
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
using DKHP.ViewModels;
namespace DKHP
{
    public partial class frmNhomThucHanh : Form
    {
        NhomThucHanhBLL nTH = new NhomThucHanhBLL();
        public int flag { get; set; }
        public eNhomThucHanh nhomTH { get; set; }
        //thêm nhóm th
        public frmNhomThucHanh(string id_LopHP)
        {
            InitializeComponent();
            LoadCBB();
            LoadCBLich();
            this.flag = 0;
            btnXoa.Visible = false;
            nhomTH = new eNhomThucHanh();
            nhomTH.ID_LopHocPhan = id_LopHP;
            nhomTH.ID_NhomThucHanh = nTH.CreateID();
            nhomTH.LichHoc_NhomThucHanh = new List<eLichHoc_NhomThucHanh>();

            numNhom.Enabled = false;
           

            foreach (eNhomThucHanh x in frmLopHocPhan.instance.lstTH)
            {
                if (nhomTH.ID_NhomThucHanh == x.ID_NhomThucHanh)
                {
                    string id = nhomTH.ID_NhomThucHanh;
                    string numStr = id.Substring(2);
                    int num = int.Parse(numStr) + 1;

                    numStr = num.ToString();
                    while (numStr.Count() != 8)
                    {
                        numStr = "0" + numStr;
                    }
                    numStr = "th" + numStr;
                    nhomTH.ID_NhomThucHanh = numStr;
                }
            }
            tbIDTH.Text = nhomTH.ID_NhomThucHanh.Trim();
            tbMaLHP.Text = id_LopHP.Trim();

            int tenNhom = 1;

            foreach (eNhomThucHanh x in frmLopHocPhan.instance.lstTH.OrderBy(t=>t.TenNhom))
            {
                if(x.TenNhom.Trim()==tenNhom.ToString())
                {
                    tenNhom++;
                    
                }else
                {
                    break;
                }
            }
            numNhom.Value = tenNhom;

        }

        //sửa nhóm th
        public frmNhomThucHanh(eNhomThucHanh n)
        {
            InitializeComponent();
            LoadCBB();
            LoadCBLich();
            this.flag = 0;
            this.nhomTH = n;
            if (nhomTH.LichHoc_NhomThucHanh == null)
            {
                nhomTH.LichHoc_NhomThucHanh = new List<eLichHoc_NhomThucHanh>();
            }

            numNhom.Enabled = false;
            if (frmLopHocPhan.instance.GroupboxThongTin.Text == "Thông Tin Lớp Học Phần" ||(frmLopHocPhan.instance.GroupboxThongTin.Text != "Thông Tin Lớp Học Phần" && frmLopHocPhan.instance.cbTrangThai.SelectedItem.ToString().Trim() != "Lên Kế Hoạch"))
            {
                btnLuu.Visible = false;
                btnXoa.Visible = false;
                cbGiangVien.Enabled = false;
                cbMaGV.Enabled = false;

                numSoTiet.Enabled = false;
                numNhom.Enabled = false;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;

                btnThemLich.Visible = false;
                btnXoaLich.Visible = false;
                btnSuaLich.Visible = false;
                btnHuyLuuLichHoc.Visible = false;
                btnLuuLichHoc.Visible = false;
            }
            else
            {
                btnLuu.Visible = true;
                btnXoa.Visible = true;
                cbGiangVien.Enabled = false;
                cbMaGV.Enabled = false;

                numSoTiet.Enabled = true;
                numNhom.Enabled = false;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;

                btnThemLich.Visible = true;
                btnXoaLich.Visible = true;
                btnSuaLich.Visible = true;
                btnHuyLuuLichHoc.Visible = false;
                btnLuuLichHoc.Visible = false;
            }
            tbIDTH.Text = n.ID_NhomThucHanh.Trim();
            tbMaLHP.Text = n.ID_LopHocPhan.Trim();

            cbGiangVien.SelectedValue = nhomTH.ID_GiangVien.Trim();
            numNhom.Value = int.Parse(nhomTH.TenNhom);
            numSoTiet.Value = nhomTH.SoTiet.Value;
            dateTimePicker1.Value = nhomTH.NgayBatDau.Value;
            dateTimePicker2.Value = nhomTH.NgayKetThuc.Value;


            LoadDSLichHocNhomTH();
        }

        public void LoadCBB()
        {
            GiangVienBLL gv = new GiangVienBLL();
            cbGiangVien.DataSource = gv.GetAllGiangVien();
            cbGiangVien.DisplayMember = "HoVaTen";
            cbGiangVien.ValueMember = "ID_GiangVien";

            cbMaGV.DataSource = gv.GetAllGiangVien();
            cbMaGV.DisplayMember = "ID_GiangVien";
            cbMaGV.ValueMember = "HoVaTen";

            cbNgayHoc.Enabled = false;
            cbPhong.Enabled = false;
            cbTietHoc.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            nhomTH.ID_GiangVien = cbGiangVien.SelectedValue.ToString().Trim();
            nhomTH.TenNhom = numNhom.Value.ToString();
            nhomTH.SoTiet = int.Parse(numSoTiet.Value.ToString().Trim());
            nhomTH.SoLuong = new DangKyHocPhanBLL().SoLuongNhomTH(nhomTH.ID_NhomThucHanh);
            nhomTH.NgayBatDau = dateTimePicker1.Value;
            nhomTH.NgayKetThuc = dateTimePicker2.Value;

            List<eNhomThucHanh> lst = frmLopHocPhan.instance.lstTH;
            if(nhomTH.LichHoc_NhomThucHanh.Count()==0)
            {
                MessageBox.Show("Vui lòng thêm lịch học cho nhóm thực hành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int f = 0;
            //nhóm thực hành đã có trong lst (chỉnh sửa nhóm thực hành)
            foreach (eNhomThucHanh x in lst)
            {
                if (nhomTH.ID_NhomThucHanh == x.ID_NhomThucHanh)
                {
                    x.ID_GiangVien = nhomTH.ID_GiangVien;
                    x.ID_LopHocPhan = nhomTH.ID_LopHocPhan;
                    x.LichHoc_NhomThucHanh = nhomTH.LichHoc_NhomThucHanh;
                    x.TenNhom = nhomTH.TenNhom;
                    x.SoLuong = nhomTH.SoLuong;
                    x.NgayBatDau = nhomTH.NgayBatDau;
                    x.NgayKetThuc = nhomTH.NgayKetThuc;
                    x.LichHoc_NhomThucHanh = nhomTH.LichHoc_NhomThucHanh;
                    f = 1;
                }
            }
            if (f == 0)//nhóm thực hành mới
            {
                lst.Add(nhomTH);
            }

            frmLopHocPhan.instance.lstTH = lst;
            frmLopHocPhan.instance.LoadDanhSachNhom(lst);
            frmLopHocPhan.instance.dgvNhomTH.Refresh();
            this.Close();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (new NhomThucHanhBLL().CheckDelNhomTH(nhomTH.ID_NhomThucHanh.Trim()) == false)
            {
                MessageBox.Show("Lớp thực hành đã có sinh viên đăng ký, Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<eNhomThucHanh> lst = frmLopHocPhan.instance.lstTH;
            foreach (eNhomThucHanh t in lst)
            {
                if (t.ID_NhomThucHanh == nhomTH.ID_NhomThucHanh)
                {
                    lst.Remove(t);
                    frmLopHocPhan.instance.lstDelNhomTH.Add(t.ID_NhomThucHanh);
                    break;
                }
            }
            frmLopHocPhan.instance.lstTH = lst;
            frmLopHocPhan.instance.LoadDanhSachNhom(lst);
            frmLopHocPhan.instance.dgvNhomTH.Refresh();
            this.Close();
        }
        //------------------------------------Lich Hoc Thuc Hanh------------------------------------------------
        #region LichHoc
        private void btnXoaLich_Click(object sender, EventArgs e)
        {
            if (nhomTH.LichHoc_NhomThucHanh.Count == 0)
            {
                return;
            }
            cbPhong.Enabled = false;
            cbNgayHoc.Enabled = false;
            cbTietHoc.Enabled = false;

            btnLuuLichHoc.Visible = false;
            btnHuyLuuLichHoc.Visible = false;
            btnThemLich.Visible = true;
            btnSuaLich.Visible = true;
            btnXoaLich.Visible = true;

            foreach (eLichHoc_NhomThucHanh x in nhomTH.LichHoc_NhomThucHanh)
            {
                if (x.ID_LichHoc_NhomTH == int.Parse(dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[3].Value.ToString().Trim()))
                {
                    nhomTH.LichHoc_NhomThucHanh.Remove(x);
                    frmLopHocPhan.instance.lstDelLichTH.Add(x.ID_LichHoc_NhomTH);
                    break;
                }
            }

            LoadDSLichHocNhomTH();
        }

        private void btnSuaLich_Click(object sender, EventArgs e)
        {
            if (nhomTH.LichHoc_NhomThucHanh.Count == 0)
            {
                return;
            }
            this.flag = 1;
            cbPhong.Enabled = true;
            cbNgayHoc.Enabled = true;
            cbTietHoc.Enabled = true;

            btnLuuLichHoc.Visible = true;
            btnHuyLuuLichHoc.Visible = true;
            btnThemLich.Visible = false;
            btnSuaLich.Visible = false;
            btnXoaLich.Visible = false;

            try
            {
                cbNgayHoc.SelectedItem = dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[0].Value.ToString().Trim();
                cbTietHoc.SelectedItem = dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[1].Value.ToString().Trim();
                cbPhong.SelectedValue = dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[5].Value.ToString().Trim();
            }
            catch (Exception)
            {
            }
        }
        private void btnThemLich_Click(object sender, EventArgs e)
        {
            flag = 2;
            cbPhong.Enabled = true;
            cbNgayHoc.Enabled = true;
            cbTietHoc.Enabled = true;

            btnLuuLichHoc.Visible = true;
            btnHuyLuuLichHoc.Visible = true;
            btnThemLich.Visible = false;
            btnSuaLich.Visible = false;
            btnXoaLich.Visible = false;




        }
        private void btnLuuLichHoc_Click(object sender, EventArgs e)
        {
            cbPhong.Enabled = false;
            cbNgayHoc.Enabled = false;
            cbTietHoc.Enabled = false;

            btnLuuLichHoc.Visible = false;
            btnHuyLuuLichHoc.Visible = false;
            btnThemLich.Visible = true;
            btnSuaLich.Visible = true;
            btnXoaLich.Visible = true;

            eLichHoc_NhomThucHanh lich = new eLichHoc_NhomThucHanh();
            lich.ID_PhongHoc = cbPhong.SelectedValue.ToString().Trim();
            lich.TietHoc = cbTietHoc.SelectedItem.ToString();
            lich.NgayHoc = cbNgayHoc.SelectedItem.ToString();
            lich.ID_NhomThucHanh = tbIDTH.Text.Trim();

            //---------------------------------------------thêm lịch thực hành-------------------------------------------
            if (this.flag == 2)
            {


                lich.ID_LichHoc_NhomTH = -1;


                //kiểm tra lịch trùng trong list lịch 
                int f = 0;
                if (nhomTH.LichHoc_NhomThucHanh != null)
                {
                    foreach (eLichHoc_NhomThucHanh x in nhomTH.LichHoc_NhomThucHanh)
                    {
                        if (lich.ID_LichHoc_NhomTH == x.ID_LichHoc_NhomTH && lich.ID_LichHoc_NhomTH!=-1)
                            break;
                        if (x.TietHoc == "1-3" || x.TietHoc == "1-2" || x.TietHoc == "2-3" || x.TietHoc == "1-5")
                        {
                            if (lich.TietHoc == "1-3" || lich.TietHoc == "1-2" || lich.TietHoc == "2-3" || lich.TietHoc == "1-5")
                            {
                                f = 1;
                                break;
                            }
                        }
                        if (x.TietHoc == "4-6" || x.TietHoc == "5-6" || x.TietHoc == "4-5")
                        {
                            if (lich.TietHoc == "4-6" || lich.TietHoc == "4-5" || lich.TietHoc == "5-6" || lich.TietHoc == "1-5")
                            {
                                f = 1;
                                break;
                            }
                        }
                        if (x.TietHoc == "7-9" || x.TietHoc == "7-8" || x.TietHoc == "8-9" || x.TietHoc == "7-12")
                        {
                            if (lich.TietHoc == "7-9" || lich.TietHoc == "7-8" || lich.TietHoc == "8-9" || lich.TietHoc == "7-12")
                            {
                                f = 1;
                                break;
                            }
                        }
                        if (x.TietHoc == "10-12" || x.TietHoc == "10-11" || x.TietHoc == "11-12")
                        {
                            if (lich.TietHoc == "10-12" || lich.TietHoc == "10-11" || lich.TietHoc == "11-12" || lich.TietHoc == "7-12")
                            {
                                f = 1;
                                break;
                            }
                        }
                    }
                    if (new LichHocBLL().CheckLichTrungGiangVien(cbGiangVien.SelectedValue.ToString().Trim(), cbNgayHoc.SelectedItem.ToString().Trim(), cbTietHoc.SelectedItem.ToString().Trim(),int.Parse( frmLopHocPhan.instance.cbHocKy.SelectedItem.ToString()),int.Parse( frmLopHocPhan.instance.cbNamHoc.SelectedValue.ToString().Trim())))
                    {
                        f = 1;
                    }
                }
                if (f != 1)
                {
                    nhomTH.LichHoc_NhomThucHanh.Add(lich);
                }
                else
                {
                    MessageBox.Show("Lịch bị trùng, không thể thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                LoadDSLichHocNhomTH();
            }
            else if (flag == 1)  // ---------------------------------------------------------Sửa lịch thực hành---------------------------------
            {
                int index = nhomTH.LichHoc_NhomThucHanh.IndexOf(nhomTH.LichHoc_NhomThucHanh.Where(x => x.ID_LichHoc_NhomTH == int.Parse(dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[3].Value.ToString().Trim())).FirstOrDefault());
                int fl = 0;
                lich.ID_LichHoc_NhomTH = nhomTH.LichHoc_NhomThucHanh[index].ID_LichHoc_NhomTH;

                if (nhomTH.LichHoc_NhomThucHanh != null)
                {
                    foreach (eLichHoc_NhomThucHanh x in nhomTH.LichHoc_NhomThucHanh)
                    {
                        if (lich.ID_LichHoc_NhomTH != x.ID_LichHoc_NhomTH)
                        {
                            if (x.TietHoc == "1-3" || x.TietHoc == "1-2" || x.TietHoc == "2-3" || x.TietHoc == "1-5")
                            {
                                if (lich.TietHoc == "1-3" || lich.TietHoc == "1-2" || lich.TietHoc == "2-3" || lich.TietHoc == "1-5")
                                {
                                    fl = 1;
                                    break;
                                }
                            }
                            if (x.TietHoc == "4-6" || x.TietHoc == "5-6" || x.TietHoc == "4-5")
                            {
                                if (lich.TietHoc == "4-6" || lich.TietHoc == "4-5" || lich.TietHoc == "5-6" || lich.TietHoc == "1-5")
                                {
                                    fl = 1;
                                    break;
                                }
                            }
                            if (x.TietHoc == "7-9" || x.TietHoc == "7-8" || x.TietHoc == "8-9" || x.TietHoc == "7-12")
                            {
                                if (lich.TietHoc == "7-9" || lich.TietHoc == "7-8" || lich.TietHoc == "8-9" || lich.TietHoc == "7-12")
                                {
                                    fl = 1;
                                    break;
                                }
                            }
                            if (x.TietHoc == "10-12" || x.TietHoc == "10-11" || x.TietHoc == "11-12")
                            {
                                if (lich.TietHoc == "10-12" || lich.TietHoc == "10-11" || lich.TietHoc == "11-12" || lich.TietHoc == "7-12")
                                {
                                    fl = 1;
                                    break;
                                }
                            }
                        }
                       
                    }




                    if (nhomTH.LichHoc_NhomThucHanh[index].ID_LichHoc_NhomTH == -1)
                    {
                        if (new LichHocBLL().CheckLichTrungGiangVien(cbGiangVien.SelectedValue.ToString().Trim(), cbNgayHoc.SelectedItem.ToString().Trim(), cbTietHoc.SelectedItem.ToString().Trim(), int.Parse(frmLopHocPhan.instance.cbHocKy.SelectedItem.ToString()), int.Parse(frmLopHocPhan.instance.cbNamHoc.SelectedValue.ToString().Trim())))
                        {
                            fl = 1;
                        }
                    }
                    else
                    {

                        if (new LichHocBLL().CheckLichUpdateGiangVien("TH", int.Parse(nhomTH.LichHoc_NhomThucHanh[index].ID_LichHoc_NhomTH.ToString().Trim()), cbGiangVien.SelectedValue.ToString().Trim(), cbNgayHoc.SelectedItem.ToString().Trim(), cbTietHoc.SelectedItem.ToString().Trim(), int.Parse(frmLopHocPhan.instance.cbHocKy.SelectedItem.ToString()), int.Parse(frmLopHocPhan.instance.cbNamHoc.SelectedValue.ToString().Trim())))
                        {
                            fl = 1;
                        }
                    }
                    if (fl == 0)
                    {
                        nhomTH.LichHoc_NhomThucHanh[index].NgayHoc = cbNgayHoc.SelectedItem.ToString().Trim();
                        nhomTH.LichHoc_NhomThucHanh[index].TietHoc = cbTietHoc.SelectedItem.ToString().Trim();
                        nhomTH.LichHoc_NhomThucHanh[index].ID_PhongHoc = cbPhong.SelectedValue.ToString().Trim();
                    }
                    else
                    {
                        MessageBox.Show("Lịch bị trùng, không thể thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadDSLichHocNhomTH();
                }
            }
        }
        public void LoadDSLichHocNhomTH()
        {
            List<LichHocTHViewModels> lss = nhomTH.LichHoc_NhomThucHanh.Select(x => new LichHocTHViewModels
            {
                ID_LichHoc_NhomTH = x.ID_LichHoc_NhomTH,
                ID_NhomThucHanh = x.ID_NhomThucHanh,
                ID_PhongHoc = x.ID_PhongHoc,
                NgayHoc = x.NgayHoc,
                TenPhongHoc = new PhongHocBLL().GetPhongHocByID(x.ID_PhongHoc).TenPhongHoc.ToString().Trim(),
                TietHoc = x.TietHoc.Trim()
            }).ToList();
            lichHocTHViewModelsBindingSource.DataSource = null;
            lichHocTHViewModelsBindingSource.DataSource = lss;
        }
        private void btnHuyLuuLichHoc_Click(object sender, EventArgs e)
        {
            cbPhong.Enabled = false;
            cbNgayHoc.Enabled = false;
            cbTietHoc.Enabled = false;

            btnLuuLichHoc.Visible = false;
            btnHuyLuuLichHoc.Visible = false;
            btnThemLich.Visible = true;
            btnSuaLich.Visible = true;
            btnXoaLich.Visible = true;
        }
        //load dữ liệu cho combobox lịch học
        public void LoadCBLich()
        {
            #region TietHoc
            cbTietHoc.Items.Add("1-3");
            cbTietHoc.Items.Add("1-2");
            cbTietHoc.Items.Add("2-3");

            cbTietHoc.Items.Add("4-6");
            cbTietHoc.Items.Add("4-5");
            cbTietHoc.Items.Add("5-6");

            cbTietHoc.Items.Add("1-6");

            cbTietHoc.Items.Add("7-9");
            cbTietHoc.Items.Add("7-8");
            cbTietHoc.Items.Add("8-9");

            cbTietHoc.Items.Add("10-12");
            cbTietHoc.Items.Add("10-11");
            cbTietHoc.Items.Add("11-12");
            #endregion
            #region cbbngayHoc
            cbNgayHoc.Items.Add("Thứ Hai");
            cbNgayHoc.Items.Add("Thứ Ba");
            cbNgayHoc.Items.Add("Thứ Tư");
            cbNgayHoc.Items.Add("Thứ Năm");
            cbNgayHoc.Items.Add("Thứ Sáu");
            cbNgayHoc.Items.Add("Thứ Bảy");
            cbNgayHoc.Items.Add("Chủ Nhật");
            #endregion
            #region cbbPhongHoc
            cbPhong.DataSource = new PhongHocBLL().GetAllPhongHoc();
            cbPhong.DisplayMember = "TenPhongHoc";
            cbPhong.ValueMember = "ID_PhongHoc";
            #endregion
            cbTietHoc.SelectedIndex = 0;
            cbNgayHoc.SelectedIndex = 0;
        }

        #endregion

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //LoadFormThongTinLichLT();
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    cbNgayHoc.SelectedItem = dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                    cbTietHoc.SelectedItem = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                    cbPhong.SelectedValue = dataGridView3.Rows[e.RowIndex].Cells[5].Value.ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(dataGridView3.Rows.Count.ToString());
            }
        }

        private void cbMaGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbGiangVien.SelectedValue = ((eGiangVien)(cbMaGV.SelectedItem)).ID_GiangVien.Trim();
            }
            catch (Exception)
            {

            }
        }

        private void cbGiangVien_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                cbMaGV.SelectedValue = ((eGiangVien)(cbGiangVien.SelectedItem)).HoVaTen.Trim();


            }
            catch (Exception)
            {

            }
        }

        private void cbMaGV_Leave(object sender, EventArgs e)
        {
            try
            {
                foreach (eGiangVien t in cbMaGV.Items)
                {
                    if (t.ID_GiangVien.Trim().ToUpper().Contains(cbMaGV.Text.Trim().ToUpper()))
                    {
                        cbMaGV.SelectedItem = t;
                        return;
                    }
                }

                MessageBox.Show("Mã giảng viên không tồn tại trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbMaGV.SelectedItem = cbMaGV.Items[0];

            }
            catch (Exception ex)
            {

            }
        }

        private void cbGiangVien_Leave(object sender, EventArgs e)
        {
            try
            {
                foreach (eGiangVien t in cbGiangVien.Items)
                {
                    if (t.HoVaTen.Trim().ToUpper().Contains(cbGiangVien.Text.Trim().ToUpper()))
                    {
                        cbGiangVien.SelectedItem = t;
                        return;
                    }
                }
                MessageBox.Show("Tên giảng viên không tồn tại trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbGiangVien.SelectedItem = cbGiangVien.Items[0];

            }
            catch (Exception ex)
            {

            }
        }
    }
}
