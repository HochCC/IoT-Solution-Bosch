namespace Connecting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pallet")]
    public partial class Pallet
    {
        [Key]
        [StringLength(50)]
        public string Pallet_id { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(50)]
        public string Car_id { get; set; }

        [StringLength(50)]
        public string Time { get; set; }
    }
}
