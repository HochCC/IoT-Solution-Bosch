namespace Connecting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sqlview")]
    public partial class sqlview
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Car_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Turnoverbox_id { get; set; }

        [StringLength(50)]
        public string Pallet_id { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(50)]
        public string Time { get; set; }

        [StringLength(50)]
        public string Temperature { get; set; }

        [StringLength(50)]
        public string Humidity { get; set; }

        [StringLength(50)]
        public string Location_x { get; set; }

        [StringLength(50)]
        public string Location_y { get; set; }
    }
}
