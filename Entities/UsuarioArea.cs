using System;
using System.Collections.Generic;

namespace neva.entities;

public partial class UsuarioArea
{
    public Guid Id { get; set; }

    public Guid UsuarioEvaluacionId { get; set; }

    public Guid SegmentacionAreaId { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public bool? Activo { get; set; }

    public virtual SegmentacionArea SegmentacionArea { get; set; }

    public virtual UsuarioEvaluacion UsuarioEvaluacion { get; set; }
}
