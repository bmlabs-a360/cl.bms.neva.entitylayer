using System;
using System.Collections.Generic;

#nullable disable

namespace neva.entities
{
    public partial class Empresa
    {
        public Empresa()
        {
            UsuarioEmpresas = new HashSet<UsuarioEmpresa>();
            Usuarios = new HashSet<Usuario>();
        }

        public Guid Id { get; set; }
        public string RazonSocial { get; set; }
        public string Rubro { get; set; }
        public string SubRubro { get; set; }
        public string Comuna { get; set; }
        public string TamañoEmpresa { get; set; }
        public string NivelVenta { get; set; }
        public string CantidadEmpleados { get; set; }
        public string RutEmpresa { get; set; }
        public bool? Activo { get; set; }

        public virtual ICollection<UsuarioEmpresa> UsuarioEmpresas { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
