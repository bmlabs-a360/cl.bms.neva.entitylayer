using System;
using System.Collections.Generic;

#nullable disable

namespace neva.entities
{
    public partial class ReporteItemNivelBasico
    {
        public Guid Id { get; set; }
        public Guid ReporteId { get; set; }
        public string? Detalle { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int Orden { get; set; }
        public bool? Activo { get; set; }

        public virtual Reporte Reporte { get; set; }
    }
}

