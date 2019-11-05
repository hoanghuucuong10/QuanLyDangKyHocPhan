using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace DAL
{
    public class NienKhoaDAL
    {
        DangKyHocPhanEntities db = new DangKyHocPhanEntities();
        public eNienKhoa GetNienKhoaByID(int id)
        {
            return db.NienKhoas.Where(x => x.ID_NienKhoa == id).Select(t => new eNienKhoa
            {
                ID_NienKhoa = t.ID_NienKhoa,
                NienKhoa1 = t.NienKhoa1
            }).FirstOrDefault();
        }
        public bool CheckNienKhoa(string nienKhoa)
        {
            if (db.NienKhoas.Where(x => x.NienKhoa1.Trim() == nienKhoa.Trim()).FirstOrDefault() != null)
            {
                return true;
            }
            return false;
        }
        public bool AddNienKhoa(string nienKhoa)
        {
            try
            {
                NienKhoa x = new NienKhoa();
                x.NienKhoa1 = nienKhoa;
                db.NienKhoas.Add(x);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<eNienKhoa> GetAllNienKhoa()
        {
            List<eNienKhoa> lst = db.NienKhoas.Select(x => new eNienKhoa
            {
                ID_NienKhoa = x.ID_NienKhoa,
                NienKhoa1 = x.NienKhoa1.Trim()
            }).ToList();
            return lst;
        }
    }
}
