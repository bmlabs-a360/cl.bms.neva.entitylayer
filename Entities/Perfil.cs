using System;
using System.Collections.Generic;

namespace neva.entities;

public partial class Perfil
{
    public Guid Id { get; set; }

    public string Nombre { get; set; }

    public string Detalle { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<PerfilPermiso> PerfilPermisos { get; } = new List<PerfilPermiso>();

    public virtual ICollection<Usuario> Usuarios { get; } = new List<Usuario>();
}
