using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Demo_03_API_With_EFC.Models;

public partial class CafeDbContext : DbContext
{
    public CafeDbContext()
    {
    }

    public CafeDbContext(DbContextOptions<CafeDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<MenuItem> MenuItems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=, 1433;Initial Catalog=CafeDb;User ID=SA;Password=MyPass@word;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Menu__3214EC07B07FE76A");

            entity.ToTable("Menu");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(255);

            entity.HasMany(d => d.MenuItems).WithMany(p => p.Menus)
                .UsingEntity<Dictionary<string, object>>(
                    "MenuMenuItem",
                    r => r.HasOne<MenuItem>().WithMany()
                        .HasForeignKey("MenuItemId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Menu_Menu__MenuI__3C69FB99"),
                    l => l.HasOne<Menu>().WithMany()
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Menu_Menu__MenuI__3B75D760"),
                    j =>
                    {
                        j.HasKey("MenuId", "MenuItemId").HasName("PK__Menu_Men__F10AED42FE40F0A7");
                        j.ToTable("Menu_MenuItem");
                    });
        });

        modelBuilder.Entity<MenuItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MenuItem__3214EC073DBEEFD3");

            entity.ToTable("MenuItem");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Category).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
