using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data;

public partial class AngularProjectContext : DbContext
{
    public AngularProjectContext()
    {
    }

    public AngularProjectContext(DbContextOptions<AngularProjectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Info> Infos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-10IS0K6\\VIBCAREEXPRESS;Database=AngularProject;User Id=sa;Password=PKpk123!@#;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Info>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Info");

            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.State).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
