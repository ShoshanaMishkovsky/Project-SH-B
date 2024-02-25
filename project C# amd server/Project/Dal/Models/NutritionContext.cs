using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Dal.Models;

public partial class NutritionContext : DbContext
{
    public NutritionContext(DbContextOptions<NutritionContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Dietitian> Dietitians { get; set; }

    public virtual DbSet<Meeting> Meetings { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Project-SH-B\\project C# amd server\\Project\\DB\\Nutrition.mdf\";Integrated Security=True;Connect Timeout=30");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Clients_pk");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BirthDate).HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("firstName");
            entity.Property(e => e.Kind)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("kind");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("phone");
        });

        modelBuilder.Entity<Dietitian>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Dietitians_pk");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("firstName");
            entity.Property(e => e.Kind)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("kind");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("phone");
        });

        modelBuilder.Entity<Meeting>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("Meetings_pk");

            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.ClientId).HasColumnName("clientId");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DieticanId).HasColumnName("dieticanId");
            entity.Property(e => e.Hour).HasColumnName("hour");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("status");

            entity.HasOne(d => d.Client).WithMany(p => p.Meetings)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("clientsId_fk");

            entity.HasOne(d => d.Dietican).WithMany(p => p.Meetings)
                .HasForeignKey(d => d.DieticanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("dieticanId_fk");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
