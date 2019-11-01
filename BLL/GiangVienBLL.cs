using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;
namespace BLL
{
    public class GiangVienBLL
    {
        GiangVienDAL gvDAL = new GiangVienDAL();
        public List<eGiangVien> GetAllGiangVien()
        {
            return gvDAL.GetAllGiangVien();
        }
        public List<eGiangVien> SearchAllGiangVien(string id, string name)
        {
            return gvDAL.SearchAllGiangVien(id, name);
        }
        public eGiangVien GetGiangVienByID(string id)
        {
            return gvDAL.GetGiangVienByID(id);
        }

        public bool AddNewGiangVien(eGiangVien eGV)
        {
            return gvDAL.AddNewGiangVien(eGV);
        }
        public bool EditGiangVien(string id, eGiangVien eGV)
        {
            return gvDAL.EditGiangVien(id, eGV);
        }

        public string CreateID()
        {
            return gvDAL.CreateID();
        }
        public int CheckLichDay(GiangVien gv, int hocKy, string namHoc, string ngayHoc, string tietHoc)
        {
            return CheckLichDay(gv, hocKy, namHoc, ngayHoc, tietHoc);
        }
    }
}
