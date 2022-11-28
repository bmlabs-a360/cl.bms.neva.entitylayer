using System;
using System.Collections.Generic;

#nullable disable

namespace neva.entities
{
    public partial class TipoItemReporte
    {
        public TipoItemReporte()
        {
            ReporteItems = new HashSet<ReporteItem>();
        }

        public Guid Id { get; set; }
        public int Orden { get; set; }
        public string Nombre { get; set; }
        public string Detalle { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaCreacion { get; set; }

        public virtual ICollection<ReporteItem> ReporteItems { get; set; }
    }
}
