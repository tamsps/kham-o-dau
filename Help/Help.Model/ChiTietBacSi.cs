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
    
    public partial class ChiTietBacSi
    {
        public int Id { get; set; }
        public Nullable<int> BacSiId { get; set; }
        public Nullable<int> ChuyenKhoaId { get; set; }
        public Nullable<int> NoiCongTac { get; set; }
        public Nullable<int> NguoiTao { get; set; }
        public Nullable<int> NguoiChinhSua { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public Nullable<System.DateTime> NgayChinhSua { get; set; }
    
        public virtual BacSi BacSi { get; set; }
    }
}
