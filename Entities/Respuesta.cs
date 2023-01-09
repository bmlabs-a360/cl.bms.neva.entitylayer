using System;
using System.Collections.Generic;

namespace neva.entities;

public partial class Respuesta
{
    public Guid Id { get; set; }

    public Guid AlternativaId { get; set; }

    public Guid PreguntaId { get; set; }

    public Guid EvaluacionEmpresaId { get; set; }

    public Guid TipoImportanciaId { get; set; }

    public Guid? TipoDiferenciaRelacionadaId { get; set; }

    public int Valor { get; set; }

    public string Realimentacion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public bool? Activo { get; set; }

    public Guid UsuarioId { get; set; }

    public virtual Alternativa Alternativa { get; set; }

    public virtual EvaluacionEmpresa EvaluacionEmpresa { get; set; }

    public virtual Pregunta Pregunta { get; set; }

    public virtual TipoImportancia TipoImportancia { get; set; }

    public virtual Usuario Usuario { get; set; }
}
