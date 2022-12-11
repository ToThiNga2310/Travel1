namespace Travel1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class News
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NewsID { get; set; }

        public int? EventID { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(200)]
        public string ImgUrl { get; set; }

        [StringLength(200)]
        public string TomTat { get; set; }

        [StringLength(200)]
        public string NoiDung { get; set; }

        public DateTime? PostDate { get; set; }

        public int? Status { get; set; }
    }
}
