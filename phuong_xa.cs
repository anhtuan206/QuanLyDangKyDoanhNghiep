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
    
    public partial class phuong_xa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public phuong_xa()
        {
            this.thongtin_diachi = new HashSet<thongtin_diachi>();
        }
    
        public int id { get; set; }
        public string ten_phuong_xa { get; set; }
        public int id_quan_huyen { get; set; }
    
        public virtual quan_huyen quan_huyen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<thongtin_diachi> thongtin_diachi { get; set; }
    }
}
