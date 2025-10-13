using Microsoft.EntityFrameworkCore;

namespace WorkingWithData.Models
{
    public class Assign1PROG30000 : DbContext
    {
        public EventDbContext(DbContextOptions<EventDbContext> options) : base(options)
        {
        }
        
        public DbSet<Event> Events => Set<Event>();
        public DbSet<Rsvp> Rsvps => Set<Rsvp>();
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Configure Event entity
            modelBuilder.Entity<Event>(entity =>
            {
                entity.HasKey(e => e.EventId);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Description).IsRequired().HasMaxLength(500);
                entity.Property(e => e.Location).IsRequired().HasMaxLength(200);
            });
            
            // Configure RSVP entity
            modelBuilder.Entity<Rsvp>(entity =>
            {
                entity.HasKey(r => r.RsvpId);
                entity.Property(r => r.Name).IsRequired().HasMaxLength(100);
                entity.Property(r => r.Email).IsRequired().HasMaxLength(200);
                entity.Property(r => r.Phone).HasMaxLength(20);
                
                // Configure relationship
                entity.HasOne(r => r.Event)
                      .WithMany(e => e.Rsvps)
                      .HasForeignKey(r => r.EventId)
                      .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}