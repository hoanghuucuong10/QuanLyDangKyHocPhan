using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace DAL
{
    public class DiemDAL
    {
        DangKyHocPhanEntities db = new DangKyHocPhanEntities();

        public bool AddDiem(string idSV, string idLopHP)
        {
            try
            {
                Diem x = new Diem();
                x.ID_LopHocPhan = idLopHP;
                x.ID_SinhVien = idSV;
                db.Diems.Add(x);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DelDiem(string idSV, string idLopHP)
        {
            try
            {
                Diem x = db.Diems.Where(t => t.ID_LopHocPhan == idLopHP && t.ID_SinhVien == idSV).FirstOrDefault();
                if(x!=null)
                {
                    db.Diems.Remove(x);
                    db.SaveChanges();
                    return true;
                }             
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<eDiem> GetDiemSV(string idSV)
        {
            List<eDiem> lst = db.Diems.Where(x => x.ID_SinhVien == idSV).OrderBy(t => t.LopHocPhan.NienKhoa.NienKhoa1).ThenBy(t => t.LopHocPhan.HocKy).Select(t => new eDiem
            {
                ID_SinhVien = t.ID_SinhVien,
                ID_LopHocPhan = t.ID_LopHocPhan,
                TK1 = t.TK1.Value,
                TK2 = t.TK2.Value,
                TK3 = t.TK3.Value,
                GK = t.GK.Value,
                CK = t.CK.Value,
            }).ToList();
            return lst;
        }
        public bool EditDiemSV(eDiem d)
        {
            Diem s = db.Diems.Where(x => x.ID_LopHocPhan == d.ID_LopHocPhan && x.ID_SinhVien == d.ID_SinhVien).FirstOrDefault();
            if(s!=null)
            {
                s.TK1 = d.TK1;
                s.TK2 = d.TK2;
                s.TK3 = d.TK3;
                s.CK = d.CK;
                s.GK = d.GK;
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool EditDiemLopHP(eDiem d)
        {
            Diem s = db.Diems.Where(x => x.ID_LopHocPhan == d.ID_LopHocPhan && x.ID_SinhVien == d.ID_SinhVien).FirstOrDefault();
            if (s != null)
            {
                s.TK1 = d.TK1;
                s.TK2 = d.TK2;
                s.TK3 = d.TK3;
                s.CK = d.CK;
                s.GK = d.GK;
                db.SaveChanges();
                return true;
            }

            return false;
        }

        public List<eDiem> GetDiemLopHocPhan(string id_LopHP)
        {
            List<eDiem> lst = db.Diems.Where(x => x.ID_LopHocPhan == id_LopHP).Select(t => new eDiem
            {
                ID_SinhVien = t.ID_SinhVien,
                ID_LopHocPhan = t.ID_LopHocPhan,
                TK1 = t.TK1.Value,
                TK2 = t.TK2.Value,
                TK3 = t.TK3.Value,
                GK = t.GK.Value,
                CK = t.CK.Value,
            }).ToList();
            return lst;
        }
    }
}
