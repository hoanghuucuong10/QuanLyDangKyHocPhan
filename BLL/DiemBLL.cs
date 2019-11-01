using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class DiemBLL
    {
        DiemDAL diemDal = new DiemDAL();
        public List<eDiem> GetDiemSV(string idSV)
        {
            return diemDal.GetDiemSV(idSV);
        }
        public List<eDiem> GetDiemLopHocPhan(string id_LopHP)
        {
            return diemDal.GetDiemLopHocPhan(id_LopHP);
        }
    }
}
