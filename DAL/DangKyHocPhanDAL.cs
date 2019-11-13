using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace DAL
{
    public class DangKyHocPhanDAL
    {
        DangKyHocPhanEntities db = new DangKyHocPhanEntities();
        public eDangKyHocPhan GetDangKyHocPhanByIDLopHocPhan(string id)
        {
            DangKyHocPhan xa = db.DangKyHocPhans.Where(x => x.ID_LopHocPhan == id).FirstOrDefault();
            eDangKyHocPhan t = new eDangKyHocPhan();
            if (xa!=null)
            {
                
                t.ID_LopHocPhan = xa.ID_LopHocPhan;
                t.ID_SinhVien = xa.ID_SinhVien;
                if(xa.ID_NhomThucHanh==null)
                {
                    t.ID_NhomThucHanh = "";
                }
                else
                {
                    t.ID_NhomThucHanh = xa.ID_NhomThucHanh;
                }
            }
            return t;
        }
        public int SoLuong(string idLopHocPhan)
        {
            return db.DangKyHocPhans.Where(x => x.ID_LopHocPhan == idLopHocPhan).Count();
        }

        public bool DangKy(string idSV,string idLopHP,string idNhomTH)
        {
            try
            {
                DangKyHocPhan x = new DangKyHocPhan();
                x.ID_SinhVien = idSV;
                x.ID_LopHocPhan = idLopHP;
                if (idNhomTH != "")
                {
                    x.ID_NhomThucHanh = idNhomTH;
                }
                db.DangKyHocPhans.Add(x);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool HuyDangKy(string idSV, string idLopHP)
        {
            try
            {
                DangKyHocPhan x = db.DangKyHocPhans.Where(t => t.ID_SinhVien == idSV && t.ID_LopHocPhan == idLopHP).FirstOrDefault();
                if(x==null)
                {
                    return false;
                }
                db.DangKyHocPhans.Remove(x);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public int SoLuongNhomTH(string idNhomTH)
        {
            return db.DangKyHocPhans.Where(x => x.ID_NhomThucHanh == idNhomTH).Count();
        }
    }
}
