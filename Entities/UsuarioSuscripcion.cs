using System;
using System.Collections.Generic;

namespace neva.entities;

public partial class UsuarioSuscripcion
{
    public Guid Id { get; set; }

    public Guid UsuarioId { get; set; }

    public DateTime FechaExpiracion { get; set; }

    public DateTime TiempoSuscripcion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public bool? Activo { get; set; }

    public virtual Usuario Usuario { get; set; }
}
