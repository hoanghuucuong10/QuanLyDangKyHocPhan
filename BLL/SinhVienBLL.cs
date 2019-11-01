using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;
namespace BLL
{
    public class SinhVienBLL
    {
        SinhVienDAL svDAL = new SinhVienDAL();
        public List<eSinhVien> GetAllSinhVien()
        {
            return svDAL.GetAllSinhVien();
        }
        public List<eSinhVien> SearchAllSinhVien(string id, string name)
        {          
            return svDAL.SearchAllSinhVien(id,name);
        }
        public eSinhVien GetSinhVienByID(string id)
        {
            return svDAL.GetSinhVienByID(id);
        }

        public bool AddNewSinhVien(eSinhVien eSV)
        {
            return svDAL.AddNewSinhVien(eSV);
        }
        public bool EditSinhVien(string id, eSinhVien eSV)
        {
            return svDAL.EditSinhVien(id, eSV);
        }
        public string CreateID()
        {
            return svDAL.CreateID();
        }
    }
}
