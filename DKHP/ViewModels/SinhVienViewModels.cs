using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using BLL;
namespace DKHP.ViewModels
{
    public class SinhVienViewModels
    {
        public string ID_SinhVien { get; set; }
        public string MatKhau { get; set; }
        public string HoVaTen { get; set; }
        public string ID_LopNienChe { get; set; }
        public string TenLopNienChe { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Mail { get; set; }
        public byte[] HinhAnh { get; set; }

        public SinhVienViewModels(eSinhVien sv)
        {   
            this.ID_SinhVien = sv.ID_SinhVien;
            this.MatKhau = sv.MatKhau;
            this.HoVaTen = sv.HoVaTen;
            this.ID_LopNienChe = sv.ID_LopNienChe;
            this.DiaChi = sv.DiaChi;
            this.SDT = sv.SDT;
            this.Mail = sv.Mail;
            this.HinhAnh = sv.HinhAnh;
            this.TenLopNienChe = new LopNienCheBLL().GetLopNienCheByID(sv.ID_LopNienChe).TenLop;
        }

        
    }
}
