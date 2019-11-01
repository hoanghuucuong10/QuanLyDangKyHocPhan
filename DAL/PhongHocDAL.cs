using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace DAL
{
    public class PhongHocDAL
    {
        DangKyHocPhanEntities db = new DangKyHocPhanEntities();
        public List<ePhongHoc> GetAllPhongHoc()
        {
            List<ePhongHoc> lst = db.PhongHocs.Select(x => new ePhongHoc
            {
                ID_PhongHoc = x.ID_PhongHoc,
                TenPhongHoc=x.TenPhongHoc
            }).ToList();

            return lst;
        }
        public ePhongHoc GetPhongHocByID(string id)
        {
            ePhongHoc lst = db.PhongHocs.Where(m=>m.ID_PhongHoc==id).Select(x => new ePhongHoc
            {
                ID_PhongHoc = x.ID_PhongHoc,
                TenPhongHoc = x.TenPhongHoc
            }).FirstOrDefault();

            return lst;
        }
        public ePhongHoc GetPhongHocByName(string name)
        {
            ePhongHoc ph = db.PhongHocs.Where(m => m.TenPhongHoc == name).Select(x => new ePhongHoc
            {
                ID_PhongHoc = x.ID_PhongHoc,
                TenPhongHoc = x.TenPhongHoc
            }).FirstOrDefault();
            return ph;
        }
    }
}
