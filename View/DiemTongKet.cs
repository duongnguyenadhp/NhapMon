//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace View
{
    using System;
    using System.Collections.Generic;
    
    public partial class DiemTongKet
    {
        public int MaHS { get; set; }
        public int MaXepLoai { get; set; }
        public double Diem { get; set; }
        public int NamHoc { get; set; }
        public int HocKy { get; set; }
    
        public virtual XepLoai XepLoai { get; set; }
        public virtual HocSinh HocSinh { get; set; }
    }
}