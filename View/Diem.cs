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
    
    public partial class Diem
    {
        public Diem()
        {
            this.BangDiems = new HashSet<BangDiem>();
        }
    
        public int MaDiem { get; set; }
        public string TenDiem { get; set; }
    
        public virtual ICollection<BangDiem> BangDiems { get; set; }
    }
}
