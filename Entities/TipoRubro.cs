using System;
using System.Collections.Generic;

#nullable disable

namespace neva.entities
{
    public partial class TipoRubro
    {
        public TipoRubro()
        {
            Empresas = new HashSet<Empresa>();
            TipoSubRubros = new HashSet<TipoSubRubro>();
        }

        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Detalle { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public bool? Activo { get; set; }

        public virtual ICollection<Empresa> Empresas { get; set; }
        public virtual ICollection<TipoSubRubro> TipoSubRubros { get; set; }
    }
}
