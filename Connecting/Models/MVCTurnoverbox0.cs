namespace Connecting.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MVCTurnoverbox0 : DbContext
    {
        public MVCTurnoverbox0()
            : base("name=MVCTurnoverbox0")
        {
        }

        public virtual DbSet<TurnoverBox0> TurnoverBox0 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
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
        }
    }
}
