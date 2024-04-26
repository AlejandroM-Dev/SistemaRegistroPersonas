using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SistemaRegistroPersonas.Models;

namespace SistemaRegistroPersonas.DAL.DataContext;

public partial class DbRegistroPruebaContext : DbContext
{
    public DbRegistroPruebaContext()
    {
    }

    public DbRegistroPruebaContext(DbContextOptions<DbRegistroPruebaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<RegistroPersona> RegistroPersonas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RegistroPersona>(entity =>
        {
            entity.HasKey(e => e.IdRegistro);

            entity.Property(e => e.Apellidos).HasMaxLength(90);
            entity.Property(e => e.CorreoElectronico).HasMaxLength(50);
            entity.Property(e => e.CorreoElectronicoAlternativo).HasMaxLength(50);
            entity.Property(e => e.Direccion).HasMaxLength(150);
            entity.Property(e => e.DireccionAltenativa).HasMaxLength(150);
            entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");
            entity.Property(e => e.Nombres).HasMaxLength(90);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
