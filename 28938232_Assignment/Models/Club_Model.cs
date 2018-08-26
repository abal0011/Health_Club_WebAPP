namespace _28938232_Assignment.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Club_Model : DbContext
    {
        public Club_Model()
            : base("name=Club_Model")
        {
        }

        public virtual DbSet<club> clubs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<club>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<club>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<club>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<club>()
                .Property(e => e.Contact)
                .IsUnicode(false);
        }
    }
}
