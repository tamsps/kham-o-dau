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
    
    public partial class KhungGio
    {
        public KhungGio()
        {
            this.LichKhamBenhs = new HashSet<LichKhamBenh>();
        }
    
        public int Id { get; set; }
        public string KhungGio1 { get; set; }
        public string MoTa { get; set; }
    
        public virtual ICollection<LichKhamBenh> LichKhamBenhs { get; set; }
    }
}