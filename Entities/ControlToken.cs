using System;
using System.Collections.Generic;

#nullable disable

namespace neva.entities
{
    public partial class ControlToken
    {
        public Guid Id { get; set; }
        public string Token { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
