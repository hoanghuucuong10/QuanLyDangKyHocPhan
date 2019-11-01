using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace DAL
{
    public class NhanVienDAL
    {
        DangKyHocPhanEntities db = new DangKyHocPhanEntities();
        //Kiem tra dang nhap tai khoan sinh vien
        public eNhanVienPDT CheckLogInNhanVienPDT(string userName, string passWord)
        {
            NhanVienPDT nv = db.NhanVienPDTs.Where(x => x.ID_NhanVienPDT == userName).FirstOrDefault();
            if (nv == null)
                return null;
            else
            {
                // sai MK
                if (nv.MatKhau.Trim() != passWord)
                    return null;
                else
                {
                    eNhanVienPDT env = new eNhanVienPDT();
                    env.ID_NhanVienPDT = nv.ID_NhanVienPDT;
                    env.HoVaTen = nv.HoVaTen;
                    env.HinhAnh = nv.HinhAnh;
                    env.MatKhau = nv.MatKhau;
                    env.DiaChi = nv.DiaChi;
                    env.Mail = nv.Mail;
                    env.SDT = nv.SDT;

                    return env;
                }

            }
        }
        public eNhanVienPDT GetNhanVienByID(string id)
        {
            NhanVienPDT nv = db.NhanVienPDTs.Where(x => x.ID_NhanVienPDT == id).FirstOrDefault();
            if (nv == null)
                return null;
            else
            {
                eNhanVienPDT env = new eNhanVienPDT();
                env.ID_NhanVienPDT = nv.ID_NhanVienPDT;
                env.HinhAnh = nv.HinhAnh;
                env.HoVaTen = nv.HoVaTen;
                env.MatKhau = nv.MatKhau;
                env.DiaChi = nv.DiaChi;
                env.Mail = nv.Mail;
                env.SDT = nv.SDT;
                return env;
            }
        }
        public int EditNhanVien(eNhanVienPDT env)
        {
            NhanVienPDT nv = db.NhanVienPDTs.Where(x => x.ID_NhanVienPDT == env.ID_NhanVienPDT).FirstOrDefault();
            if (nv == null)
                return 0;
            else
            {
                nv.ID_NhanVienPDT = env.ID_NhanVienPDT;
                nv.HinhAnh = env.HinhAnh;
                nv.HoVaTen = env.HoVaTen;
                nv.MatKhau = env.MatKhau;
                nv.DiaChi = env.DiaChi;
                nv.Mail = env.Mail;
                nv.SDT = env.SDT;
                db.SaveChanges();
                return 1;
            }
        }
    }
}
