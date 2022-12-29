using System;
using System.Collections.Generic;

namespace neva.entities;

public partial class Reporte
{
    public Guid Id { get; set; }

    public Guid EvaluacionId { get; set; }

    public string Nombre { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public bool? Activo { get; set; }

    public virtual Evaluacion Evaluacion { get; set; }

    public virtual ICollection<ReporteArea> ReporteAreas { get; } = new List<ReporteArea>();

    public virtual ICollection<ReporteItem> ReporteItems { get; } = new List<ReporteItem>();
}
