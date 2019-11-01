using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;
namespace BLL
{
    public class PhongHocBLL
    {
        PhongHocDAL ph = new PhongHocDAL();
        public List<ePhongHoc> GetAllPhongHoc()
        {
            
            return ph.GetAllPhongHoc();
        }
        public ePhongHoc GetPhongHocByID(string id)
        {
           
            return ph.GetPhongHocByID(id);
        }
        public ePhongHoc GetPhongHocByName(string name)
        {

            return ph.GetPhongHocByName(name);
        }
    }
}
