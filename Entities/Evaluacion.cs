﻿using System;
using System.Collections.Generic;

#nullable disable

namespace neva.entities
{
    public partial class Evaluacion
    {
        public Evaluacion()
        {
            Alternativas = new HashSet<Alternativa>();
            EvaluacionEmpresas = new HashSet<EvaluacionEmpresa>();
            Pregunta = new HashSet<Pregunta>();
            Reportes = new HashSet<Reporte>();
            SegmentacionAreas = new HashSet<SegmentacionArea>();
            UsuarioEvaluacions = new HashSet<UsuarioEvaluacion>();
        }

        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string TiempoLimite { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public bool? Activo { get; set; }

        public virtual ICollection<Alternativa> Alternativas { get; set; }
        public virtual ICollection<EvaluacionEmpresa> EvaluacionEmpresas { get; set; }
        public virtual ICollection<Pregunta> Pregunta { get; set; }
        public virtual ICollection<Reporte> Reportes { get; set; }
        public virtual ICollection<SegmentacionArea> SegmentacionAreas { get; set; }
        public virtual ICollection<UsuarioEvaluacion> UsuarioEvaluacions { get; set; }
    }
}
