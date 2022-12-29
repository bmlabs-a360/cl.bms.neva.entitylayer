using System;
using System.Collections.Generic;

namespace neva.entities;

public partial class EvaluacionEmpresa
{
    public Guid Id { get; set; }

    public Guid EvaluacionId { get; set; }

    public Guid EmpresaId { get; set; }

    public DateTime FechaInicioTiempoLimite { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public bool? Activo { get; set; }

    public virtual Empresa Empresa { get; set; }

    public virtual Evaluacion Evaluacion { get; set; }

    public virtual ICollection<ImportanciaRelativa> ImportanciaRelativas { get; } = new List<ImportanciaRelativa>();

    public virtual ICollection<Respuesta> Respuesta { get; } = new List<Respuesta>();
}
