using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public partial class ConcesionarioContext : DbContext
{
    public ConcesionarioContext()
    {
    }

    public ConcesionarioContext(DbContextOptions<ConcesionarioContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Asesor> Asesores { get; set; }

    public virtual DbSet<Ciudad> Ciudades { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<TipoVehiculo> TipoVehiculos { get; set; }

    public virtual DbSet<Vehiculo> Vehiculos { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Asesor>(entity =>
        {
            entity.HasKey(e => e.IdAsesor).HasName("PK__asesor__A801FCE964A6485D");

            entity.ToTable("asesor");

            entity.Property(e => e.IdAsesor).HasColumnName("idAsesor");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.IdCiudad).HasColumnName("idCiudad");
            entity.Property(e => e.IdDepartamento).HasColumnName("idDepartamento");
            entity.Property(e => e.Identificacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("identificacion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdCiudadNavigation).WithMany(p => p.Asesors)
                .HasForeignKey(d => d.IdCiudad)
                .HasConstraintName("FK__asesor__idCiudad__123EB7A3");

            entity.HasOne(d => d.IdDepartamentoNavigation).WithMany(p => p.Asesors)
                .HasForeignKey(d => d.IdDepartamento)
                .HasConstraintName("FK__asesor__idDepart__10566F31");
        });

        modelBuilder.Entity<Ciudad>(entity =>
        {
            entity.HasKey(e => e.IdCiudad).HasName("PK__ciudad__AEA2A71B55117C15");

            entity.ToTable("ciudad");

            entity.Property(e => e.IdCiudad).HasColumnName("idCiudad");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.IdDepartamento).HasColumnName("idDepartamento");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdDepartamentoNavigation).WithMany(p => p.Ciudads)
                .HasForeignKey(d => d.IdDepartamento)
                .HasConstraintName("FK__ciudad__idDepart__04E4BC85");
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasKey(e => e.IdDepartamento).HasName("PK__departam__C225F98D0FD2AE73");

            entity.ToTable("departamento");

            entity.Property(e => e.IdDepartamento).HasColumnName("idDepartamento");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<TipoVehiculo>(entity =>
        {
            entity.HasKey(e => e.IdTipovehiculo).HasName("PK__tipoVehi__2D7E95E096546F59");

            entity.ToTable("tipoVehiculo");

            entity.Property(e => e.IdTipovehiculo).HasColumnName("idTipovehiculo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Vehiculo>(entity =>
        {
            entity.HasKey(e => e.IdVehiculo).HasName("PK__Vehiculo__4868297009360C0E");

            entity.ToTable("Vehiculo");

            entity.Property(e => e.IdVehiculo).HasColumnName("idVehiculo");
            entity.Property(e => e.Color)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("color");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.Kilometraje)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kilometraje");
            entity.Property(e => e.Marca)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("marca");
            entity.Property(e => e.Placa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("placa");
            entity.Property(e => e.TipoVehiculo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tipoVehiculo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
