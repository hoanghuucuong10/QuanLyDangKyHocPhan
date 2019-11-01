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


        public List<eDiem> GetDiemSV(string idSV)
        {
            List<eDiem> lst = db.Diems.Where(x => x.ID_SinhVien == idSV).Select(t => new eDiem
            {
                //ID_SinhVien = t.ID_SinhVien,
                //SinhVien = t.SinhVien,
                //tenLopNC = t.SinhVien.LopNienChe.TenLop,
                //id_LopHP = t.ID_LopHocPhan,
                //tenHP = t.LopHocPhan.HocPhan.TenMonHoc,
                //tenGiangVien = t.LopHocPhan.GiangVien.HoVaTen,
                //hocKy = t.LopHocPhan.HocKy.Value,
                //namHoc = t.LopHocPhan.NamHoc,
                //tk1 = t.TK1.Value,
                //tk2 = t.TK2.Value,
                //tk3 = t.TK3.Value,
                //gk = t.GK.Value,
                //ck = t.CK.Value,
                //tb = ((t.TK1.Value + t.TK2.Value + t.TK3.Value) + (2 * t.GK.Value) + (5 * t.CK.Value)) / 10
            }).ToList();
            return lst;
        }
        public List<eDiem> GetDiemLopHocPhan(string id_LopHP)
        {
            List<eDiem> lst = db.Diems.Where(x => x.ID_LopHocPhan == id_LopHP).Select(t => new eDiem
            {
                //id_SinhVien = t.ID_SinhVien,
                //hoTenSV = t.SinhVien.HoVaTen,
                //tenLopNC = t.SinhVien.LopNienChe.TenLop,
                //id_LopHP = t.ID_LopHocPhan,
                //tenHP = t.LopHocPhan.HocPhan.TenMonHoc,
                //tenGiangVien = t.LopHocPhan.GiangVien.HoVaTen,
                //hocKy = t.LopHocPhan.HocKy.Value,
                //namHoc = t.LopHocPhan.NamHoc,
                //tk1 = t.TK1.Value,
                //tk2 = t.TK2.Value,
                //tk3 = t.TK3.Value,
                //gk = t.GK.Value,
                //ck = t.CK.Value,
                //tb = ((t.TK1.Value + t.TK2.Value + t.TK3.Value) + (2 * t.GK.Value) + (5 * t.CK.Value)) / 10
            }).ToList();
            return lst;
        }
    }
}
