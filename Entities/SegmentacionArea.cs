using System;
using System.Collections.Generic;

namespace neva.entities;

public partial class SegmentacionArea
{
    public Guid Id { get; set; }

    public Guid EvaluacionId { get; set; }

    public string NombreArea { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public bool? Activo { get; set; }

    public virtual Evaluacion Evaluacion { get; set; }

    public virtual ICollection<ImportanciaRelativa> ImportanciaRelativas { get; } = new List<ImportanciaRelativa>();

    public virtual ICollection<PlanMejora> PlanMejoras { get; } = new List<PlanMejora>();

    public virtual ICollection<Pregunta> Pregunta { get; } = new List<Pregunta>();

    public virtual ICollection<ReporteArea> ReporteAreas { get; } = new List<ReporteArea>();

    public virtual ICollection<SegmentacionSubArea> SegmentacionSubAreas { get; } = new List<SegmentacionSubArea>();

    public virtual ICollection<UsuarioArea> UsuarioAreas { get; } = new List<UsuarioArea>();
}
