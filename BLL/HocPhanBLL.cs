using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;
namespace BLL
{
    public class HocPhanBLL
    {
        HocPhanDAL hocPhanDAL = new HocPhanDAL();
        public List<eHocPhan> GetALLHocPhan()
        {
            return hocPhanDAL.GetALLHocPhan();
        }
        public List<eHocPhan> SearchHocPhan(string id, string name)
        {
            return hocPhanDAL.SearchHocPhan(id, name);
        }
        public eHocPhan AddNewHocPhan(eHocPhan hp)
        {
            return hocPhanDAL.AddNewHocPhan(hp);
        }
        public eHocPhan EditHocPhan(string id, eHocPhan hp)
        {
            return hocPhanDAL.EditHocPhan(id,hp);
        }
        public eHocPhan GetHocPhanByID(string id)
        {        
            return hocPhanDAL.GetHocPhanByID(id);
        }
        public string CreateID()
        {
            return hocPhanDAL.CreateID(); ;
        }
    }
}
