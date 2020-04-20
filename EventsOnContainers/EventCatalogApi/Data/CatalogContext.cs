using EventCatalogApi.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogApi.Data
{
    public class CatalogContext: DbContext
    {
        public CatalogContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<EventDetails> EventDetails { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<EventLocation> EventLocations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventType>(e =>
            {
                e.ToTable("EventTypes");

                e.Property(b => b.Id).IsRequired().UseHiLo("event_type_hilo");

                e.Property(b => b.Type).IsRequired().HasMaxLength(100);

                
            });
            modelBuilder.Entity<EventLocation>(e =>
            {
                e.ToTable("EventLocations");

                e.Property(b => b.Id).IsRequired().UseHiLo("event_location_hilo");

                e.Property(b => b.Location).IsRequired().HasMaxLength(100);


            });

            modelBuilder.Entity<EventDetails>(e =>
            {
               e.ToTable("EventDetails");

               e.Property(b => b.Id).IsRequired().UseHiLo("event_hilo");

               e.Property(b => b.Name).IsRequired().HasMaxLength(100);

               e.Property(b => b.Price).IsRequired().HasColumnType("decimal(5,2)");

               e.Property(b => b.Date).IsRequired();

               e.HasOne(b => b.EventType).WithMany().HasForeignKey(b => b.EventTypeId);

               e.HasOne(b => b.EventLocation).WithMany().HasForeignKey(b => b.EventLocationId);

           });
        }
    }
}
