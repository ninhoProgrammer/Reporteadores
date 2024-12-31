using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class VAccarbol
{
    public int AaSource { get; set; }

    public int? AxNumero { get; set; }

    public string? AaDescrip { get; set; }

    public int? AaVersion { get; set; }

    public decimal? AaPosicio { get; set; }

    public int AaModulo { get; set; }

    public int AaScreen { get; set; }

    public string CmControl { get; set; } = null!;
}
