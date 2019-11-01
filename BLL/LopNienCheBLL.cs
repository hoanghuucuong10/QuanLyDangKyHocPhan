using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;
namespace BLL
{
    public class LopNienCheBLL
    {
        LopNienCheDAL ncDAL = new LopNienCheDAL();
        public List<eLopNienChe> GetAllLopNienChe()
        {
            return ncDAL.GetAllLopNienChe();
        }
        public eLopNienChe GetLopNienCheByID(string id)
        {
            return ncDAL.GetLopNienCheByID(id);
        }
    }
}
