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
    
    public partial class UserAdmin
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int UserGroup { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public Nullable<System.DateTime> NgayChinhSua { get; set; }
        public Nullable<byte> Status { get; set; }
    
        public virtual UserGroup UserGroup1 { get; set; }
    }
}
