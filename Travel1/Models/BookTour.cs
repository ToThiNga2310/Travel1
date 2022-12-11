namespace Travel1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookTour")]
    public partial class BookTour
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BookingID { get; set; }

        public int TourID { get; set; }

        public int CustomerID { get; set; }

        public int? NumPerson { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(50)]
        public string Note { get; set; }

        public int? Status { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Tour Tour { get; set; }
    }
}
