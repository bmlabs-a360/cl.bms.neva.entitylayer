using System;
using System.Collections.Generic;

#nullable disable

namespace neva.entities
{
    public partial class Bitacora
    {
        public Guid Id { get; set; }
        public Guid UsuarioId { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
    }
}
