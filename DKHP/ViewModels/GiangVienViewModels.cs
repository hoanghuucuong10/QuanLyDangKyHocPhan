using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Entities;
namespace DKHP.ViewModels
{
    public class GiangVienViewModels
    {
        public string ID_GiangVien { get; set; }
        public string MatKhau { get; set; }
        public string HoVaTen { get; set; }
        public string TrinhDo { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Mail { get; set; }
        public byte[] HinhAnh { get; set; }

        public GiangVienViewModels(eGiangVien sv)
        {
            this.ID_GiangVien = sv.ID_GiangVien;
            this.MatKhau = sv.MatKhau;
            this.HoVaTen = sv.HoVaTen;
            this.TrinhDo = sv.TrinhDo;
            this.DiaChi = sv.DiaChi;
            this.SDT = sv.SDT;
            this.Mail = sv.Mail;
            this.HinhAnh = sv.HinhAnh;
        }

    }
}
