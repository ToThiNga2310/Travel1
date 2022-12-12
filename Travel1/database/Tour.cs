namespace Travel1.database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tour")]
    public partial class Tour
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tour()
        {
            BookTours = new HashSet<BookTour>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TourID { get; set; }

        [StringLength(300)]
        public string Name { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateGo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateBack { get; set; }

        [StringLength(50)]
        public string Note { get; set; }

        public int TourGuideID { get; set; }

        public int? NumPerson { get; set; }

        public int? Price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookTour> BookTours { get; set; }

        public virtual TourGuider TourGuider { get; set; }
    }
}
