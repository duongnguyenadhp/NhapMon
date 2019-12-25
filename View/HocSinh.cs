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
    
    public partial class HocSinh
    {
        public HocSinh()
        {
            this.ChiTietPhieuThus = new HashSet<ChiTietPhieuThu>();
            this.DiemTongKets = new HashSet<DiemTongKet>();
            this.HanhKiems = new HashSet<HanhKiem>();
            this.BangDiems = new HashSet<BangDiem>();
            this.KhenThuongs = new HashSet<KhenThuong>();
            this.KyLuats = new HashSet<KyLuat>();
            this.LopHocs = new HashSet<LopHoc>();
            this.NguoiThans = new HashSet<NguoiThan>();
            this.PhieuDiemDanhs = new HashSet<PhieuDiemDanh>();
            this.TinhTrangHoSoes = new HashSet<TinhTrangHoSo>();
        }
    
        public int MaHS { get; set; }
        public string CMND { get; set; }
        public string TenHS { get; set; }
        public int MaDT { get; set; }
        public string DiaChi { get; set; }
        public Nullable<bool> GioiTinh { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
    
        public virtual ICollection<ChiTietPhieuThu> ChiTietPhieuThus { get; set; }
        public virtual DanToc DanToc { get; set; }
        public virtual ICollection<DiemTongKet> DiemTongKets { get; set; }
        public virtual ICollection<HanhKiem> HanhKiems { get; set; }
        public virtual ICollection<BangDiem> BangDiems { get; set; }
        public virtual ICollection<KhenThuong> KhenThuongs { get; set; }
        public virtual ICollection<KyLuat> KyLuats { get; set; }
        public virtual ICollection<LopHoc> LopHocs { get; set; }
        public virtual ICollection<NguoiThan> NguoiThans { get; set; }
        public virtual ICollection<PhieuDiemDanh> PhieuDiemDanhs { get; set; }
        public virtual ICollection<TinhTrangHoSo> TinhTrangHoSoes { get; set; }
    }
}
