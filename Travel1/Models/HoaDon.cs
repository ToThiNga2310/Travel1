//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Travel1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HoaDon
    {
        public int IDHoadon { get; set; }
        public Nullable<int> IDUser { get; set; }
        public Nullable<int> IDTour { get; set; }
        public Nullable<int> Tongtien { get; set; }
    
        public virtual Tour Tour { get; set; }
        public virtual User User { get; set; }
    }
}
