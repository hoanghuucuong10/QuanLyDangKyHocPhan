using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class LoginBLL
    {
        SinhVienDAL svDAL = new SinhVienDAL();
        GiangVienDAL gvDAL = new GiangVienDAL();
        NhanVienDAL nvDAL = new NhanVienDAL();
        public LoginBLL()
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
    }
}
