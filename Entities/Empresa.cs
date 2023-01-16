using System;
using System.Collections.Generic;

#nullable disable

namespace neva.entities
{
    public partial class Empresa
    {
        public Empresa()
        {
            EvaluacionEmpresas = new HashSet<EvaluacionEmpresa>();
            UsuarioEmpresas = new HashSet<UsuarioEmpresa>();
            UsuarioEvaluacions = new HashSet<UsuarioEvaluacion>();
            Usuarios = new HashSet<Usuario>();
        }

        public Guid Id { get; set; }
        public string RazonSocial { get; set; }
        public string RutEmpresa { get; set; }
        public string Comuna { get; set; }
        public Guid? TipoRubroId { get; set; }
        public Guid? TipoSubRubroId { get; set; }
        public Guid? TipoTamanoEmpresaId { get; set; }
        public Guid? TipoNivelVentaId { get; set; }
        public Guid? TipoCantidadEmpleadoId { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public bool? Activo { get; set; }

        public virtual TipoCantidadEmpleado TipoCantidadEmpleado { get; set; }
        public virtual TipoNivelVenta TipoNivelVenta { get; set; }
        public virtual TipoRubro TipoRubro { get; set; }
        public virtual TipoSubRubro TipoSubRubro { get; set; }
        public virtual TipoTamanoEmpresa TipoTamanoEmpresa { get; set; }
        public virtual ICollection<EvaluacionEmpresa> EvaluacionEmpresas { get; set; }
        public virtual ICollection<UsuarioEmpresa> UsuarioEmpresas { get; set; }
        public virtual ICollection<UsuarioEvaluacion> UsuarioEvaluacions { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
