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
    
    public partial class LoaiHanhKiem
    {
        public LoaiHanhKiem()
        {
            this.HanhKiems = new HashSet<HanhKiem>();
        }
    
        public int MaLoaiHanhKiem { get; set; }
        public string TenLoaiHanhKiem { get; set; }
    
        public virtual ICollection<HanhKiem> HanhKiems { get; set; }
    }
}