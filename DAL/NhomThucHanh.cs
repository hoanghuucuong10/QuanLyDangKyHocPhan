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
    
    public partial class NhomThucHanh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhomThucHanh()
        {
            this.DangKyHocPhans = new HashSet<DangKyHocPhan>();
            this.LichHoc_NhomThucHanh = new HashSet<LichHoc_NhomThucHanh>();
        }
    
        public string ID_NhomThucHanh { get; set; }
        public string ID_LopHocPhan { get; set; }
        public string ID_GiangVien { get; set; }
        public string TenNhom { get; set; }
        public Nullable<int> SoTiet { get; set; }
        public Nullable<System.DateTime> NgayBatDau { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }
        public Nullable<int> SoLuong { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DangKyHocPhan> DangKyHocPhans { get; set; }
        public virtual GiangVien GiangVien { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichHoc_NhomThucHanh> LichHoc_NhomThucHanh { get; set; }
        public virtual LopHocPhan LopHocPhan { get; set; }
    }
}
