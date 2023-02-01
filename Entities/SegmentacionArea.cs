using System;
using System.Collections.Generic;

#nullable disable

namespace neva.entities
{
    public partial class SegmentacionArea
    {
        public SegmentacionArea()
        {
            ImportanciaRelativas = new HashSet<ImportanciaRelativa>();
            PlanMejoras = new HashSet<PlanMejora>();
            Pregunta = new HashSet<Pregunta>();
            ReporteAreas = new HashSet<ReporteArea>();
            SegmentacionSubAreas = new HashSet<SegmentacionSubArea>();
            UsuarioAreas = new HashSet<UsuarioArea>();
            ReporteRecomendacionAreas = new HashSet<ReporteRecomendacionArea>();
        }

        public Guid Id { get; set; }
        public Guid EvaluacionId { get; set; }
        public string NombreArea { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public bool? Activo { get; set; }

        public virtual Evaluacion Evaluacion { get; set; }
        public virtual ICollection<ImportanciaRelativa> ImportanciaRelativas { get; set; }
        public virtual ICollection<PlanMejora> PlanMejoras { get; set; }
        public virtual ICollection<Pregunta> Pregunta { get; set; }
        public virtual ICollection<ReporteArea> ReporteAreas { get; set; }
        public virtual ICollection<SegmentacionSubArea> SegmentacionSubAreas { get; set; }
        public virtual ICollection<UsuarioArea> UsuarioAreas { get; set; }
        public virtual ICollection<ReporteRecomendacionArea> ReporteRecomendacionAreas { get; set; }
    }
}
