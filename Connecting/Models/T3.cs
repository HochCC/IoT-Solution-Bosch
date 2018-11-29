using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Connecting.Models
{
    public class T3
    {
        [Key]
        public string Turnoverbox_id { get; set; }
        public string Pallet_id { get; set; }
        public string Car_id { get; set; }
        public string Temperature { get; set; }
        public string Location_x { get; set; } 
    }

    public class T3DBContext : DbContext
    {
        public DbSet<T3> T3 { get; set; }
    }
}