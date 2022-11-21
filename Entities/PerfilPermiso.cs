using System;
using System.Collections.Generic;

#nullable disable

namespace neva.entities
{
    public partial class PerfilPermiso
    {
        public Guid Id { get; set; }
        public Guid PerfilId { get; set; }
        public string Nombre { get; set; }
        public string Detalle { get; set; }
        public bool? Activo { get; set; }

        public virtual Perfil Perfil { get; set; }
    }
}
