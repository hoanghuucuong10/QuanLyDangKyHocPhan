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
                ID_LopHocPhan = x.ID_LopHocPhan,
                ID_HocPhan = x.ID_HocPhan,
                ID_NhanVienPDT = x.ID_NhanVienPDT,
                ID_GiangVien = x.ID_GiangVien,
                HocKy = x.HocKy.Value,
                ID_NienKhoa = x.ID_NienKhoa,
                SoTiet = x.SoTiet,
                TrangThai = x.TrangThai,
                NgayBatDau = x.NgayBatDau,
                NgayKetThuc = x.NgayKetThuc,
                SoLuong = db.DangKyHocPhans.Where(t => t.ID_LopHocPhan == x.ID_LopHocPhan).Count(),
            }).OrderBy(s => s.ID_LopHocPhan).ToList();
            return lst;
        }
        public List<eLopHocPhan> GetAllLopHocPhanGiangVien(string idGV, int hocKy, string namHoc)
        {
            List<eLopHocPhan> lst = db.LopHocPhans.Where(s => s.ID_GiangVien == idGV && s.HocKy.Value == hocKy && s.NienKhoa.NienKhoa1 == namHoc).Select(x => new eLopHocPhan
            {
                ID_LopHocPhan = x.ID_LopHocPhan,
                ID_HocPhan = x.ID_HocPhan,
                ID_NhanVienPDT = x.ID_NhanVienPDT,
                ID_GiangVien = x.ID_GiangVien,
                HocKy = x.HocKy.Value,
                ID_NienKhoa = x.ID_NienKhoa,
                SoTiet = x.SoTiet,
                TrangThai = x.TrangThai,
                NgayBatDau = x.NgayBatDau,
                NgayKetThuc = x.NgayKetThuc,
                SoLuong = db.DangKyHocPhans.Where(t => t.ID_LopHocPhan == x.ID_LopHocPhan).Count(),
            }).OrderBy(s => s.ID_LopHocPhan).ToList();
            return lst;
        }
        public List<eLopHocPhan> SearchLopHocPhan(string maLopHocPhan, string tenMonHoc, string hocKy, string namHoc)
        {
            List<eLopHocPhan> lst = db.LopHocPhans.Where(f => f.ID_LopHocPhan.Contains(maLopHocPhan) && f.HocPhan.TenMonHoc.Contains(tenMonHoc) && f.HocKy.ToString().Contains(hocKy) && f.NienKhoa.NienKhoa1.Contains(namHoc)).Select(x => new eLopHocPhan
            {
                ID_LopHocPhan = x.ID_LopHocPhan,
                ID_HocPhan = x.ID_HocPhan,
                ID_NhanVienPDT = x.ID_NhanVienPDT,
                ID_GiangVien = x.ID_GiangVien,
                HocKy = x.HocKy.Value,
                ID_NienKhoa=x.ID_NienKhoa,
                SoTiet=x.SoTiet,
                TrangThai = x.TrangThai,
                NgayBatDau = x.NgayBatDau,
                NgayKetThuc = x.NgayKetThuc,
                SoLuong = db.DangKyHocPhans.Where(t => t.ID_LopHocPhan == x.ID_LopHocPhan).Count(),

            }).OrderBy(gs => gs.ID_LopHocPhan).ToList();
            return lst;
        }
        public List<eLopHocPhan> SearchLopHocPhanDK(string maLopHocPhan, string tenMonHoc, string hocKy, string namHoc)
        {
            List<eLopHocPhan> lst = db.LopHocPhans.Where(f => f.ID_LopHocPhan.Contains(maLopHocPhan) && f.HocPhan.TenMonHoc.Contains(tenMonHoc) && f.HocKy.ToString().Contains(hocKy) && f.NienKhoa.NienKhoa1.Contains(namHoc) && f.TrangThai == "Chờ Sinh Viên Đăng Ký").Select(x => new eLopHocPhan
            {
                ID_LopHocPhan = x.ID_LopHocPhan,
                ID_HocPhan = x.ID_HocPhan,
                ID_NhanVienPDT = x.ID_NhanVienPDT,
                ID_GiangVien = x.ID_GiangVien,
                HocKy = x.HocKy.Value,
                ID_NienKhoa = x.ID_NienKhoa,
                SoTiet = x.SoTiet,
                TrangThai = x.TrangThai,
                NgayBatDau = x.NgayBatDau,
                NgayKetThuc = x.NgayKetThuc,
                SoLuong = db.DangKyHocPhans.Where(t => t.ID_LopHocPhan == x.ID_LopHocPhan).Count(),

            }).OrderBy(gs => gs.ID_LopHocPhan).ToList();
            return lst;
        }
        public int EditLopHocPhan( eLopHocPhan x)
        {
            try
            {
                LopHocPhan m = db.LopHocPhans.Where(t => t.ID_LopHocPhan == x.ID_LopHocPhan).FirstOrDefault();
                if(m==null)
                {
                    return 0;
                }
                m.ID_LopHocPhan = x.ID_LopHocPhan;
                m.ID_HocPhan = x.ID_HocPhan;
                m.ID_GiangVien = x.ID_GiangVien;
                m.HocKy = x.HocKy;
                m.ID_NhanVienPDT = x.ID_NhanVienPDT;
                m.ID_NienKhoa = x.ID_NienKhoa;
                m.TrangThai = x.TrangThai;
                m.NgayBatDau = x.NgayBatDau;
                m.NgayKetThuc = x.NgayKetThuc;
                m.SoTiet = x.SoTiet;
                m.SoLuong = new DangKyHocPhanDAL().SoLuong(x.ID_LopHocPhan);
                db.SaveChanges();
                return 1;
            }
            catch (Exception)
            {

                return 0;
            }
            return 1;
        }
        public int AddLopHocPhan( eLopHocPhan x)
        {
            try
            {
                LopHocPhan m = new LopHocPhan();
                m.ID_LopHocPhan = x.ID_LopHocPhan;
                m.ID_HocPhan = x.ID_HocPhan;
                m.ID_GiangVien = x.ID_GiangVien;
                m.HocKy = x.HocKy;
                m.ID_NhanVienPDT = x.ID_NhanVienPDT;
                m.TrangThai = x.TrangThai;
                m.NgayBatDau = x.NgayBatDau;
                m.NgayKetThuc = x.NgayKetThuc;
                m.SoLuong = db.DangKyHocPhans.Where(t => t.ID_LopHocPhan == x.ID_LopHocPhan).Count();
                m.SoTiet = x.SoTiet;
                m.ID_NienKhoa = x.ID_NienKhoa;
                db.LopHocPhans.Add(m);
                db.SaveChanges();
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

        public List<eLopHocPhan> GetAllLopHocPhanSinhVien(string idSV, int hocKy, string namHoc)
        {
            List<eLopHocPhan> lst = db.LopHocPhans.Where(x => x.HocKy == hocKy && x.NienKhoa.NienKhoa1 == namHoc && x.DangKyHocPhans.Any(t => t.ID_SinhVien == idSV)).Select(m=>new eLopHocPhan{
                ID_LopHocPhan = m.ID_LopHocPhan,
                ID_HocPhan = m.ID_HocPhan,
                ID_NhanVienPDT = m.ID_NhanVienPDT,
                ID_GiangVien = m.ID_GiangVien,
                HocKy = m.HocKy.Value,
                ID_NienKhoa = m.ID_NienKhoa,
                SoTiet = m.SoTiet,
                TrangThai = m.TrangThai,
                NgayBatDau = m.NgayBatDau,
                NgayKetThuc = m.NgayKetThuc,
                SoLuong = db.DangKyHocPhans.Where(s => s.ID_LopHocPhan == m.ID_LopHocPhan).Count(),
            }).ToList();
            return lst;
        }
        public eLopHocPhan GetLopHocPhanbyID(string id)
        {
           eLopHocPhan lst = db.LopHocPhans.Where(x => x.ID_LopHocPhan==id).Select(m => new eLopHocPhan
            {
                ID_LopHocPhan = m.ID_LopHocPhan,
                ID_HocPhan = m.ID_HocPhan,
                ID_NhanVienPDT = m.ID_NhanVienPDT,
                ID_GiangVien = m.ID_GiangVien,
                HocKy = m.HocKy.Value,
                ID_NienKhoa = m.ID_NienKhoa,
                SoTiet = m.SoTiet,
                TrangThai = m.TrangThai,
                NgayBatDau = m.NgayBatDau,
                NgayKetThuc = m.NgayKetThuc,
                SoLuong = db.DangKyHocPhans.Where(s => s.ID_LopHocPhan == m.ID_LopHocPhan).Count(),
            }).FirstOrDefault();
            return lst;
        }
        public eLopHocPhan GetLopHocPhanByIDNhomTH(string id)
        {
            eLopHocPhan lst = db.LopHocPhans.Where(x => x.NhomThucHanhs.Any(s=>s.ID_NhomThucHanh==id)).Select(m => new eLopHocPhan
            {
                ID_LopHocPhan = m.ID_LopHocPhan,
                ID_HocPhan = m.ID_HocPhan,
                ID_NhanVienPDT = m.ID_NhanVienPDT,
                ID_GiangVien = m.ID_GiangVien,
                HocKy = m.HocKy.Value,
                ID_NienKhoa = m.ID_NienKhoa,
                SoTiet = m.SoTiet,
                TrangThai = m.TrangThai,
                NgayBatDau = m.NgayBatDau,
                NgayKetThuc = m.NgayKetThuc,
                SoLuong = db.DangKyHocPhans.Where(s => s.ID_LopHocPhan == m.ID_LopHocPhan).Count(),
            }).FirstOrDefault();
            return lst;
        }

        public string GetTrangThai(string id)
        {
            LopHocPhan x = db.LopHocPhans.Where(s => s.ID_LopHocPhan == id).FirstOrDefault();
            if(x!=null)
            {
                return x.TrangThai;
            }
            return "";
        }
        public bool HuyLopHP(string idLHP)
        {
           
            try
            {
                List<Diem> lstDiem = db.Diems.Where(x => x.ID_LopHocPhan == idLHP).ToList();
                List<DangKyHocPhan> lstDK = db.DangKyHocPhans.Where(x => x.ID_LopHocPhan == idLHP).ToList();

                db.Diems.RemoveRange(lstDiem);
                db.DangKyHocPhans.RemoveRange(lstDK);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool XoaLopHocPhan(string idLHP)
        {
            try
            {
                List<Diem> lstDiem = db.Diems.Where(x => x.ID_LopHocPhan == idLHP).ToList();
                List<DangKyHocPhan> lstDK = db.DangKyHocPhans.Where(x => x.ID_LopHocPhan == idLHP).ToList();
                List<LichHoc_LopHocPhan> lstLichLT = db.LichHoc_LopHocPhan.Where(x => x.ID_LopHocPhan == idLHP).ToList();
                List<NhomThucHanh> lstNhomTH = db.NhomThucHanhs.Where(x => x.ID_LopHocPhan == idLHP).ToList();
                foreach(NhomThucHanh t in lstNhomTH)
                {
                    List<LichHoc_NhomThucHanh> lstLichTH = db.LichHoc_NhomThucHanh.Where(x => x.ID_NhomThucHanh == t.ID_NhomThucHanh).ToList();
                    db.LichHoc_NhomThucHanh.RemoveRange(lstLichTH);
                }

                db.Diems.RemoveRange(lstDiem);
                db.DangKyHocPhans.RemoveRange(lstDK);
                db.LichHoc_LopHocPhan.RemoveRange(lstLichLT);
                db.NhomThucHanhs.RemoveRange(lstNhomTH);

                LopHocPhan s = db.LopHocPhans.Where(c => c.ID_LopHocPhan == idLHP).FirstOrDefault();
                db.LopHocPhans.Remove(s);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
