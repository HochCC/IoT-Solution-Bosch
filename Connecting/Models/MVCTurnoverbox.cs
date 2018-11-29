namespace Connecting.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MVCTurnoverbox : DbContext
    {
        public MVCTurnoverbox()
            : base("name=MVCTurnoverbox")
        {
        }

        public virtual DbSet<TurnoverBox> TurnoverBoxes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TurnoverBox>()
                .Property(e => e.Turnoverbox_id)
                .IsUnicode(false);

            modelBuilder.Entity<TurnoverBox>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<TurnoverBox>()
                .Property(e => e.Time)
                .IsUnicode(false);

            modelBuilder.Entity<TurnoverBox>()
                .Property(e => e.Enduser)
                .IsUnicode(false);

            modelBuilder.Entity<TurnoverBox>()
                .Property(e => e.Location_x)
                .IsUnicode(false);

            modelBuilder.Entity<TurnoverBox>()
               .Property(e => e.Location_y)
               .IsUnicode(false);

            modelBuilder.Entity<TurnoverBox>()
                .Property(e => e.Temperature)
                .IsUnicode(false);

            modelBuilder.Entity<TurnoverBox>()
                .Property(e => e.Humidity)
                .IsUnicode(false);

            modelBuilder.Entity<TurnoverBox>()
                .Property(e => e.Pallet_id)
                .IsUnicode(false);

            modelBuilder.Entity<TurnoverBox>()
               .Property(e => e.Car_id)
               .IsUnicode(false);
        }

        public System.Data.Entity.DbSet<Connecting.Models.Pallet> Pallets { get; set; }

        public System.Data.Entity.DbSet<Connecting.Models.Car> Cars { get; set; }
    }
}
