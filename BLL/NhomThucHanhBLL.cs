using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;
namespace BLL
{
    public class NhomThucHanhBLL
    {
        NhomThucHanhDAL nth = new NhomThucHanhDAL();
        public List<eNhomThucHanh> GetNhomByIDLopHocPhan(string id)
        {
            return nth.GetNhomByIDLopHocPhan(id);
        }
        public eNhomThucHanh GetNhomByID(string id)
        {
            return nth.GetNhomByID(id);
        }
        public string GetTenNhomByID(string id)
        {
            return nth.GetTenNhomByID(id);
        }
        public List<eNhomThucHanh> GetNhomByIDGiangVien(string id, int hocKy,string namHoc)
        {
            return nth.GetNhomByIDGiangVien(id, hocKy, namHoc);
        }
        public int EditNhomThucHanh(eNhomThucHanh a)
        {
           
            return nth.EditNhomThucHanh(a);
        }
        public int AddNewNhomThucHanh(eNhomThucHanh a)
        {
            
            return nth.AddNewNhomThucHanh(a);
        }
        public int DelNhomTH(string id)
        {
            return nth.DelNhomTH(id);
        }
        public string CreateID()
        {        
            return nth.CreateID();
        }
    }
}
