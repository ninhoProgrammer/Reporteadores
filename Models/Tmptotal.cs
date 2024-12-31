using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Tmptotal
{
    public short UsCodigo { get; set; }

    public short CoNumero { get; set; }

    public string Grupo1 { get; set; } = null!;

    public string Grupo2 { get; set; } = null!;

    public string Grupo3 { get; set; } = null!;

    public string Grupo4 { get; set; } = null!;

    public string Grupo5 { get; set; } = null!;

    public decimal TotMonto { get; set; }

    public int TotNumero { get; set; }
}
