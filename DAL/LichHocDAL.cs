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
                ID_NhomThucHanh=t.ID_NhomThucHanh,
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
    }
}
