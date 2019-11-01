//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class LopHocPhan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LopHocPhan()
        {
            this.DangKyHocPhans = new HashSet<DangKyHocPhan>();
            this.Diems = new HashSet<Diem>();
            this.LichHoc_LopHocPhan = new HashSet<LichHoc_LopHocPhan>();
            this.NhomThucHanhs = new HashSet<NhomThucHanh>();
        }
    
        public string ID_LopHocPhan { get; set; }
        public string ID_HocPhan { get; set; }
        public string ID_NhanVienPDT { get; set; }
        public string ID_GiangVien { get; set; }
        public Nullable<int> ID_NienKhoa { get; set; }
        public Nullable<int> HocKy { get; set; }
        public string TrangThai { get; set; }
        public Nullable<int> SoTiet { get; set; }
        public Nullable<System.DateTime> NgayBatDau { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DangKyHocPhan> DangKyHocPhans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Diem> Diems { get; set; }
        public virtual GiangVien GiangVien { get; set; }
        public virtual HocPhan HocPhan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichHoc_LopHocPhan> LichHoc_LopHocPhan { get; set; }
        public virtual NhanVienPDT NhanVienPDT { get; set; }
        public virtual NienKhoa NienKhoa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhomThucHanh> NhomThucHanhs { get; set; }
    }
}