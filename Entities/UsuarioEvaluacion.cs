using System;
using System.Collections.Generic;

namespace neva.entities;

public partial class UsuarioEvaluacion
{
    public Guid Id { get; set; }

    public Guid UsuarioId { get; set; }

    public Guid EmpresaId { get; set; }

    public Guid EvaluacionId { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public bool? Activo { get; set; }

    public virtual Empresa Empresa { get; set; }

    public virtual Evaluacion Evaluacion { get; set; }

    public virtual Usuario Usuario { get; set; }

    public virtual ICollection<UsuarioArea> UsuarioAreas { get; } = new List<UsuarioArea>();
}
