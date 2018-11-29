namespace Connecting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pool
    {
        [Key]
        [StringLength(50)]
        public string Pools_id { get; set; }

        public int? Free { get; set; }

        [StringLength(50)]
        public string Location { get; set; }

        public int? Need { get; set; }
    }
}
