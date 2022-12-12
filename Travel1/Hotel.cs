namespace Travel1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hotel")]
    public partial class Hotel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HotelID { get; set; }

        public int? ScenicCultureID { get; set; }

        [StringLength(200)]
        public string HotelName { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(15)]
        public string Tel { get; set; }

        public string Note { get; set; }

        public virtual Scenic_Culture Scenic_Culture { get; set; }
    }
}
