//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyDangKyDoanhNghiep
{
    using System;
    using System.Collections.Generic;
    
    public partial class nhan_vien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nhan_vien()
        {
            this.internal_account = new HashSet<internal_account>();
        }
    
        public int id { get; set; }
        public string ho_ten { get; set; }
        public bool gioi_tinh { get; set; }
        public System.DateTime ngay_sinh { get; set; }
        public string so_cccd { get; set; }
        public System.DateTime ngay_cap { get; set; }
        public string noi_cap { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<internal_account> internal_account { get; set; }
    }
}