using BLL;
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

            // List<LopHocPhanViewModels> lstLopHP = new LopHocPhanBLL().Ge
        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void treeLopHocPhan_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string idLopHP = "";
            if (treeLopHocPhan.SelectedNode != null)
            {
                idLopHP = treeLopHocPhan.SelectedNode.Tag.ToString();
            }
            if (idLopHP.Count() > 1)
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
                    lbTenMonHoc.Text = lopHP.TenMonHoc.Trim();
                    lbSoTC.Text = new HocPhanBLL().GetHocPhanByID(lopHP.ID_HocPhan).SoTC.ToString();
                    lbHocKi.Text = "Học kỳ " + lopHP.HocKy + " (" + lopHP.NienKhoa + ")";
                    lbIDLHP.Text = lopHP.ID_LopHocPhan.Trim();

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

                    if (lst != null)
                    {
                        diemLopHocPhanViewModelsBindingSource.DataSource = lst;
                    }
                }else
                {
                    diemLopHocPhanViewModelsBindingSource.DataSource = null;
                }

            }
        }
    }
}
