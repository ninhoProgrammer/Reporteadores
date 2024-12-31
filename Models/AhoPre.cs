using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class AhoPre
{
    public int CbCodigo { get; set; }

    public DateTime Fecha { get; set; }

    public short? Prioridad { get; set; }

    public int? Tipo { get; set; }

    public string PrTipo { get; set; } = null!;

    public string? PrReferen { get; set; }

    public decimal? PrMonto { get; set; }

    public decimal? PrSaldo { get; set; }

    public string PrFormula { get; set; } = null!;
}
