using System;
using System.Collections.Generic;

namespace neva.entities;

public partial class PlanMejora
{
    public Guid Id { get; set; }

    public Guid PreguntaId { get; set; }

    public Guid SegmentacionAreaId { get; set; }

    public Guid SegmentacionSubAreaId { get; set; }

    public Guid AlternativaId { get; set; }

    public Guid TipoImportanciaId { get; set; }

    public Guid TipoDiferenciaRelacionadaId { get; set; }

    public string Mejora { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public bool? Activo { get; set; }

    public virtual Alternativa Alternativa { get; set; }

    public virtual SegmentacionArea SegmentacionArea { get; set; }

    public virtual SegmentacionSubArea SegmentacionSubArea { get; set; }

    public virtual ICollection<Seguimiento> Seguimientos { get; } = new List<Seguimiento>();

    public virtual TipoDiferenciaRelacionada TipoDiferenciaRelacionada { get; set; }

    public virtual TipoImportancia TipoImportancia { get; set; }
}
