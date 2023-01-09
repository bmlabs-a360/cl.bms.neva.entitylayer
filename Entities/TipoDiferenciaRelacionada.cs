using System;
using System.Collections.Generic;

namespace neva.entities;

public partial class TipoDiferenciaRelacionada
{
    public Guid Id { get; set; }

    public string Nombre { get; set; }

    public string Detalle { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<PlanMejora> PlanMejoras { get; } = new List<PlanMejora>();
}
