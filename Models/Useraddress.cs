//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EShopApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Useraddress
    {
        public int Id { get; set; }
        public int Userid { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int Pincode { get; set; }
        public long Mobileno { get; set; }
    
        public virtual Userdetail Userdetail { get; set; }
    }
}