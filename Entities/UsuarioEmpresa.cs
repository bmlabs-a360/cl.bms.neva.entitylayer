using System;
using System.Collections.Generic;

#nullable disable

namespace neva.entities
{
    public partial class UsuarioEmpresa
    {
        public Guid Id { get; set; }
        public Guid UsuarioId { get; set; }
        public Guid EmpresaId { get; set; }

        public virtual Empresa Empresa { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
