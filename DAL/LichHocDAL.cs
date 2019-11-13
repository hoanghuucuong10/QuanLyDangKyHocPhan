using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LichHocDAL
    {
        DangKyHocPhanEntities db = new DangKyHocPhanEntities();

        public List<eLichHoc_LopHocPhan> GetLichHocLyThuyet_GiangVien(string id_GV, int hocKy, int idNienKhoa)
        {
            List<eLichHoc_LopHocPhan> lst = db.LichHoc_LopHocPhan.Where(x => x.LopHocPhan.ID_GiangVien == id_GV && x.LopHocPhan.HocKy == hocKy && x.LopHocPhan.ID_NienKhoa == idNienKhoa).Select(t => new eLichHoc_LopHocPhan
            {
                ID_LichHoc_LopHP = t.ID_LichHoc_LopHP,
                ID_LopHocPhan = t.ID_LopHocPhan,
                ID_PhongHoc = t.PhongHoc.ID_PhongHoc,
                NgayHoc = t.NgayHoc,
                TietHoc = t.TietHoc

            }).ToList();
            return lst;
        }
        public List<eLichHoc_NhomThucHanh> GetLichHocThucHanh_GiangVien(string id_GV, int hocKy, int idNienKhoa)
        {
            List<eLichHoc_NhomThucHanh> lst = db.LichHoc_NhomThucHanh.Where(x => x.NhomThucHanh.ID_GiangVien == id_GV && x.NhomThucHanh.LopHocPhan.HocKy == hocKy && x.NhomThucHanh.LopHocPhan.ID_NienKhoa == idNienKhoa).Select(t => new eLichHoc_NhomThucHanh
            {
                ID_LichHoc_NhomTH = t.ID_LichHoc_NhomTH,
                ID_NhomThucHanh = t.ID_NhomThucHanh,
                ID_PhongHoc = t.PhongHoc.ID_PhongHoc,
                NgayHoc = t.NgayHoc,
                TietHoc = t.TietHoc

            }).ToList();
            return lst;
        }

        public List<eLichHoc_LopHocPhan> GetLichHocLyThuyet_SinhVien(string id_SV, int hocKy, int idNienKhoa)
        {
            List<eLichHoc_LopHocPhan> lst = db.LichHoc_LopHocPhan.Where(x => x.LopHocPhan.DangKyHocPhans.Any(s => s.ID_SinhVien == id_SV) && x.LopHocPhan.HocKy == hocKy && x.LopHocPhan.ID_NienKhoa == idNienKhoa).Select(t => new eLichHoc_LopHocPhan
            {
                ID_LichHoc_LopHP = t.ID_LichHoc_LopHP,
                ID_LopHocPhan = t.ID_LopHocPhan,
                ID_PhongHoc = t.PhongHoc.ID_PhongHoc,
                NgayHoc = t.NgayHoc,
                TietHoc = t.TietHoc

            }).ToList();
            return lst;
        }
        public List<eLichHoc_NhomThucHanh> GetLichHocThucHanh_SinhVien(string id_SV, int hocKy, int idNienKhoa)
        {
            List<eLichHoc_NhomThucHanh> lst = db.LichHoc_NhomThucHanh.Where(x => x.NhomThucHanh.LopHocPhan.DangKyHocPhans.Any(s => s.ID_SinhVien == id_SV && s.ID_NhomThucHanh==x.ID_NhomThucHanh) && x.NhomThucHanh.LopHocPhan.HocKy == hocKy && x.NhomThucHanh.LopHocPhan.ID_NienKhoa == idNienKhoa).Select(t => new eLichHoc_NhomThucHanh
            {
                ID_LichHoc_NhomTH = t.ID_LichHoc_NhomTH,
                ID_NhomThucHanh = t.ID_NhomThucHanh,
                ID_PhongHoc = t.PhongHoc.ID_PhongHoc,
                NgayHoc = t.NgayHoc,
                TietHoc = t.TietHoc

            }).ToList();
            return lst;
        }


        public List<eLichHoc_LopHocPhan> GetLichHoc_LopHocPhan(string id_LopHP)
        {
            List<eLichHoc_LopHocPhan> lst = db.LichHoc_LopHocPhan.Where(x => x.ID_LopHocPhan == id_LopHP).Select(t => new eLichHoc_LopHocPhan
            {
                ID_LichHoc_LopHP = t.ID_LichHoc_LopHP,
                ID_LopHocPhan = t.ID_LopHocPhan,
                ID_PhongHoc = t.PhongHoc.ID_PhongHoc,
                NgayHoc = t.NgayHoc,
                TietHoc = t.TietHoc

            }).ToList();
            return lst;
        }
        public List<eLichHoc_NhomThucHanh> GetLichHoc_NhomThucHanh(string id_NhomTH)
        {
            List<eLichHoc_NhomThucHanh> lst = db.LichHoc_NhomThucHanh.Where(x => x.ID_NhomThucHanh == id_NhomTH).Select(t => new eLichHoc_NhomThucHanh
            {
                ID_LichHoc_NhomTH = t.ID_LichHoc_NhomTH,
                ID_NhomThucHanh = t.ID_NhomThucHanh,
                ID_PhongHoc = t.PhongHoc.ID_PhongHoc,
                NgayHoc = t.NgayHoc,
                TietHoc = t.TietHoc
            }).ToList();
            return lst;
        }


        public int AddLichTH(eLichHoc_NhomThucHanh x)
        {
            try
            {
                LichHoc_NhomThucHanh m = new LichHoc_NhomThucHanh();
                m.ID_LichHoc_NhomTH = x.ID_LichHoc_NhomTH;
                m.ID_NhomThucHanh = x.ID_NhomThucHanh;
                m.ID_PhongHoc = x.ID_PhongHoc;
                m.NgayHoc = x.NgayHoc;
                m.TietHoc = x.TietHoc;
                m.ID_PhongHoc = x.ID_PhongHoc;

                db.LichHoc_NhomThucHanh.Add(m);
                db.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public int AddLichLT(eLichHoc_LopHocPhan x)
        {
            try
            {
                LichHoc_LopHocPhan m = new LichHoc_LopHocPhan();
                m.ID_LichHoc_LopHP = x.ID_LichHoc_LopHP;
                m.ID_LopHocPhan = x.ID_LopHocPhan;
                m.ID_PhongHoc = x.ID_PhongHoc;
                m.NgayHoc = x.NgayHoc;
                m.TietHoc = x.TietHoc;
                m.ID_PhongHoc = x.ID_PhongHoc;

                db.LichHoc_LopHocPhan.Add(m);
                db.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int EditLichLT(eLichHoc_LopHocPhan x)
        {
            try
            {

                LichHoc_LopHocPhan m = db.LichHoc_LopHocPhan.Where(l => l.ID_LichHoc_LopHP == x.ID_LichHoc_LopHP).FirstOrDefault();
                if (m != null) //chỉnh sửa
                {
                    m.ID_LichHoc_LopHP = x.ID_LichHoc_LopHP;
                    m.ID_LopHocPhan = x.ID_LopHocPhan;
                    m.ID_PhongHoc = x.ID_PhongHoc;
                    m.NgayHoc = x.NgayHoc;
                    m.TietHoc = x.TietHoc;
                    m.ID_PhongHoc = x.ID_PhongHoc;
                    db.SaveChanges();
                    return 1;
                }
                else //thêm mới
                {
                    m = new LichHoc_LopHocPhan();
                    m.ID_LichHoc_LopHP = x.ID_LichHoc_LopHP;
                    m.ID_LopHocPhan = x.ID_LopHocPhan;
                    m.ID_PhongHoc = x.ID_PhongHoc;
                    m.NgayHoc = x.NgayHoc;
                    m.TietHoc = x.TietHoc;
                    m.ID_PhongHoc = x.ID_PhongHoc;
                    db.LichHoc_LopHocPhan.Add(m);
                    db.SaveChanges();
                    return 2;
                }

            }
            catch (Exception)
            {
                return 0;
            }
        }
        public int EditLichTH(eLichHoc_NhomThucHanh x)
        {
            try
            {

                LichHoc_NhomThucHanh m = db.LichHoc_NhomThucHanh.Where(l => l.ID_LichHoc_NhomTH == x.ID_LichHoc_NhomTH).FirstOrDefault();
                if (m != null)
                {
                    m.ID_LichHoc_NhomTH = x.ID_LichHoc_NhomTH;
                    m.ID_NhomThucHanh = x.ID_NhomThucHanh;
                    m.ID_PhongHoc = x.ID_PhongHoc;
                    m.NgayHoc = x.NgayHoc;
                    m.TietHoc = x.TietHoc;
                    m.ID_PhongHoc = x.ID_PhongHoc;


                    //db.Entry(m).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return 1;
                }
                else
                {
                    m = new LichHoc_NhomThucHanh();
                    //m.ID_LichHoc_NhomTH = x.ID_LichHoc_NhomTH;
                    m.ID_NhomThucHanh = x.ID_NhomThucHanh;
                    m.ID_PhongHoc = x.ID_PhongHoc;
                    m.NgayHoc = x.NgayHoc;
                    m.TietHoc = x.TietHoc;
                    m.ID_PhongHoc = x.ID_PhongHoc;
                    db.LichHoc_NhomThucHanh.Add(m);
                    db.SaveChanges();
                    return 2;
                }

            }
            catch (Exception ex)
            {
                string a = ex.ToString();
                return 0;
            }
        }


        public bool CheckLichTrung(string idSV, string idLopHP, string idNhom, string hocKy, int id_NienKhoa)
        {
            List<LichHoc_LopHocPhan> lstLopHP = db.LichHoc_LopHocPhan.Where(x => x.ID_LopHocPhan == idLopHP).ToList();
            List<LichHoc_NhomThucHanh> lstNhomTH = db.LichHoc_NhomThucHanh.Where(x => x.ID_NhomThucHanh == idNhom).ToList();

            //danh sách lịch lớp học phần của sv trong kỳ
            List<LichHoc_LopHocPhan> lstLopHPSV = db.LichHoc_LopHocPhan.Where(x => x.LopHocPhan.HocKy.ToString().Trim() == hocKy.Trim() && x.LopHocPhan.ID_NienKhoa == id_NienKhoa && x.LopHocPhan.DangKyHocPhans.Any(m => m.ID_SinhVien == idSV)).ToList();
            //danh sach lich nhom thuc hanh cua sv trong ky
            List<LichHoc_NhomThucHanh> lstNhomTHSV = db.LichHoc_NhomThucHanh.Where(x => x.NhomThucHanh.LopHocPhan.HocKy.ToString().Trim() == hocKy.Trim() && x.NhomThucHanh.LopHocPhan.ID_NienKhoa == id_NienKhoa && x.NhomThucHanh.LopHocPhan.DangKyHocPhans.Any(m => m.ID_SinhVien == idSV)).ToList();

            int a = 0;
            foreach (LichHoc_LopHocPhan x in lstLopHP)
            {
                foreach (LichHoc_LopHocPhan y in lstLopHPSV)
                {
                    if (x.ID_PhongHoc == y.ID_PhongHoc && x.NgayHoc == y.NgayHoc && x.TietHoc == y.TietHoc)
                    {
                        a = 1;
                        break;
                    }
                }
            }
            foreach (LichHoc_NhomThucHanh x in lstNhomTH)
            {
                foreach (LichHoc_NhomThucHanh y in lstNhomTHSV)
                {
                    if (x.ID_PhongHoc == y.ID_PhongHoc && x.NgayHoc == y.NgayHoc && x.TietHoc == y.TietHoc)
                    {
                        a = 1;
                        break;
                    }
                }
            }
            if (a == 0)
                return false;
            else
                return true;//trùng lịch
        }

        public int CreateIDThucHanh()
        {
            return db.LichHoc_NhomThucHanh.Max(x => x.ID_LichHoc_NhomTH) + 1;
        }
        public int CreateIDLyThuyet()
        {
            return db.LichHoc_NhomThucHanh.Max(x => x.ID_LichHoc_NhomTH) + 1;
        }
    }
}
