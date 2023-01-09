using System;
using System.Collections.Generic;

namespace neva.entities;

public partial class Usuario
{
    public Guid Id { get; set; }

    public Guid PerfilId { get; set; }

    public Guid EmpresaId { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public string Nombres { get; set; }

    public string Telefono { get; set; }

    public DateTime? FechaUltimoAcceso { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<Bitacora> Bitacoras { get; } = new List<Bitacora>();

    public virtual Empresa Empresa { get; set; }

    public virtual Perfil Perfil { get; set; }

    public virtual ICollection<Respuesta> Respuesta { get; } = new List<Respuesta>();

    public virtual ICollection<UsuarioEmpresa> UsuarioEmpresas { get; } = new List<UsuarioEmpresa>();

    public virtual ICollection<UsuarioEvaluacion> UsuarioEvaluacions { get; } = new List<UsuarioEvaluacion>();

    public virtual ICollection<UsuarioSuscripcion> UsuarioSuscripcions { get; } = new List<UsuarioSuscripcion>();
}
