using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class VPoll
{
    public string PoLinx { get; set; } = null!;

    public string PoEmpresa { get; set; } = null!;

    public int PoNumero { get; set; }

    public DateTime PoFecha { get; set; }

    public string PoHora { get; set; } = null!;

    public string PoLetra { get; set; } = null!;
}
