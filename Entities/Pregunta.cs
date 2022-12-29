using System;
using System.Collections.Generic;

namespace neva.entities;

public partial class Pregunta
{
    public Guid Id { get; set; }

    public Guid EvaluacionId { get; set; }

    public Guid SegmentacionAreaId { get; set; }

    public Guid SegmentacionSubAreaId { get; set; }

    public string Detalle { get; set; }

    public int Orden { get; set; }

    public string Capacidad { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<Alternativa> Alternativas { get; } = new List<Alternativa>();

    public virtual Evaluacion Evaluacion { get; set; }

    public virtual ICollection<Respuesta> Respuesta { get; } = new List<Respuesta>();

    public virtual SegmentacionArea SegmentacionArea { get; set; }

    public virtual SegmentacionSubArea SegmentacionSubArea { get; set; }
}
