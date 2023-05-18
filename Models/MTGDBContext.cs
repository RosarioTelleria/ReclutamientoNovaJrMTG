﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ReclutamientoNovaJrMTG.Models
{
    public partial class MTGDBContext : DbContext
    {
        public MTGDBContext()
        {
        }

        public MTGDBContext(DbContextOptions<MTGDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<Sucursales> Sucursales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=MTGDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Productos>(entity =>
            {
                entity.HasKey(e => e.ProductoId);

                entity.Property(e => e.ProductoId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ProductoID");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FechaAlta).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.ModificadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Precio1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sucursales)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sucursales>(entity =>
            {
                entity.HasKey(e => e.SucursalId);

                entity.Property(e => e.SucursalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SucursalID");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAlta).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.NombreComercial)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SucursalMatriz)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}