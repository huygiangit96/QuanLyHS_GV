//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLHSGV.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ThongTinGiangDay
    {
        public string MaKip { get; set; }
        public string MaGV { get; set; }
        public string TenLop { get; set; }
        public string MonHoc { get; set; }
        public System.DateTime Ngay { get; set; }
        public int SoTiet { get; set; }
    
        public virtual GiaoVien GiaoVien { get; set; }
        public virtual LopHoc LopHoc { get; set; }
    }
}