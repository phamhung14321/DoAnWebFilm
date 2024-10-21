using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.Entities
{
    public partial class MovieContext : DbContext
    {
        public MovieContext()
            : base("name=MovieContext")
        {
        }

        public virtual DbSet<admins> admins { get; set; }
        public virtual DbSet<movies> movies { get; set; }
        public virtual DbSet<ratings> ratings { get; set; }
        public virtual DbSet<users> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ratings>()
                .Property(e => e.rating)
                .HasPrecision(3, 1);

            modelBuilder.Entity<ratings>()
                .Property(e => e.review)
                .IsUnicode(false);
        }
    }
}
