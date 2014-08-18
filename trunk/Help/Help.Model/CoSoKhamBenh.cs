﻿//------------------------------------------------------------------------------
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
    using System.ComponentModel.DataAnnotations;
    
    public partial class CoSoKhamBenh
    {
        public CoSoKhamBenh()
        {
            this.DichVuKhams = new HashSet<DichVuKham>();
            this.LichKhamBenhs = new HashSet<LichKhamBenh>();
            this.Images = new HashSet<Image>();
        }
    
        public int Id { get; set; }
        [Display(Name = "Tên Cơ Sở")]
        public string TenCS { get; set; }
        [Display(Name = "Địa Chỉ")]
        public string DiaChi { get; set; }
        [Display(Name = "Loại Cơ Sở")]
        public Nullable<int> LoaiCoSo { get; set; }
        [Display(Name = "Loại Điều Trị")]
        public Nullable<int> LoaiDieuTri { get; set; }
        [Display(Name = "Thông Tin Chung")]
        public string ThongTinChung { get; set; }
        [Display(Name = "Chú Thích")]
        public string ChuThich { get; set; }
        [Display(Name = "Người Tạo")]
        public Nullable<int> NguoiTao { get; set; }
        [Display(Name = "Người Chỉnh Sửa")]
        public Nullable<int> NguoiChinhSua { get; set; }
        [Display(Name = "Ngày Tạo")]
        public Nullable<System.DateTime> NgayTao { get; set; }
        [Display(Name = "Ngày Chỉnh Sửa")]
        public Nullable<System.DateTime> NgayChinhSua { get; set; }
        
        public string ContentSearch { get; set; }
    
        public virtual LoaiCoSoKhamBenh LoaiCoSoKhamBenh { get; set; }
        public virtual LoaiDieuTri LoaiDieuTri1 { get; set; }
        public virtual ICollection<DichVuKham> DichVuKhams { get; set; }
        public virtual ICollection<LichKhamBenh> LichKhamBenhs { get; set; }
        public virtual ICollection<Image> Images { get; set; }
    }
}
