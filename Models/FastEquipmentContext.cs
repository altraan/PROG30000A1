using Microsoft.EntityFrameworkCore;

namespace Assign1PROG30000.Models
{
    public class FastEquipmentContext : DbContext
    {
        public FastEquipmentContext(DbContextOptions<FastEquipmentContext> options) : base(options)
        {
        }

        public DbSet<Equipment> Equipments => Set<Equipment>();
        public DbSet<Request> Requests => Set<Request>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Equipment> (entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Type).IsRequired();
                entity.Property(e => e.Description).IsRequired().HasMaxLength(200);
                entity.Property(e => e.IsAvailable).IsRequired();
            });

            modelBuilder.Entity<Request> (entity =>
            {
                entity.HasKey(r => r.EquipmentId);
                entity.Property(r => r.Name).IsRequired().HasMaxLength(100);
                entity.Property(r => r.Email).IsRequired().HasMaxLength(200);
                entity.Property(r => r.Phone).IsRequired().HasMaxLength(20);
                entity.Property(r => r.Role).IsRequired();
                entity.Property(r => r.DurationDays).IsRequired();
                entity.Property(r => r.CreatedAt).IsRequired();
                entity.Property(r => r.Status).IsRequired();

                entity.HasOne<Equipment>()
                      .WithMany()
                      .HasForeignKey(r => r.EquipmentId)
                      .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}