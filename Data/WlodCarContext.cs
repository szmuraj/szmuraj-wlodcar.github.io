﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WlodCar.Models;

namespace WlodCar.Data;

public partial class WlodCarContext : DbContext
{
    public WlodCarContext()
    {
    }

    public WlodCarContext(DbContextOptions<WlodCarContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Reservation> Reservations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=WlodCar;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cars__3214EC073199146D");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Customer__3214EC071380398B");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Ballance).HasDefaultValueSql("((0.00))");
            entity.Property(e => e.IdCardNumber).IsFixedLength();
        });

        modelBuilder.Entity<Reservation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Reservat__3214EC07B9AA1EED");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Car).WithMany(p => p.Reservations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reservati__CarId__2D27B809");

            entity.HasOne(d => d.Customer).WithMany(p => p.Reservations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reservati__Custo__2E1BDC42");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
