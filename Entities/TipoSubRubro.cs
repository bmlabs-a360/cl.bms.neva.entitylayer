using System;
using System.Collections.Generic;

namespace neva.entities;

public partial class TipoSubRubro
{
    public Guid Id { get; set; }

    public Guid TipoRubroId { get; set; }

    public string Nombre { get; set; }

    public string Detalle { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<Empresa> Empresas { get; } = new List<Empresa>();

    public virtual TipoRubro TipoRubro { get; set; }
}
