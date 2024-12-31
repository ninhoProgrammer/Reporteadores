using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class CurProg
{
    public int CbCodigo { get; set; }

    public string CbPuesto { get; set; } = null!;

    public string? CuCodigo { get; set; }

    public DateTime? KcFecPro { get; set; }

    public decimal? KcEvalua { get; set; }

    public DateTime? KcFecTom { get; set; }

    public decimal? KcHoras { get; set; }

    public decimal? CuHoras { get; set; }

    public string EnOpciona { get; set; } = null!;

    public string? EnLista { get; set; }

    public string? MaCodigo { get; set; }

    public DateTime? KcProximo { get; set; }

    public string? KcRevisio { get; set; }

    public string? CuRevisio { get; set; }

    public string? CpManual { get; set; }

    public string? EpGlobal { get; set; }
}
