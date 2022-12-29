﻿using System;
using System.Collections.Generic;

namespace neva.entities;

public partial class ImportanciaRelativa
{
    public Guid Id { get; set; }

    public Guid EvaluacionEmpresaId { get; set; }

    public Guid SegmentacionAreaId { get; set; }

    public int Valor { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public bool? Activo { get; set; }

    public virtual EvaluacionEmpresa EvaluacionEmpresa { get; set; }

    public virtual ICollection<ImportanciaEstrategica> ImportanciaEstrategicas { get; } = new List<ImportanciaEstrategica>();

    public virtual SegmentacionArea SegmentacionArea { get; set; }
}
