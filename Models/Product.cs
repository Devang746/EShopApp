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
    
    public partial class Product
    {
        public int Id { get; set; }
        public string Productname { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int InventoryId { get; set; }
        public byte[] Productimage { get; set; }
        public double Price { get; set; }
        public int Discountid { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime Modified { get; set; }
        public System.DateTime Deleted { get; set; }
    }
}
