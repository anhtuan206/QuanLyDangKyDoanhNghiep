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
    
    public partial class doanh_nghiep
    {
        public int id { get; set; }
        public string ten { get; set; }
        public int loai_hinh_id { get; set; }
        public int nganh_nghe_id { get; set; }
        public string dia_chi { get; set; }
        public string so_dien_thoai { get; set; }
        public string email_doanh_nghiep { get; set; }
        public int external_account_id { get; set; }
        public bool is_approved { get; set; }
        public Nullable<int> approved_by { get; set; }
        public Nullable<System.DateTime> approved_time { get; set; }
    
        public virtual external_account external_account { get; set; }
        public virtual internal_account internal_account { get; set; }
        public virtual nganh_nghe nganh_nghe { get; set; }
        public virtual loai_hinh loai_hinh { get; set; }
    }
}