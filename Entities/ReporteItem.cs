using System;
using System.Collections.Generic;

namespace neva.entities;

public partial class ReporteItem
{
    public Guid Id { get; set; }

    public Guid ReporteId { get; set; }

    public Guid TipoItemReporteId { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public bool? Activo { get; set; }

    public virtual Reporte Reporte { get; set; }

    public virtual TipoItemReporte TipoItemReporte { get; set; }
}
