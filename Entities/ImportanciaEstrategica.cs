using System;
using System.Collections.Generic;

#nullable disable

namespace neva.entities
{
    public partial class ImportanciaEstrategica
    {
        public Guid Id { get; set; }
        public Guid ImportanciaRelativaId { get; set; }
        public Guid SegmentacionSubAreaId { get; set; }
        public int Valor { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public bool? Activo { get; set; }

        public virtual ImportanciaRelativa ImportanciaRelativa { get; set; }
        public virtual SegmentacionSubArea SegmentacionSubArea { get; set; }
    }
}
