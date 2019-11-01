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
        public int AddLopHocPhan(string id, eLopHocPhan x)
        {

            return LHP.AddLopHocPhan(id, x);
        }

        public string CreateID()
        {
            return LHP.CreateID();
        }


        public List<eLopHocPhan> SearchLopHocPhan(string maLopHocPhan, string maMonHoc, string hocKy, string namHoc)
        {
           
            return LHP.SearchLopHocPhan(maLopHocPhan,maMonHoc,hocKy,namHoc);
        }

    }
}
