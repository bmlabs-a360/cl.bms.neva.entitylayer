﻿using System;
using System.Collections.Generic;

#nullable disable

namespace neva.entities
{
    public partial class TipoCantidadEmpleado
    {
        public TipoCantidadEmpleado()
        {
            Empresas = new HashSet<Empresa>();
        }

        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Detalle { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public bool? Activo { get; set; }

        public virtual ICollection<Empresa> Empresas { get; set; }
    }
}
