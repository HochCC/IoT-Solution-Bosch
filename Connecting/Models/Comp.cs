namespace Connecting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Comp")]
    public partial class Comp
    {
        public int Id { get; set; }

        public decimal? Time { get; set; }

        public int? Turnoverboxes { get; set; }

        [StringLength(50)]
        public string Company { get; set; }
    }
}
