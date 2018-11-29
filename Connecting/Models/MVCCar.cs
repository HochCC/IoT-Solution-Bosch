namespace Connecting.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MVCCar : DbContext
    {
        public MVCCar()
            : base("name=MVCCar")
        {
        }

        public virtual DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .Property(e => e.Car_id)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
                .Property(e => e.Location_x)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
                .Property(e => e.Location_y)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
                .Property(e => e.Temperature)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
                .Property(e => e.Humidity)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
                .Property(e => e.Lfrom)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
                .Property(e => e.Lto)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
                .Property(e => e.Speed)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
                .Property(e => e.Time)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
               .Property(e => e.Status)
               .IsUnicode(false);
        }
    }
}
