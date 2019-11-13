using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;
namespace BLL
{
    public class DangKyHocPhanBLL
    {
        public eDangKyHocPhan GetDangKyHocPhanByIDLopHocPhan(string id)
        {
            return new DangKyHocPhanDAL().GetDangKyHocPhanByIDLopHocPhan(id);
        }
        public int SoLuong(string idLopHocPhan)
        {
            return new DangKyHocPhanDAL().SoLuong(idLopHocPhan);
        }
        public int SoLuongNhomTH(string idNhomTH)
        {
            return new DangKyHocPhanDAL().SoLuongNhomTH(idNhomTH);
        }
        public bool DangKy(string idSV, string idLopHP, string idNhomTH)
        {
            return new DangKyHocPhanDAL().DangKy(idSV, idLopHP, idNhomTH);
        }
        public bool HuyDangKy(string idSV, string idLopHP)
        {
            return new DangKyHocPhanDAL().HuyDangKy(idSV, idLopHP);
        }
    }
}
