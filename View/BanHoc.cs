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
    
    public partial class BanHoc
    {
        public BanHoc()
        {
            this.MonHocs = new HashSet<MonHoc>();
        }
    
        public int MaBan { get; set; }
        public string TenBan { get; set; }
    
        public virtual ICollection<MonHoc> MonHocs { get; set; }
    }
}