using System;
using System.Collections.Generic;

namespace neva.entities;

public partial class Evaluacion
{
    public Guid Id { get; set; }

    public string Nombre { get; set; }

    public string TiempoLimite { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<Alternativa> Alternativas { get; } = new List<Alternativa>();

    public virtual ICollection<EvaluacionEmpresa> EvaluacionEmpresas { get; } = new List<EvaluacionEmpresa>();

    public virtual PlanMejora PlanMejora { get; set; }

    public virtual ICollection<Pregunta> Pregunta { get; } = new List<Pregunta>();

    public virtual ICollection<Reporte> Reportes { get; } = new List<Reporte>();

    public virtual ICollection<SegmentacionArea> SegmentacionAreas { get; } = new List<SegmentacionArea>();

    public virtual ICollection<Seguimiento> Seguimientos { get; } = new List<Seguimiento>();

    public virtual ICollection<UsuarioEvaluacion> UsuarioEvaluacions { get; } = new List<UsuarioEvaluacion>();
}
