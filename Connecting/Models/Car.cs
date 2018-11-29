namespace Connecting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Car")]
    public partial class Car
    {
        [Key]
        [StringLength(50)]
        public string Car_id { get; set; }

        [StringLength(50)]
        public string Location_x { get; set; }

        [StringLength(50)]
        public string Location_y { get; set; }

        [StringLength(50)]
        public string Temperature { get; set; }

        [StringLength(50)]
        public string Humidity { get; set; }

        [StringLength(50)]
        public string Lfrom { get; set; }

        [StringLength(50)]
        public string Lto { get; set; }

        [StringLength(50)]
        public string Speed { get; set; }

        [StringLength(50)]
        public string Time { get; set; }

        [StringLength(50)]
        public string Status { get; set; }
    }
}
