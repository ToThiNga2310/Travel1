using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Travel1.database
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=db_dulich")
        {
        }

        public virtual DbSet<AccountAdmin> AccountAdmins { get; set; }
        public virtual DbSet<BookTour> BookTours { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Hotel> Hotels { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Place> Places { get; set; }
        public virtual DbSet<Scenic_Culture> Scenic_Culture { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tour> Tours { get; set; }
        public virtual DbSet<TourGuider> TourGuiders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountAdmin>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<AccountAdmin>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Pass)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.BookTours)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<Scenic_Culture>()
                .HasMany(e => e.Hotels)
                .WithOptional(e => e.Scenic_Culture)
                .HasForeignKey(e => e.ScenicCultureID);

            modelBuilder.Entity<Tour>()
                .HasMany(e => e.BookTours)
                .WithRequired(e => e.Tour)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TourGuider>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<TourGuider>()
                .HasMany(e => e.Tours)
                .WithRequired(e => e.TourGuider)
                .HasForeignKey(e => e.TourGuideID)
                .WillCascadeOnDelete(false);
        }
    }
}
