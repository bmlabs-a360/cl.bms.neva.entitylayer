using System;
using System.Collections.Generic;

#nullable disable

namespace neva.entities
{
    public partial class ReporteArea
    {
        public Guid Id { get; set; }
        public Guid ReporteId { get; set; }
        public Guid SegmentacionAreaId { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public bool? Activo { get; set; }

        public virtual Reporte Reporte { get; set; }
        public virtual SegmentacionArea SegmentacionArea { get; set; }
    }
}
