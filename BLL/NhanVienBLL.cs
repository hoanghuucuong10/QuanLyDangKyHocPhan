using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;
namespace BLL
{
    public class NhanVienBLL
    {
        NhanVienDAL nvDAL = new NhanVienDAL();
        public eNhanVienPDT GetNhanVienByID(string id)
        {
            return nvDAL.GetNhanVienByID(id);
        }
        public int EditNhanVien(eNhanVienPDT env)
        {
            return nvDAL.EditNhanVien(env);
        }
    }
}
