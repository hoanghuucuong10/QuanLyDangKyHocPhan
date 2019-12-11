using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class TaiKhoanBLL
    {
        SinhVienDAL svDAL = new SinhVienDAL();
        GiangVienDAL gvDAL = new GiangVienDAL();
        NhanVienDAL nvDAL = new NhanVienDAL();
        public TaiKhoanBLL()
        {

        }

        public Object Login(string userName, string passWord)
        {
            Object kq;
            if (userName.Contains("sv"))
            {
                kq = svDAL.CheckLogInSinhVien(userName, passWord);            
            }
            else if (userName.Contains("gv"))
            {
                kq = gvDAL.CheckLogInGiangVien(userName, passWord);
            }
            else
            {
                kq = nvDAL.CheckLogInNhanVienPDT(userName, passWord);            
            }
            return kq;
            
        }

        public bool DoiMatKhau(object tk,string mkMoi)
        {
            if (tk is eSinhVien)
            {
                return svDAL.DoiMatKhau((eSinhVien)tk, mkMoi);
            }
            else if (tk is eGiangVien)
            {
                return gvDAL.DoiMatKhau((eGiangVien)tk, mkMoi);

            }
            else
            {
                return nvDAL.DoiMatKhau((eNhanVienPDT)tk, mkMoi);
            }
   
        }
    }
}
