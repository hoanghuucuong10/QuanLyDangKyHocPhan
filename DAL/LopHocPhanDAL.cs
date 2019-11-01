using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace DAL
{
    public class LopHocPhanDAL
    {
        DangKyHocPhanEntities db = new DangKyHocPhanEntities();

        public List<eLopHocPhan> GetAllLopHocPhan()
        {
            List<eLopHocPhan> lst = db.LopHocPhans.Select(x => new eLopHocPhan
            {
                //id_LopHocPhan = x.ID_LopHocPhan,
                //id_HocPhan = x.ID_HocPhan,
                //id_NhanVienPDT = x.ID_NhanVienPDT,
                //id_GiangVien = x.ID_GiangVien,
                //id_PhongHoc = x.ID_PhongHoc,
                //tenMonHoc = x.HocPhan.TenMonHoc,
                //namHoc = x.NamHoc,
                //hocKy = x.HocKy.Value,
                //ngayHoc = x.NgayHoc,
                //tietHoc = x.TietHoc,
                //tenGiangVien = x.GiangVien.HoVaTen,
                //tenPhongHoc = x.PhongHoc.TenPhongHoc,
                //trangThai = x.TrangThai,
                //soLuong = db.DangKyHocPhans.Where(t => t.ID_LopHocPhan == x.ID_LopHocPhan).Count(),
                //NgayBD = x.NgayBatDau,
                //NgayKT = x.NgayKetThuc,
                //ListNhomTH = db.NhomThucHanhs.Where(t => t.ID_LopHocPhan == x.ID_LopHocPhan).Select(m => new eNhomThucHanh
                //{
                //    id_LopThucHanh = m.ID_NhomThucHanh,
                //    id_LopHocPhan = m.ID_LopHocPhan,
                //    tenNhom = m.TenNhom.Value,
                //    id_GiangVien = m.ID_GiangVien,
                //    id_PhongHoc = m.ID_PhongHoc,
                //    tenPhong = m.PhongHoc.TenPhongHoc,
                //    tenGiangVien = m.GiangVien.HoVaTen,
                //    tietHoc = m.TietHoc,
                //    ngayHoc = m.NgayHoc,
                //    NgayBD = m.NgayBatDau,
                //    NgayKT = m.NgayKetThuc,
                //    soLuong = db.DangKyHocPhans.Where(l => l.ID_NhomThucHanh == m.ID_NhomThucHanh).Count()
                //}).ToList()
            }).OrderBy(s => s.ID_LopHocPhan).ToList();
            return lst;
        }
        public List<eLopHocPhan> GetAllLopHocPhanGiangVien(string idGV, int hocKy, string namHoc)
        {
            List<eLopHocPhan> lst = db.LopHocPhans.Where(s => s.ID_GiangVien == idGV && s.HocKy.Value == hocKy && s.NienKhoa.NienKhoa1 == namHoc).Select(x => new eLopHocPhan
            {
                //id_LopHocPhan = x.ID_LopHocPhan,
                //id_HocPhan = x.ID_HocPhan,
                //id_NhanVienPDT = x.ID_NhanVienPDT,
                //id_GiangVien = x.ID_GiangVien,
                //id_PhongHoc = x.ID_PhongHoc,
                //tenMonHoc = x.HocPhan.TenMonHoc,
                //namHoc = x.NamHoc,
                //hocKy = x.HocKy.Value,
                //ngayHoc = x.NgayHoc,
                //tietHoc = x.TietHoc,
                //tenGiangVien = x.GiangVien.HoVaTen,
                //tenPhongHoc = x.PhongHoc.TenPhongHoc,
                //trangThai = x.TrangThai,
                //NgayBD = x.NgayBatDau,
                //NgayKT = x.NgayKetThuc,
                //soLuong = db.DangKyHocPhans.Where(t => t.ID_LopHocPhan == x.ID_LopHocPhan).Count(),
                //ListNhomTH = db.NhomThucHanhs.Where(t => t.ID_LopHocPhan == x.ID_LopHocPhan).Select(m => new eNhomThucHanh
                //{
                //    id_LopThucHanh = m.ID_NhomThucHanh,
                //    id_LopHocPhan = m.ID_LopHocPhan,
                //    tenNhom = m.TenNhom.Value,
                //    id_GiangVien = m.ID_GiangVien,
                //    id_PhongHoc = m.ID_PhongHoc,
                //    tenPhong = m.PhongHoc.TenPhongHoc,
                //    tenGiangVien = m.GiangVien.HoVaTen,
                //    tietHoc = m.TietHoc,
                //    ngayHoc = m.NgayHoc,
                //    NgayBD = m.NgayBatDau,
                //    NgayKT = m.NgayKetThuc,
                //    soLuong = db.DangKyHocPhans.Where(l => l.ID_NhomThucHanh == m.ID_NhomThucHanh).Count()
                //}).ToList()
            }).OrderBy(s => s.ID_LopHocPhan).ToList();
            return lst;
        }
        public List<eLopHocPhan> SearchLopHocPhan(string maLopHocPhan, string maMonHoc, string hocKy, string namHoc)
        {
            List<eLopHocPhan> lst = db.LopHocPhans.Where(f => f.ID_LopHocPhan.Contains(maLopHocPhan) && f.ID_HocPhan.Contains(maMonHoc) && f.HocKy.ToString().Contains(hocKy) && f.NienKhoa.NienKhoa1.Contains(namHoc)).Select(x => new eLopHocPhan
            {
                //id_LopHocPhan = x.ID_LopHocPhan,
                //id_HocPhan = x.ID_HocPhan,
                //id_NhanVienPDT = x.ID_NhanVienPDT,
                //id_GiangVien = x.ID_GiangVien,
                //id_PhongHoc = x.ID_PhongHoc,
                //tenMonHoc = x.HocPhan.TenMonHoc,
                //namHoc = x.NamHoc,
                //hocKy = x.HocKy.Value,
                //ngayHoc = x.NgayHoc,
                //tietHoc = x.TietHoc,
                //tenGiangVien = x.GiangVien.HoVaTen,
                //tenPhongHoc = x.PhongHoc.TenPhongHoc,
                //trangThai = x.TrangThai,
                //NgayBD = x.NgayBatDau,
                //NgayKT = x.NgayKetThuc,
                //soLuong = db.DangKyHocPhans.Where(t => t.ID_LopHocPhan == x.ID_LopHocPhan).Count(),
                //ListNhomTH = db.NhomThucHanhs.Where(t => t.ID_LopHocPhan == x.ID_LopHocPhan).Select(m => new eNhomThucHanh
                //{
                //    id_LopThucHanh = m.ID_NhomThucHanh,
                //    id_LopHocPhan = m.ID_LopHocPhan,
                //    tenNhom = m.TenNhom.Value,
                //    id_GiangVien = m.ID_GiangVien,
                //    id_PhongHoc = m.ID_PhongHoc,
                //    tenPhong = m.PhongHoc.TenPhongHoc,
                //    tenGiangVien = m.GiangVien.HoVaTen,
                //    tietHoc = m.TietHoc,
                //    ngayHoc = m.NgayHoc,
                //    NgayBD = m.NgayBatDau,
                //    NgayKT = m.NgayKetThuc,
                //    soLuong = db.DangKyHocPhans.Where(l => l.ID_NhomThucHanh == m.ID_NhomThucHanh).Count()

                    
                //}).ToList()
            }).OrderBy(gs => gs.ID_LopHocPhan).ToList();
            return lst;
        }
        public int EditLopHocPhan(string id, eLopHocPhan x)
        {
            try
            {
                LopHocPhan m = db.LopHocPhans.Where(t => t.ID_LopHocPhan == id).FirstOrDefault();
                //m.ID_LopHocPhan = x.id_LopHocPhan;
                //m.ID_HocPhan = x.id_HocPhan;
                //m.ID_GiangVien = x.id_GiangVien;
                //m.HocKy = x.hocKy;
                //m.ID_NhanVienPDT = x.id_NhanVienPDT;
                //m.ID_PhongHoc = x.id_PhongHoc;
                //m.NamHoc = x.namHoc;
                //m.TietHoc = x.tietHoc;
                //m.NgayHoc = x.ngayHoc;
                //m.TrangThai = x.trangThai;
                //m.NgayBatDau = x.NgayBD;
                //m.NgayKetThuc = x.NgayKT;
                db.SaveChanges();
            }
            catch (Exception)
            {

                return 0;
            }
            return 1;
        }
        public int AddLopHocPhan(string id, eLopHocPhan x)
        {
            try
            {
                LopHocPhan m = new LopHocPhan();
                //m.ID_LopHocPhan = x.id_LopHocPhan;
                //m.ID_HocPhan = x.id_HocPhan;
                //m.ID_GiangVien = x.id_GiangVien;
                //m.HocKy = x.hocKy;
                //m.ID_NhanVienPDT = x.id_NhanVienPDT;
                //m.ID_PhongHoc = x.id_PhongHoc;
                //m.NamHoc = x.namHoc;
                //m.TietHoc = x.tietHoc;
                //m.NgayHoc = x.ngayHoc;
                //m.TrangThai = x.trangThai;
                //m.NgayBatDau = x.NgayBD;
                //m.NgayKetThuc = x.NgayKT;
                //db.LopHocPhans.Add(m);
                //db.SaveChanges();
                return 1;
            }
            catch (Exception)
            {

                return 0;
            }

        }
        public string CreateID()
        {
            string id = db.LopHocPhans.Max(x => x.ID_LopHocPhan);
            string numStr = id.Substring(2);
            int num = int.Parse(numStr) + 1;

            numStr = num.ToString();
            while (numStr.Count() != 8)
            {
                numStr = "0" + numStr;
            }
            numStr = "lh" + numStr;
            return numStr;
        }

    }
}
