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
    
    public partial class Tour
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tour()
        {
            this.HoaDons = new HashSet<HoaDon>();
        }
    
        public int IDTour { get; set; }
        public string Tieude { get; set; }
        public string short_desc { get; set; }
        public Nullable<System.DateTime> Batdau { get; set; }
        public Nullable<System.DateTime> Ketthuc { get; set; }
        public Nullable<int> Maxhanhkhach { get; set; }
        public string long_desc { get; set; }
        public Nullable<int> Gia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
