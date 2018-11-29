namespace Connecting.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MVCPallet : DbContext
    {
        public MVCPallet()
            : base("name=MVCPallet")
        {
        }

        public virtual DbSet<Pallet> Pallets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pallet>()
                .Property(e => e.Pallet_id)
                .IsUnicode(false);

            modelBuilder.Entity<Pallet>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Pallet>()
                .Property(e => e.Car_id)
                .IsUnicode(false);

            modelBuilder.Entity<Pallet>()
                .Property(e => e.Time)
                .IsUnicode(false);
        }
    }
}
