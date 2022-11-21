using System;
using System.Collections.Generic;

#nullable disable

namespace neva.entities
{
    public partial class Usuario
    {
        public Usuario()
        {
            UsuarioEmpresas = new HashSet<UsuarioEmpresa>();
        }

        public Guid Id { get; set; }
        public Guid PerfilId { get; set; }
        public Guid EmpresaId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Rut { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaUltimoacceso { get; set; }
        public bool? Activo { get; set; }

        public virtual Empresa Empresa { get; set; }
        public virtual Perfil Perfil { get; set; }
        public virtual ICollection<UsuarioEmpresa> UsuarioEmpresas { get; set; }
    }
}
