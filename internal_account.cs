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
    
    public partial class internal_account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public internal_account()
        {
            this.doanh_nghiep = new HashSet<doanh_nghiep>();
        }
    
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public System.DateTime create_time { get; set; }
        public bool is_locked { get; set; }
        public int id_nhan_vien { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<doanh_nghiep> doanh_nghiep { get; set; }
        public virtual nhan_vien nhan_vien { get; set; }
    }
}
