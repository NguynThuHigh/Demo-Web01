//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo_Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CTHoaDon
    {
        public int IdInvoice { get; set; }
        public int IdPro { get; set; }
        public Nullable<int> ItemQuantity { get; set; }
    
        public virtual HoaDon HoaDon { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
