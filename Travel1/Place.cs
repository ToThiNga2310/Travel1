namespace Travel1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Place")]
    public partial class Place
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Place()
        {
            Scenic_Culture = new HashSet<Scenic_Culture>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PlaceID { get; set; }

        [StringLength(100)]
        public string PlaceName { get; set; }

        [StringLength(200)]
        public string PlaceTomTat { get; set; }

        public string PlaceChiTiet { get; set; }

        public int? Regions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Scenic_Culture> Scenic_Culture { get; set; }
    }
}
