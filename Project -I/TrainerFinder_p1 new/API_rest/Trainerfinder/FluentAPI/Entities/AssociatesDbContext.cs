using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Trainerfinder.Entities;

public partial class AssociatesDbContext : DbContext
{
    public AssociatesDbContext()
    {
    }

    public AssociatesDbContext(DbContextOptions<AssociatesDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Education> Educations { get; set; }

    public virtual DbSet<Experience> Experiences { get; set; }

    public virtual DbSet<Skill> Skills { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { 
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
         optionsBuilder.UseSqlServer("Server=tcp:associateserver.database.windows.net,1433;Initial Catalog=AssociatesDb;User ID=associate;Password=Password123;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Education>(entity =>
        {
            entity.HasKey(e => e.Educationid).HasName("pk_eduid");

            entity.Property(e => e.Educationid).ValueGeneratedNever();

            entity.HasOne(d => d.User).WithMany(p => p.Educations)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_eduid");
        });

        modelBuilder.Entity<Experience>(entity =>
        {
            entity.HasKey(e => e.Companyid).HasName("pk_experid");

            entity.Property(e => e.Companyid).ValueGeneratedNever();

            entity.HasOne(d => d.User).WithMany(p => p.Experiences)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_experid");
        });

        modelBuilder.Entity<Skill>(entity =>
        {
            entity.HasKey(e => e.Skillid).HasName("pk_skillid");

            entity.Property(e => e.Skillid).ValueGeneratedNever();

            entity.HasOne(d => d.User).WithMany(p => p.Skills)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_users");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("pk_users");

            entity.Property(e => e.UserId).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
