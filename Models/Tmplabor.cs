using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Tmplabor
{
    public short UsCodigo { get; set; }

    public int CbCodigo { get; set; }

    public string CbArea { get; set; } = null!;

    public string CbCheca { get; set; } = null!;

    public string CbTurno { get; set; } = null!;

    public int? TlStatus { get; set; }

    public string TlAplica { get; set; } = null!;

    public string TlCalcula { get; set; } = null!;
}
