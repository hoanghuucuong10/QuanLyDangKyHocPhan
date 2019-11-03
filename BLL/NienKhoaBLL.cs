using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class NienKhoaBLL
    {
        NienKhoaDAL nkDAL = new NienKhoaDAL();
        public bool CheckNienKhoa(string nienKhoa)
        {
          
            return nkDAL.CheckNienKhoa(nienKhoa);
        }
        public bool AddNienKhoa(string nienKhoa)
        {
                return nkDAL.AddNienKhoa(nienKhoa);
        }
        public List<eNienKhoa> GetAllNienKhoa()
        {
          return nkDAL.GetAllNienKhoa();
        }
        public eNienKhoa GetNienKhoaByID(int id)
        {
            return nkDAL.GetNienKhoaByID(id);
        }
    }
}
