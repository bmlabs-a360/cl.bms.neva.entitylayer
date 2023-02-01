using System;
using System.Collections.Generic;

#nullable disable

namespace neva.entities
{
    public partial class Reporte
    {
        public Reporte()
        {
            ReporteAreas = new HashSet<ReporteArea>();
            ReporteItemNivelBasicos = new HashSet<ReporteItemNivelBasico>();
            ReporteItems = new HashSet<ReporteItem>();
            ReporteRecomendacionAreas = new HashSet<ReporteRecomendacionArea>();
        }

        public Guid Id { get; set; }
        public Guid EvaluacionId { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public bool? Activo { get; set; }

        public virtual Evaluacion Evaluacion { get; set; }
        public virtual ICollection<ReporteArea> ReporteAreas { get; set; }
        public virtual ICollection<ReporteItemNivelBasico> ReporteItemNivelBasicos { get; set; }
        public virtual ICollection<ReporteItem> ReporteItems { get; set; }
        public virtual ICollection<ReporteRecomendacionArea> ReporteRecomendacionAreas { get; set; }
    }
}
