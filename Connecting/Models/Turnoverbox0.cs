namespace Connecting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TurnoverBox0
    {
        [Key]
        [StringLength(50)]
        public string Turnoverbox_id { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(50)]
        public string Time { get; set; }

        [StringLength(50)]
        public string Enduser { get; set; }

        [StringLength(50)]
        public string Pallet_id { get; set; }
    }
}
