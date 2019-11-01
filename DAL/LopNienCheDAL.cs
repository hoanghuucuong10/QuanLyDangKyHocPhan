using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace DAL
{
    public class LopNienCheDAL
    {
        DangKyHocPhanEntities db = new DangKyHocPhanEntities();
        public List<eLopNienChe> GetAllLopNienChe()
        {
            List<eLopNienChe> lst = db.LopNienChes.Select(x => new eLopNienChe
            {
                ID_LopNienChe = x.ID_LopNienChe,
                TenLop = x.TenLop,
                KhoaHoc = x.KhoaHoc,
                ChuyenNganh = x.ChuyenNganh,
                ID_GiangVien = x.ID_GiangVien
            }).ToList();
            return lst;
        }
        public eLopNienChe GetLopNienCheByID(string id)
        {
            eLopNienChe lst = db.LopNienChes.Where(t=>t.ID_LopNienChe==id).Select(x => new eLopNienChe
            {
                ID_LopNienChe = x.ID_LopNienChe,
                TenLop = x.TenLop,
                KhoaHoc = x.KhoaHoc,
                ChuyenNganh = x.ChuyenNganh,
                ID_GiangVien = x.ID_GiangVien
            }).FirstOrDefault();
            return lst;
        }
    }
}
