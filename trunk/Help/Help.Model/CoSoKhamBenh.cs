//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Help.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CoSoKhamBenh
    {
        public CoSoKhamBenh()
        {
            this.DichVuKhams = new HashSet<DichVuKham>();
            this.LichKhamBenhs = new HashSet<LichKhamBenh>();
            this.Images = new HashSet<Image>();
        }
    
        public int Id { get; set; }
        public string TenCS { get; set; }
        public string DiaChi { get; set; }
        public Nullable<int> LoaiCoSo { get; set; }
        public Nullable<int> LoaiDieuTri { get; set; }
        public string ThongTinChung { get; set; }
        public string ChuThich { get; set; }
        public Nullable<int> NguoiTao { get; set; }
        public Nullable<int> NguoiChinhSua { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public Nullable<System.DateTime> NgayChinhSua { get; set; }
        public string ContentSearch { get; set; }
    
        public virtual LoaiCoSoKhamBenh LoaiCoSoKhamBenh { get; set; }
        public virtual LoaiDieuTri LoaiDieuTri1 { get; set; }
        public virtual ICollection<DichVuKham> DichVuKhams { get; set; }
        public virtual ICollection<LichKhamBenh> LichKhamBenhs { get; set; }
        public virtual ICollection<Image> Images { get; set; }
    }
}
