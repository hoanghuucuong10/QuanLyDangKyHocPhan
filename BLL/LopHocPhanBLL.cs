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
        public List<eLopHocPhan> GetAllLopHocPhanGiangVien(string idGV, int hocKy,string namHoc)
        {
            return LHP.GetAllLopHocPhanGiangVien(idGV, hocKy, namHoc);
        }

        public int EditLopHocPhan(string id, eLopHocPhan x)
        {
            
            return LHP.EditLopHocPhan( id,x);
        }
        public int AddLopHocPhan( eLopHocPhan x)
        {

            return LHP.AddLopHocPhan( x);
        }

        public string CreateID()
        {
            return LHP.CreateID();
        }


        public List<eLopHocPhan> SearchLopHocPhan(string maLopHocPhan, string tenMonHoc, string hocKy, string namHoc)
        {
           
            return LHP.SearchLopHocPhan(maLopHocPhan,tenMonHoc,hocKy,namHoc);
        }
        public List<eLopHocPhan> GetAllHocPhanSinhVien(string idSV, int hocKy, string namHoc)
        {
            return LHP.GetAllHocPhanSinhVien(idSV, hocKy, namHoc);
        }

    }
}
