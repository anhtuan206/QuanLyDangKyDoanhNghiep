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
    
    public partial class external_account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public external_account()
        {
            this.doanh_nghiep = new HashSet<doanh_nghiep>();
        }
    
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string ho_ten { get; set; }
        public Nullable<short> gioi_tinh { get; set; }
        public Nullable<System.DateTime> ngay_sinh { get; set; }
        public Nullable<int> id_quoc_tich { get; set; }
        public Nullable<int> id_dan_toc { get; set; }
        public Nullable<System.DateTime> create_time { get; set; }
        public Nullable<bool> is_locked { get; set; }
        public Nullable<int> id_dia_chi { get; set; }
    
        public virtual dan_toc dan_toc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<doanh_nghiep> doanh_nghiep { get; set; }
        public virtual quoc_tich quoc_tich { get; set; }
        public virtual thongtin_diachi thongtin_diachi { get; set; }
    }
}
