using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;
namespace BLL
{
    public class LopHocPhanBLL
    {
        LopHocPhanDAL LHP = new LopHocPhanDAL();
        public List<eLopHocPhan> GetAllLopHocPhan()
        {
            return LHP.GetAllLopHocPhan();
        }
        public eLopHocPhan GetLopHocPhanbyID(string id)
        {
            return LHP.GetLopHocPhanbyID(id);
        }
        public eLopHocPhan GetLopHocPhanByIDNhomTH(string id)
        {
            return LHP.GetLopHocPhanByIDNhomTH(id);
        }
        public List<eLopHocPhan> GetAllLopHocPhanGiangVien(string idGV, int hocKy, string namHoc)
        {
            return LHP.GetAllLopHocPhanGiangVien(idGV, hocKy, namHoc);
        }

        public int EditLopHocPhan(eLopHocPhan x)
        {

            return LHP.EditLopHocPhan(x);
        }
        public int AddLopHocPhan(eLopHocPhan x)
        {

            return LHP.AddLopHocPhan(x);
        }

        public string CreateID()
        {
            return LHP.CreateID();
        }


        public List<eLopHocPhan> SearchLopHocPhan(string maLopHocPhan, string tenMonHoc, string hocKy, string namHoc)
        {

            return LHP.SearchLopHocPhan(maLopHocPhan, tenMonHoc, hocKy, namHoc);
        }
        public List<eLopHocPhan> SearchLopHocPhanDK(string maLopHocPhan, string tenMonHoc, string hocKy, string namHoc)
        {

            return LHP.SearchLopHocPhanDK(maLopHocPhan, tenMonHoc, hocKy, namHoc);
        }
        public List<eLopHocPhan> GetAllLopHocPhanSinhVien(string idSV, int hocKy, string namHoc)
        {
            return LHP.GetAllLopHocPhanSinhVien(idSV, hocKy, namHoc);
        }
        public string GetTrangThai(string id)
        {
            return LHP.GetTrangThai(id);
        }
        public bool HuyLopHP(string idLHP)
        {
            return LHP.HuyLopHP(idLHP);
        }
        public bool XoaLopHocPhan(string idLHP)
        {
            return LHP.XoaLopHocPhan(idLHP);
        }
    }
}
