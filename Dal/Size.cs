//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Size
    {
        public int sizeId { get; set; }
        public string sizeName { get; set; }
        public int categoryId { get; set; }
        public double price { get; set; }
    
        public virtual Category Category { get; set; }
    }
}