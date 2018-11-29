namespace Connecting.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CLOUD : DbContext
    {
        public CLOUD()
            : base("name=CLOUD")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Comp> Comps { get; set; }
        public virtual DbSet<Pallet> Pallets { get; set; }
        public virtual DbSet<Pool> Pools { get; set; }
        public virtual DbSet<sqlview> sqlviews { get; set; }
        public virtual DbSet<testtab> testtabs { get; set; }
        public virtual DbSet<TurnoverBox> TurnoverBoxes { get; set; }
        public virtual DbSet<TurnoverBox0> TurnoverBox0 { get; set; }
        public virtual DbSet<sqlview1> sqlview1 { get; set; }

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
                .Property(e => e.Speed)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
                .Property(e => e.Time)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
                .Property(e => e.Status)
                .IsUnicode(false);

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

            modelBuilder.Entity<Pool>()
                .Property(e => e.Pools_id)
                .IsUnicode(false);

            modelBuilder.Entity<Pool>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<sqlview>()
                .Property(e => e.Car_id)
                .IsUnicode(false);

            modelBuilder.Entity<sqlview>()
                .Property(e => e.Turnoverbox_id)
                .IsUnicode(false);

            modelBuilder.Entity<sqlview>()
                .Property(e => e.Pallet_id)
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

            modelBuilder.Entity<testtab>()
                .Property(e => e.PRIMARYKEY)
                .IsUnicode(false);

            modelBuilder.Entity<testtab>()
                .Property(e => e.TESTVALUE)
                .IsUnicode(false);

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

            modelBuilder.Entity<TurnoverBox0>()
                .Property(e => e.Turnoverbox_id)
                .IsUnicode(false);

            modelBuilder.Entity<TurnoverBox0>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<TurnoverBox0>()
                .Property(e => e.Time)
                .IsUnicode(false);

            modelBuilder.Entity<TurnoverBox0>()
                .Property(e => e.Enduser)
                .IsUnicode(false);

            modelBuilder.Entity<TurnoverBox0>()
                .Property(e => e.Pallet_id)
                .IsUnicode(false);

            modelBuilder.Entity<sqlview1>()
                .Property(e => e.Car_id)
                .IsUnicode(false);

            modelBuilder.Entity<sqlview1>()
                .Property(e => e.Pallet_id)
                .IsUnicode(false);

            modelBuilder.Entity<sqlview1>()
                .Property(e => e.Turnoverbox_id)
                .IsUnicode(false);

            modelBuilder.Entity<sqlview1>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<sqlview1>()
                .Property(e => e.Time)
                .IsUnicode(false);

            modelBuilder.Entity<sqlview1>()
                .Property(e => e.Temperature)
                .IsUnicode(false);

            modelBuilder.Entity<sqlview1>()
                .Property(e => e.Humidity)
                .IsUnicode(false);

            modelBuilder.Entity<sqlview1>()
                .Property(e => e.Location_x)
                .IsUnicode(false);

            modelBuilder.Entity<sqlview1>()
                .Property(e => e.Location_y)
                .IsUnicode(false);
        }
    }
}
