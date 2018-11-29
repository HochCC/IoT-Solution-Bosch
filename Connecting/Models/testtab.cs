namespace Connecting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("testtab")]
    public partial class testtab
    {
        public int ID { get; set; }

        [StringLength(109)]
        public string PRIMARYKEY { get; set; }

        [StringLength(50)]
        public string TESTVALUE { get; set; }
    }
}
