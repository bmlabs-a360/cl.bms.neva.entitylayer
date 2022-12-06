using System;
using System.Collections.Generic;

#nullable disable

namespace neva.entities
{
    public partial class Seguimiento
    {
        public Guid Id { get; set; }
        public Guid EmpresaId { get; set; }
        public Guid EvaluacionId { get; set; }
        public Guid PlanMejoraId { get; set; }
        public int Madurez { get; set; }
        public int PorcentajeRespuestas { get; set; }
        public int PorcentajePlanMejora { get; set; }
        public DateTime FechaUltimoAcceso { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public bool? Activo { get; set; }

        public virtual Empresa Empresa { get; set; }
        public virtual Evaluacion Evaluacion { get; set; }
        public virtual PlanMejora PlanMejora { get; set; }
    }
}
