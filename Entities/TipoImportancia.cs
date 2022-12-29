using System;
using System.Collections.Generic;

namespace neva.entities;

public partial class TipoImportancia
{
    public Guid Id { get; set; }

    public string Nombre { get; set; }

    public string Detalle { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public virtual ICollection<PlanMejora> PlanMejoras { get; } = new List<PlanMejora>();

    public virtual ICollection<Respuesta> Respuesta { get; } = new List<Respuesta>();
}
