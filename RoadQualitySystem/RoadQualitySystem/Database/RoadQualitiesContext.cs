using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace RoadQualitySystem.Database
{
    public partial class RoadQualitiesContext : DbContext
    {
        public RoadQualitiesContext()
        {
        }

        public RoadQualitiesContext(DbContextOptions<RoadQualitiesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<RoadQuality> RoadQualities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Polish_CI_AS");

            modelBuilder.Entity<RoadQuality>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longtitude).HasColumnName("longtitude");

                entity.Property(e => e.Score).HasColumnName("score");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
