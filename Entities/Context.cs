using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace neva.entities
{
    public partial class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Empresa> Empresas { get; set; }
        public virtual DbSet<Perfil> Perfils { get; set; }
        public virtual DbSet<PerfilPermiso> PerfilPermisos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<UsuarioEmpresa> UsuarioEmpresas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=db-postgresql-sfo2-bms-do-user-10385926-0.b.db.ondigitalocean.com;Port=25060;Database=a360;Username=a360;Password=AVNS_BkjEl3Cw5BjK8cfiBa3 ;SslMode=Require; Trust Server Certificate=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "en_US.UTF-8");

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.ToTable("empresa");

                entity.HasIndex(e => e.RazonSocial, "un_empresa_razon_social")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.CantidadEmpleados)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("cantidad_empleados");

                entity.Property(e => e.Comuna)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("comuna");

                entity.Property(e => e.NivelVenta)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("nivel_venta");

                entity.Property(e => e.RazonSocial)
                    .IsRequired()
                    .HasMaxLength(155)
                    .HasColumnName("razon_social");

                entity.Property(e => e.Rubro)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("rubro");

                entity.Property(e => e.RutEmpresa)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("rut_empresa");

                entity.Property(e => e.SubRubro)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("sub_rubro");

                entity.Property(e => e.TamañoEmpresa)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("tamaño_empresa");
            });

            modelBuilder.Entity<Perfil>(entity =>
            {
                entity.ToTable("perfil");

                entity.HasIndex(e => e.Nombre, "un_perfil")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("detalle");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(155)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<PerfilPermiso>(entity =>
            {
                entity.ToTable("perfil_permiso");

                entity.HasIndex(e => new { e.PerfilId, e.Nombre, e.Detalle }, "un_perfil_permiso")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("detalle");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(155)
                    .HasColumnName("nombre");

                entity.Property(e => e.PerfilId).HasColumnName("perfil_id");

                entity.HasOne(d => d.Perfil)
                    .WithMany(p => p.PerfilPermisos)
                    .HasForeignKey(d => d.PerfilId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_perfil_permiso");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("usuario");

                entity.HasIndex(e => e.Email, "un_usuario_email")
                    .IsUnique();

                entity.HasIndex(e => e.Rut, "un_usuario_rut")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("apellidos");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.EmpresaId).HasColumnName("empresa_id");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.FechaUltimoacceso).HasColumnName("fecha_ultimoacceso");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("nombres");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("password");

                entity.Property(e => e.PerfilId).HasColumnName("perfil_id");

                entity.Property(e => e.Rut)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("rut");

                entity.HasOne(d => d.Empresa)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.EmpresaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuario_empresa_id");

                entity.HasOne(d => d.Perfil)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.PerfilId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuario_perfil_id");
            });

            modelBuilder.Entity<UsuarioEmpresa>(entity =>
            {
                entity.ToTable("usuario_empresa");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.EmpresaId).HasColumnName("empresa_id");

                entity.Property(e => e.UsuarioId).HasColumnName("usuario_id");

                entity.HasOne(d => d.Empresa)
                    .WithMany(p => p.UsuarioEmpresas)
                    .HasForeignKey(d => d.EmpresaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuario_empresa_empresa_id");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.UsuarioEmpresas)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuario_empresa_perfil_id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
