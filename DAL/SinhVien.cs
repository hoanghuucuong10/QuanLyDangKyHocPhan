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
    
    public partial class SinhVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SinhVien()
        {
            this.DangKyHocPhans = new HashSet<DangKyHocPhan>();
            this.Diems = new HashSet<Diem>();
        }
    
        public string ID_SinhVien { get; set; }
        public string MatKhau { get; set; }
        public string HoVaTen { get; set; }
        public string ID_LopNienChe { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Mail { get; set; }
        public byte[] HinhAnh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DangKyHocPhan> DangKyHocPhans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Diem> Diems { get; set; }
        public virtual LopNienChe LopNienChe { get; set; }
    }
}
