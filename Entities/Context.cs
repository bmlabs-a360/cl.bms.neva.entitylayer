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

        public virtual DbSet<Alternativa> Alternativas { get; set; }
        public virtual DbSet<Bitacora> Bitacoras { get; set; }
        public virtual DbSet<ControlToken> ControlTokens { get; set; }
        public virtual DbSet<Empresa> Empresas { get; set; }
        public virtual DbSet<Evaluacion> Evaluacions { get; set; }
        public virtual DbSet<EvaluacionEmpresa> EvaluacionEmpresas { get; set; }
        public virtual DbSet<ImportanciaEstrategica> ImportanciaEstrategicas { get; set; }
        public virtual DbSet<ImportanciaRelativa> ImportanciaRelativas { get; set; }
        public virtual DbSet<Perfil> Perfils { get; set; }
        public virtual DbSet<PerfilPermiso> PerfilPermisos { get; set; }
        public virtual DbSet<PlanMejora> PlanMejoras { get; set; }
        public virtual DbSet<Pregunta> Pregunta { get; set; }
        public virtual DbSet<Reporte> Reportes { get; set; }
        public virtual DbSet<ReporteArea> ReporteAreas { get; set; }
        public virtual DbSet<ReporteItem> ReporteItems { get; set; }
        public virtual DbSet<ReporteItemNivelBasico> ReporteItemNivelBasico { get; set; }
        public virtual DbSet<ReporteItemNivelSubscripcion> ReporteItemNivelSubscripcion { get; set; }
        public virtual DbSet<Respuesta> Respuesta { get; set; }
        public virtual DbSet<SegmentacionArea> SegmentacionAreas { get; set; }
        public virtual DbSet<SegmentacionSubArea> SegmentacionSubAreas { get; set; }
        public virtual DbSet<Seguimiento> Seguimientos { get; set; }
        public virtual DbSet<TipoCantidadEmpleado> TipoCantidadEmpleados { get; set; }
        public virtual DbSet<TipoDiferenciaRelacionada> TipoDiferenciaRelacionada { get; set; }
        public virtual DbSet<TipoImportancia> TipoImportancia { get; set; }
        public virtual DbSet<TipoItemReporte> TipoItemReportes { get; set; }
        public virtual DbSet<TipoNivelVenta> TipoNivelVenta { get; set; }
        public virtual DbSet<TipoRubro> TipoRubros { get; set; }
        public virtual DbSet<TipoSubRubro> TipoSubRubros { get; set; }
        public virtual DbSet<TipoTamanoEmpresa> TipoTamanoEmpresas { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<UsuarioArea> UsuarioAreas { get; set; }
        public virtual DbSet<UsuarioEmpresa> UsuarioEmpresas { get; set; }
        public virtual DbSet<UsuarioEvaluacion> UsuarioEvaluacions { get; set; }
        public virtual DbSet<UsuarioSuscripcion> UsuarioSuscripcions { get; set; }

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

            modelBuilder.Entity<Alternativa>(entity =>
            {
                entity.ToTable("alternativa");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasMaxLength(1250)
                    .HasColumnName("detalle");

                entity.Property(e => e.EvaluacionId).HasColumnName("evaluacion_id");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Orden).HasColumnName("orden");

                entity.Property(e => e.PreguntaId).HasColumnName("pregunta_id");

                entity.Property(e => e.Retroalimentacion)
                    .IsRequired()
                    .HasMaxLength(1250)
                    .HasColumnName("retroalimentacion");

                entity.Property(e => e.Valor).HasColumnName("valor");

                entity.HasOne(d => d.Evaluacion)
                    .WithMany(p => p.Alternativas)
                    .HasForeignKey(d => d.EvaluacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_alternativa_evaluacion_id");

                entity.HasOne(d => d.Pregunta)
                    .WithMany(p => p.Alternativas)
                    .HasForeignKey(d => d.PreguntaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_alternativa_pregunta_id");
            });

            modelBuilder.Entity<Bitacora>(entity =>
            {
                entity.ToTable("bitacora");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(3000)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.UsuarioId).HasColumnName("usuario_id");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Bitacoras)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_bitacora_usuario_id");
            });

            modelBuilder.Entity<ControlToken>(entity =>
            {
                entity.ToTable("control_token");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Token).HasColumnName("token");
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.ToTable("empresa");

                entity.HasIndex(e => e.RutEmpresa, "rut_empresa_unique")
                    .IsUnique();

                entity.HasIndex(e => e.RazonSocial, "un_empresa_razon_social")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Comuna)
                    .HasMaxLength(250)
                    .HasColumnName("comuna");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.RazonSocial)
                    .IsRequired()
                    .HasMaxLength(155)
                    .HasColumnName("razon_social");

                entity.Property(e => e.RutEmpresa)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("rut_empresa");

                entity.Property(e => e.TipoCantidadEmpleadoId).HasColumnName("tipo_cantidad_empleado_id");

                entity.Property(e => e.TipoNivelVentaId).HasColumnName("tipo_nivel_venta_id");

                entity.Property(e => e.TipoRubroId).HasColumnName("tipo_rubro_id");

                entity.Property(e => e.TipoSubRubroId).HasColumnName("tipo_sub_rubro_id");

                entity.Property(e => e.TipoTamanoEmpresaId).HasColumnName("tipo_tamano_empresa_id");

                entity.HasOne(d => d.TipoCantidadEmpleado)
                    .WithMany(p => p.Empresas)
                    .HasForeignKey(d => d.TipoCantidadEmpleadoId)
                    .HasConstraintName("fk_empresa_tipo_cantidad_empleado_id");

                entity.HasOne(d => d.TipoNivelVenta)
                    .WithMany(p => p.Empresas)
                    .HasForeignKey(d => d.TipoNivelVentaId)
                    .HasConstraintName("fk_empresa_tipo_nivel_venta_id");

                entity.HasOne(d => d.TipoRubro)
                    .WithMany(p => p.Empresas)
                    .HasForeignKey(d => d.TipoRubroId)
                    .HasConstraintName("fk_empresa_tipo_rubro_id");

                entity.HasOne(d => d.TipoSubRubro)
                    .WithMany(p => p.Empresas)
                    .HasForeignKey(d => d.TipoSubRubroId)
                    .HasConstraintName("fk_empresa_tipo_sub_rubro_id");

                entity.HasOne(d => d.TipoTamanoEmpresa)
                    .WithMany(p => p.Empresas)
                    .HasForeignKey(d => d.TipoTamanoEmpresaId)
                    .HasConstraintName("fk_empresa_tipo_tamano_empresa_id");
            });

            modelBuilder.Entity<Evaluacion>(entity =>
            {
                entity.ToTable("evaluacion");

                entity.HasIndex(e => e.Nombre, "un_evaluacion_razon_nombre")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("nombre");

                entity.Property(e => e.TiempoLimite)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("tiempo_limite");
            });

            modelBuilder.Entity<EvaluacionEmpresa>(entity =>
            {
                entity.ToTable("evaluacion_empresa");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.EmpresaId).HasColumnName("empresa_id");

                entity.Property(e => e.EvaluacionId).HasColumnName("evaluacion_id");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.FechaInicioTiempoLimite).HasColumnName("fecha_inicio_tiempo_limite");

                entity.HasOne(d => d.Empresa)
                    .WithMany(p => p.EvaluacionEmpresas)
                    .HasForeignKey(d => d.EmpresaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_evaluacion_empresa_empresa_id");

                entity.HasOne(d => d.Evaluacion)
                    .WithMany(p => p.EvaluacionEmpresas)
                    .HasForeignKey(d => d.EvaluacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_evaluacion_empresa_evaluacion_id");
            });

            modelBuilder.Entity<ImportanciaEstrategica>(entity =>
            {
                entity.ToTable("importancia_estrategica");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.ImportanciaRelativaId).HasColumnName("importancia_relativa_id");

                entity.Property(e => e.SegmentacionSubAreaId).HasColumnName("segmentacion_sub_area_id");

                entity.Property(e => e.Valor).HasColumnName("valor");

                entity.HasOne(d => d.ImportanciaRelativa)
                    .WithMany(p => p.ImportanciaEstrategicas)
                    .HasForeignKey(d => d.ImportanciaRelativaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_importancia_estrategica_id");

                entity.HasOne(d => d.SegmentacionSubArea)
                    .WithMany(p => p.ImportanciaEstrategicas)
                    .HasForeignKey(d => d.SegmentacionSubAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_importancia_estrategica_segmentacion_sub_area_id");
            });

            modelBuilder.Entity<ImportanciaRelativa>(entity =>
            {
                entity.ToTable("importancia_relativa");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.EvaluacionEmpresaId).HasColumnName("evaluacion_empresa_id");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.SegmentacionAreaId).HasColumnName("segmentacion_area_id");

                entity.Property(e => e.Valor).HasColumnName("valor");

                entity.HasOne(d => d.EvaluacionEmpresa)
                    .WithMany(p => p.ImportanciaRelativas)
                    .HasForeignKey(d => d.EvaluacionEmpresaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_importancia_relativa_evaluacion_empresa_id");

                entity.HasOne(d => d.SegmentacionArea)
                    .WithMany(p => p.ImportanciaRelativas)
                    .HasForeignKey(d => d.SegmentacionAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_importancia_relativa_segmentacion_area_id");
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

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("now()");

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

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("now()");

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

            modelBuilder.Entity<PlanMejora>(entity =>
            {
                entity.ToTable("plan_mejora");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.AlternativaId).HasColumnName("alternativa_id");

                entity.Property(e => e.EvaluacionId).HasColumnName("evaluacion_id");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Mejora)
                    .IsRequired()
                    .HasMaxLength(3000)
                    .HasColumnName("mejora");

                entity.Property(e => e.PreguntaId).HasColumnName("pregunta_id");

                entity.Property(e => e.SegmentacionAreaId).HasColumnName("segmentacion_area_id");

                entity.Property(e => e.SegmentacionSubAreaId).HasColumnName("segmentacion_sub_area_id");

                entity.Property(e => e.TipoDiferenciaRelacionadaId).HasColumnName("tipo_diferencia_relacionada_id");

                entity.Property(e => e.TipoImportanciaId).HasColumnName("tipo_importancia_id");

                entity.HasOne(d => d.Alternativa)
                    .WithMany(p => p.PlanMejoras)
                    .HasForeignKey(d => d.AlternativaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_plan_mejora_alternativa_id");

                entity.HasOne(d => d.Evaluacion)
                    .WithMany(p => p.PlanMejoras)
                    .HasForeignKey(d => d.EvaluacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_plan_mejora_evaluacion");

                entity.HasOne(d => d.SegmentacionArea)
                    .WithMany(p => p.PlanMejoras)
                    .HasForeignKey(d => d.SegmentacionAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_plan_mejora_segmentacion_area_id");

                entity.HasOne(d => d.SegmentacionSubArea)
                    .WithMany(p => p.PlanMejoras)
                    .HasForeignKey(d => d.SegmentacionSubAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_plan_mejora_segmentacion_sub_area_id");

                entity.HasOne(d => d.TipoDiferenciaRelacionada)
                    .WithMany(p => p.PlanMejoras)
                    .HasForeignKey(d => d.TipoDiferenciaRelacionadaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_plan_mejora_tipo_diferencia_relacionada_id");

                entity.HasOne(d => d.TipoImportancia)
                    .WithMany(p => p.PlanMejoras)
                    .HasForeignKey(d => d.TipoImportanciaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_plan_mejora_tipo_importancia_id");
            });

            modelBuilder.Entity<Pregunta>(entity =>
            {
                entity.ToTable("pregunta");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Capacidad)
                    .IsRequired()
                    .HasMaxLength(550)
                    .HasColumnName("capacidad");

                entity.Property(e => e.Detalle)
                    .IsRequired()
                    .HasMaxLength(1250)
                    .HasColumnName("detalle");

                entity.Property(e => e.EvaluacionId).HasColumnName("evaluacion_id");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Orden).HasColumnName("orden");

                entity.Property(e => e.SegmentacionAreaId).HasColumnName("segmentacion_area_id");

                entity.Property(e => e.SegmentacionSubAreaId).HasColumnName("segmentacion_sub_area_id");

                entity.HasOne(d => d.Evaluacion)
                    .WithMany(p => p.Pregunta)
                    .HasForeignKey(d => d.EvaluacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pregunta_evaluacion_id");

                entity.HasOne(d => d.SegmentacionArea)
                    .WithMany(p => p.Pregunta)
                    .HasForeignKey(d => d.SegmentacionAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pregunta_segmentacion_area_id");

                entity.HasOne(d => d.SegmentacionSubArea)
                    .WithMany(p => p.Pregunta)
                    .HasForeignKey(d => d.SegmentacionSubAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pregunta_segmentacion_sub_area_id");
            });

            modelBuilder.Entity<Reporte>(entity =>
            {
                entity.ToTable("reporte");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.EvaluacionId).HasColumnName("evaluacion_id");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.Evaluacion)
                    .WithMany(p => p.Reportes)
                    .HasForeignKey(d => d.EvaluacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_reporte_evaluacion_id");
            });

            modelBuilder.Entity<ReporteArea>(entity =>
            {
                entity.ToTable("reporte_area");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.ReporteId).HasColumnName("reporte_id");

                entity.Property(e => e.SegmentacionAreaId).HasColumnName("segmentacion_area_id");

                entity.HasOne(d => d.Reporte)
                    .WithMany(p => p.ReporteAreas)
                    .HasForeignKey(d => d.ReporteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_reporte_area_reporte_id");

                entity.HasOne(d => d.SegmentacionArea)
                    .WithMany(p => p.ReporteAreas)
                    .HasForeignKey(d => d.SegmentacionAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_reporte_segmentacion_area_id");
            });

            modelBuilder.Entity<ReporteItem>(entity =>
            {
                entity.ToTable("reporte_item");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.ReporteId).HasColumnName("reporte_id");

                entity.Property(e => e.TipoItemReporteId).HasColumnName("tipo_item_reporte_id");

                entity.HasOne(d => d.Reporte)
                    .WithMany(p => p.ReporteItems)
                    .HasForeignKey(d => d.ReporteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_reporte_item_reporte_id");

                entity.HasOne(d => d.TipoItemReporte)
                    .WithMany(p => p.ReporteItems)
                    .HasForeignKey(d => d.TipoItemReporteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_reporte_item_tipo_item_reporte_id");
            });

            modelBuilder.Entity<ReporteItemNivelBasico>(entity =>
            {
                entity.ToTable("reporte_item_nivel_basico");

                entity.Property(e => e.Id)
                   .HasColumnName("id")
                   .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Detalle)
                    .HasColumnType("character varying")
                    .HasColumnName("detalle");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.ReporteId).HasColumnName("reporte_id");

                entity.Property(e => e.Orden).HasColumnName("orden");

                entity.HasOne(d => d.Reporte)
                    .WithMany(p => p.ReporteItemNivelBasicos)
                    .HasForeignKey(d => d.ReporteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_reporte_item_nivel_basico");
            });

            modelBuilder.Entity<ReporteItemNivelSubscripcion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("reporte_item_nivel_subscripcion");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Detalle)
                    .HasColumnType("character varying")
                    .HasColumnName("detalle");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Orden).HasColumnName("orden");

                entity.Property(e => e.ReporteId).HasColumnName("reporte_id");

                entity.HasOne(d => d.Reporte)
                    .WithMany()
                    .HasForeignKey(d => d.ReporteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_reporte_item_nivel_subscripcion");
            });

            modelBuilder.Entity<Respuesta>(entity =>
            {
                entity.ToTable("respuesta");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.AlternativaId).HasColumnName("alternativa_id");

                entity.Property(e => e.EvaluacionEmpresaId).HasColumnName("evaluacion_empresa_id");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.PreguntaId).HasColumnName("pregunta_id");

                entity.Property(e => e.Realimentacion)
                    .IsRequired()
                    .HasMaxLength(1250)
                    .HasColumnName("realimentacion");

                entity.Property(e => e.TipoDiferenciaRelacionadaId).HasColumnName("tipo_diferencia_relacionada_id");

                entity.Property(e => e.TipoImportanciaId).HasColumnName("tipo_importancia_id");

                entity.Property(e => e.UsuarioId).HasColumnName("usuario_id");

                entity.Property(e => e.Valor).HasColumnName("valor");

                entity.HasOne(d => d.Alternativa)
                    .WithMany(p => p.Respuesta)
                    .HasForeignKey(d => d.AlternativaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_respuesta_alternativa_id");

                entity.HasOne(d => d.EvaluacionEmpresa)
                    .WithMany(p => p.Respuesta)
                    .HasForeignKey(d => d.EvaluacionEmpresaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_respuesta_evaluacion_empresa_id");

                entity.HasOne(d => d.Pregunta)
                    .WithMany(p => p.Respuesta)
                    .HasForeignKey(d => d.PreguntaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_respuesta_pregunta_id");

                entity.HasOne(d => d.TipoImportancia)
                    .WithMany(p => p.Respuesta)
                    .HasForeignKey(d => d.TipoImportanciaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_respuesta_tipo_importancia_id");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Respuesta)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_respuesta_usuario_id");
            });

            modelBuilder.Entity<SegmentacionArea>(entity =>
            {
                entity.ToTable("segmentacion_area");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.EvaluacionId).HasColumnName("evaluacion_id");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.NombreArea)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("nombre_area");

                entity.HasOne(d => d.Evaluacion)
                    .WithMany(p => p.SegmentacionAreas)
                    .HasForeignKey(d => d.EvaluacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_segmentacion_area_evaluacion_id");
            });

            modelBuilder.Entity<SegmentacionSubArea>(entity =>
            {
                entity.ToTable("segmentacion_sub_area");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.NombreSubArea)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("nombre_sub_area");

                entity.Property(e => e.SegmentacionAreaId).HasColumnName("segmentacion_area_id");

                entity.HasOne(d => d.SegmentacionArea)
                    .WithMany(p => p.SegmentacionSubAreas)
                    .HasForeignKey(d => d.SegmentacionAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_segmentacion_sub_area_segmentacion_area_id");
            });

            modelBuilder.Entity<Seguimiento>(entity =>
            {
                entity.ToTable("seguimiento");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.EmpresaId).HasColumnName("empresa_id");

                entity.Property(e => e.EvaluacionId).HasColumnName("evaluacion_id");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.FechaUltimoAcceso).HasColumnName("fecha_ultimo_acceso");

                entity.Property(e => e.Madurez).HasColumnName("madurez");

                entity.Property(e => e.PlanMejoraId).HasColumnName("plan_mejora_id");

                entity.Property(e => e.PorcentajePlanMejora).HasColumnName("porcentaje_plan_mejora");

                entity.Property(e => e.PorcentajeRespuestas).HasColumnName("porcentaje_respuestas");

                entity.HasOne(d => d.Empresa)
                    .WithMany(p => p.Seguimientos)
                    .HasForeignKey(d => d.EmpresaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_seguimiento_empresa_id");

                entity.HasOne(d => d.Evaluacion)
                    .WithMany(p => p.Seguimientos)
                    .HasForeignKey(d => d.EvaluacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_seguimiento_evaluacion_id");

                entity.HasOne(d => d.PlanMejora)
                    .WithMany(p => p.Seguimientos)
                    .HasForeignKey(d => d.PlanMejoraId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_seguimiento_plan_mejora_id");
            });

            modelBuilder.Entity<TipoCantidadEmpleado>(entity =>
            {
                entity.ToTable("tipo_cantidad_empleado");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(1250)
                    .HasColumnName("detalle");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<TipoDiferenciaRelacionada>(entity =>
            {
                entity.ToTable("tipo_diferencia_relacionada");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(1250)
                    .HasColumnName("detalle");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<TipoImportancia>(entity =>
            {
                entity.ToTable("tipo_importancia");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(1250)
                    .HasColumnName("detalle");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<TipoItemReporte>(entity =>
            {
                entity.ToTable("tipo_item_reporte");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(1250)
                    .HasColumnName("detalle");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("nombre");

                entity.Property(e => e.Orden).HasColumnName("orden");
            });

            modelBuilder.Entity<TipoNivelVenta>(entity =>
            {
                entity.ToTable("tipo_nivel_venta");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(1250)
                    .HasColumnName("detalle");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<TipoRubro>(entity =>
            {
                entity.ToTable("tipo_rubro");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(1250)
                    .HasColumnName("detalle");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<TipoSubRubro>(entity =>
            {
                entity.ToTable("tipo_sub_rubro");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(1250)
                    .HasColumnName("detalle");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("nombre");

                entity.Property(e => e.TipoRubroId).HasColumnName("tipo_rubro_id");

                entity.HasOne(d => d.TipoRubro)
                    .WithMany(p => p.TipoSubRubros)
                    .HasForeignKey(d => d.TipoRubroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tipo_sub_rubro_tipo_rubro_id");
            });

            modelBuilder.Entity<TipoTamanoEmpresa>(entity =>
            {
                entity.ToTable("tipo_tamano_empresa");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(1250)
                    .HasColumnName("detalle");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("usuario");

                entity.HasIndex(e => e.Email, "un_usuario_email")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.EmpresaId).HasColumnName("empresa_id");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.FechaUltimoAcceso).HasColumnName("fecha_ultimo_acceso");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("nombres");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("password");

                entity.Property(e => e.PerfilId).HasColumnName("perfil_id");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(255)
                    .HasColumnName("telefono");

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

            modelBuilder.Entity<UsuarioArea>(entity =>
            {
                entity.ToTable("usuario_area");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.SegmentacionAreaId).HasColumnName("segmentacion_area_id");

                entity.Property(e => e.UsuarioEvaluacionId).HasColumnName("usuario_evaluacion_id");

                entity.HasOne(d => d.SegmentacionArea)
                    .WithMany(p => p.UsuarioAreas)
                    .HasForeignKey(d => d.SegmentacionAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuario_area_segmentacion_area_id");

                entity.HasOne(d => d.UsuarioEvaluacion)
                    .WithMany(p => p.UsuarioAreas)
                    .HasForeignKey(d => d.UsuarioEvaluacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuario_area_usuario_evaluacion_id");
            });

            modelBuilder.Entity<UsuarioEmpresa>(entity =>
            {
                entity.ToTable("usuario_empresa");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.EmpresaId).HasColumnName("empresa_id");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("now()");

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
                    .HasConstraintName("fk_usuario_empresa_usuario_id");
            });

            modelBuilder.Entity<UsuarioEvaluacion>(entity =>
            {
                entity.ToTable("usuario_evaluacion");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.EmpresaId).HasColumnName("empresa_id");

                entity.Property(e => e.EvaluacionId).HasColumnName("evaluacion_id");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.UsuarioId).HasColumnName("usuario_id");

                entity.HasOne(d => d.Empresa)
                    .WithMany(p => p.UsuarioEvaluacions)
                    .HasForeignKey(d => d.EmpresaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuario_evaluacion_empresa_id");

                entity.HasOne(d => d.Evaluacion)
                    .WithMany(p => p.UsuarioEvaluacions)
                    .HasForeignKey(d => d.EvaluacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuario_evaluacion_evaluacion_id");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.UsuarioEvaluacions)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuario_evaluacion_usuario_id");
            });

            modelBuilder.Entity<UsuarioSuscripcion>(entity =>
            {
                entity.ToTable("usuario_suscripcion");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.FechaExpiracion).HasColumnName("fecha_expiracion");

                entity.Property(e => e.TiempoSuscripcion).HasColumnName("tiempo_suscripcion");

                entity.Property(e => e.UsuarioId).HasColumnName("usuario_id");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.UsuarioSuscripcions)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuario_empresa_usuario_id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
