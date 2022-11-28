using System;
using System.Collections.Generic;

#nullable disable

namespace neva.entities
{
    public partial class Perfil
    {
        public Perfil()
        {
            PerfilPermisos = new HashSet<PerfilPermiso>();
            Usuarios = new HashSet<Usuario>();
        }

        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Detalle { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public bool? Activo { get; set; }

        public virtual ICollection<PerfilPermiso> PerfilPermisos { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
