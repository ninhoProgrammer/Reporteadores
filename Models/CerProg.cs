using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class CerProg
{
    public int CbCodigo { get; set; }

    public string CbPuesto { get; set; } = null!;

    public string? CiCodigo { get; set; }

    public DateTime? KiFecPro { get; set; }

    public DateTime? KiFecTom { get; set; }

    public decimal? KiCalif1 { get; set; }

    public decimal? KiCalif2 { get; set; }

    public decimal? KiCalif3 { get; set; }

    public string PcOpciona { get; set; } = null!;

    public string PcLista { get; set; } = null!;
}
