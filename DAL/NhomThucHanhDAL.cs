using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace DAL
{
    public class NhomThucHanhDAL
    {
        DangKyHocPhanEntities db = new DangKyHocPhanEntities();

        public List<eNhomThucHanh> GetNhomByIDLopHocPhan(string id)
        {
            List<eNhomThucHanh> lst = db.NhomThucHanhs.Where(x => x.ID_LopHocPhan == id).Select(m => new eNhomThucHanh
            {
                ID_NhomThucHanh = m.ID_NhomThucHanh,
                ID_LopHocPhan = m.ID_LopHocPhan,
                TenNhom = m.TenNhom,
                ID_GiangVien = m.ID_GiangVien,
                NgayBatDau = m.NgayBatDau,
                SoTiet = m.SoTiet,
                NgayKetThuc = m.NgayKetThuc,
                SoLuong = db.DangKyHocPhans.Where(x => x.ID_NhomThucHanh == m.ID_NhomThucHanh).Count()
            }).ToList();
            return lst;
        }
        public List<eNhomThucHanh> GetNhomByIDGiangVien(string id, int hocKy, string namHoc)
        {
            List<eNhomThucHanh> lst = db.NhomThucHanhs.Where(x => x.ID_GiangVien == id && x.LopHocPhan.HocKy == hocKy && x.LopHocPhan.NienKhoa.NienKhoa1 == namHoc).Select(m => new eNhomThucHanh
            {
                ID_NhomThucHanh = m.ID_NhomThucHanh,
                ID_LopHocPhan = m.ID_LopHocPhan,
                TenNhom = m.TenNhom,
                ID_GiangVien = m.ID_GiangVien,
                NgayBatDau = m.NgayBatDau,
                NgayKetThuc = m.NgayKetThuc,
                SoTiet = m.SoTiet,
                SoLuong = db.DangKyHocPhans.Where(x => x.ID_NhomThucHanh == m.ID_NhomThucHanh).Count()
            }).ToList();
            return lst;
        }
        public eNhomThucHanh GetNhomByID(string id)
        {
            eNhomThucHanh lst = db.NhomThucHanhs.Where(x => x.ID_NhomThucHanh == id).Select(m => new eNhomThucHanh
            {
                ID_NhomThucHanh = m.ID_NhomThucHanh,
                ID_LopHocPhan = m.ID_LopHocPhan,
                TenNhom = m.TenNhom,
                ID_GiangVien = m.ID_GiangVien,
                NgayBatDau = m.NgayBatDau,
                NgayKetThuc = m.NgayKetThuc,
                SoTiet = m.SoTiet,
                SoLuong = db.DangKyHocPhans.Where(x => x.ID_NhomThucHanh == m.ID_NhomThucHanh).Count()
            }).FirstOrDefault();
            return lst;
        }
        public string GetTenNhomByID(string id)
        {
            if (id == "")
            {
                return "";
            }
            eNhomThucHanh lst = db.NhomThucHanhs.Where(x => x.ID_NhomThucHanh == id).Select(m => new eNhomThucHanh
            {
                ID_NhomThucHanh = m.ID_NhomThucHanh,
                ID_LopHocPhan = m.ID_LopHocPhan,
                TenNhom = m.TenNhom,
                ID_GiangVien = m.ID_GiangVien,
                NgayBatDau = m.NgayBatDau,
                NgayKetThuc = m.NgayKetThuc,
                SoTiet = m.SoTiet,
                SoLuong = db.DangKyHocPhans.Where(x => x.ID_NhomThucHanh == m.ID_NhomThucHanh).Count()
            }).FirstOrDefault();
            if (lst.TenNhom == null)
                return "";
            else
                return lst.TenNhom;
        }
        public int EditNhomThucHanh(eNhomThucHanh a)
        {
            try
            {
                NhomThucHanh n = db.NhomThucHanhs.Where(t => t.ID_NhomThucHanh == a.ID_NhomThucHanh).FirstOrDefault();
                if (n != null) // có thì chỉnh thông tin
                {
                    n.ID_NhomThucHanh = a.ID_NhomThucHanh;
                    n.ID_LopHocPhan = a.ID_LopHocPhan;
                    n.ID_GiangVien = a.ID_GiangVien;
                    n.TenNhom = a.TenNhom;
                    n.SoTiet = a.SoTiet;
                    n.NgayBatDau = a.NgayBatDau;
                    n.NgayKetThuc = a.NgayKetThuc;
                    n.SoLuong = db.DangKyHocPhans.Where(x => x.ID_NhomThucHanh == a.ID_NhomThucHanh).Count();

                    db.SaveChanges();
                    return 1;
                }
                else // chưa có thì thêm mới
                {
                    n = new NhomThucHanh();
                    n.ID_NhomThucHanh = a.ID_NhomThucHanh;
                    n.ID_LopHocPhan = a.ID_LopHocPhan;
                    n.ID_GiangVien = a.ID_GiangVien;
                    n.TenNhom = a.TenNhom;
                    n.SoTiet = a.SoTiet;
                    n.NgayBatDau = a.NgayBatDau;
                    n.NgayKetThuc = a.NgayKetThuc;
                    n.SoLuong = db.DangKyHocPhans.Where(x => x.ID_NhomThucHanh == a.ID_NhomThucHanh).Count();
                    db.NhomThucHanhs.Add(n);

                    db.SaveChanges();
                    return 2;
                }

            }
            catch (Exception)
            {

                return 0;
            }
           
        }
        public int AddNewNhomThucHanh(eNhomThucHanh a)
        {
            try
            {
                NhomThucHanh n = new NhomThucHanh();
                n.ID_NhomThucHanh = a.ID_NhomThucHanh;
                n.ID_LopHocPhan = a.ID_LopHocPhan;
                n.ID_GiangVien = a.ID_GiangVien;
                n.TenNhom = a.TenNhom;
                n.SoTiet = a.SoTiet;
                n.NgayBatDau = a.NgayBatDau;
                n.NgayKetThuc = a.NgayKetThuc;
                n.SoLuong = 0;
                db.NhomThucHanhs.Add(n);
                db.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int DelNhomTH(string id)
        {
            if (db.DangKyHocPhans.Where(x => x.ID_NhomThucHanh == id).FirstOrDefault() != null)
                return 0;
            else
            {
                NhomThucHanh z = db.NhomThucHanhs.Where(x => x.ID_NhomThucHanh == id).FirstOrDefault();
                if (z != null)
                {
                    foreach (LichHoc_NhomThucHanh t in db.LichHoc_NhomThucHanh.Where(x => x.ID_NhomThucHanh == id).ToList())
                    {
                        db.LichHoc_NhomThucHanh.Remove(t);
                    }
                    db.NhomThucHanhs.Remove(z);
                    db.SaveChanges();
                    return 1;
                }
                return 2;

            }
        }
        public string CreateID()
        {
            string id = db.NhomThucHanhs.Max(x => x.ID_NhomThucHanh);
            string numStr = id.Substring(2);
            int num = int.Parse(numStr) + 1;

            numStr = num.ToString();
            while (numStr.Count() != 8)
            {
                numStr = "0" + numStr;
            }
            numStr = "th" + numStr;
            return numStr;
        }
    }
}
