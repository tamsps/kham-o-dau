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
    
    public partial class BacSi
    {
        public BacSi()
        {
            this.ChiTietBacSis = new HashSet<ChiTietBacSi>();
            this.LichKhamBenhs = new HashSet<LichKhamBenh>();
        }
    
        public int Id { get; set; }
        public string Ten { get; set; }
        public Nullable<int> Tuoi { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string BangCapCaoNhat { get; set; }
        public string TruongTotNghiep { get; set; }
        public string NamTotNghiep { get; set; }
        public Nullable<int> NguoiTao { get; set; }
        public Nullable<int> NguoiChinhSua { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public Nullable<System.DateTime> NgayChinhSua { get; set; }
    
        public virtual ICollection<ChiTietBacSi> ChiTietBacSis { get; set; }
        public virtual ICollection<LichKhamBenh> LichKhamBenhs { get; set; }
    }
}
