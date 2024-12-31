using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class VAccAd
{
    public int AaSource { get; set; }

    public int? AxNumero { get; set; }

    public int AdTipo { get; set; }

    public string AdAccion { get; set; } = null!;

    public int AdImpacto { get; set; }

    public int AdPosicio { get; set; }
}
