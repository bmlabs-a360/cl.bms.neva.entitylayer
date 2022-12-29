using System;
using System.Collections.Generic;

namespace neva.entities;

public partial class TipoItemReporte
{
    public Guid Id { get; set; }

    public int Orden { get; set; }

    public string Nombre { get; set; }

    public string Detalle { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public virtual ICollection<ReporteItem> ReporteItems { get; } = new List<ReporteItem>();
}
