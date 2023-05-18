using System;
using System.Collections.Generic;

#nullable disable

namespace neva.entities
{
    public partial class Usuario
    {
        public Usuario()
        {
            Respuesta = new HashSet<Respuesta>();
            UsuarioEmpresas = new HashSet<UsuarioEmpresa>();
            UsuarioEvaluacions = new HashSet<UsuarioEvaluacion>();
            UsuarioSuscripcions = new HashSet<UsuarioSuscripcion>();
        }

        public Guid Id { get; set; }
        public Guid PerfilId { get; set; }
        public Guid EmpresaId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Nombres { get; set; }
        public string Telefono { get; set; }
        public DateTime? FechaUltimoAcceso { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public bool? Activo { get; set; }
        public bool? EmailVerificado { get; set; }

        public virtual Empresa Empresa { get; set; }
        public virtual Perfil Perfil { get; set; }
        public virtual ICollection<Respuesta> Respuesta { get; set; }
        public virtual ICollection<UsuarioEmpresa> UsuarioEmpresas { get; set; }
        public virtual ICollection<UsuarioEvaluacion> UsuarioEvaluacions { get; set; }
        public virtual ICollection<UsuarioSuscripcion> UsuarioSuscripcions { get; set; }
    }
}
