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
    
    public partial class nganh_nghe_dangky
    {
        public int id { get; set; }
        public int id_doanh_nghiep { get; set; }
        public Nullable<int> id_nganh_nghe { get; set; }
        public string nganh_nghe_khac { get; set; }
        public bool is_nganh_nghe_khac { get; set; }
    
        public virtual doanh_nghiep doanh_nghiep { get; set; }
        public virtual nganh_nghe nganh_nghe { get; set; }
    }
}