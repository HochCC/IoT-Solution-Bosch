namespace Connecting.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MVCsqlview : DbContext
    {
        public MVCsqlview()
            : base("name=MVCsqlview")
        {
        }

        public virtual DbSet<sqlview> sqlviews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<sqlview>()
                .Property(e => e.Car_id)
                .IsUnicode(false);

            modelBuilder.Entity<sqlview>()
                .Property(e => e.Pallet_id)
                .IsUnicode(false);

            modelBuilder.Entity<sqlview>()
                .Property(e => e.Turnoverbox_id)
                .IsUnicode(false);

            modelBuilder.Entity<sqlview>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<sqlview>()
                .Property(e => e.Time)
                .IsUnicode(false);

            modelBuilder.Entity<sqlview>()
                .Property(e => e.Temperature)
                .IsUnicode(false);

            modelBuilder.Entity<sqlview>()
                .Property(e => e.Humidity)
                .IsUnicode(false);

            modelBuilder.Entity<sqlview>()
                .Property(e => e.Location_x)
                .IsUnicode(false);

            modelBuilder.Entity<sqlview>()
                .Property(e => e.Location_y)
                .IsUnicode(false);
        }
    }
}
