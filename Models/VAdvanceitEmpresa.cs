using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class VAdvanceitEmpresa
{
    public string IdEmpresa { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? Identificacion { get; set; }

    public string Pais { get; set; } = null!;

    public string? Periodos { get; set; }

    public string Correo { get; set; } = null!;
}
