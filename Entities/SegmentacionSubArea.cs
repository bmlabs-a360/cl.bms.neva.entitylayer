﻿using System;
using System.Collections.Generic;

namespace neva.entities;

public partial class SegmentacionSubArea
{
    public Guid Id { get; set; }

    public Guid SegmentacionAreaId { get; set; }

    public string NombreSubArea { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<ImportanciaEstrategica> ImportanciaEstrategicas { get; } = new List<ImportanciaEstrategica>();

    public virtual ICollection<PlanMejora> PlanMejoras { get; } = new List<PlanMejora>();

    public virtual ICollection<Pregunta> Pregunta { get; } = new List<Pregunta>();

    public virtual SegmentacionArea SegmentacionArea { get; set; }
}
