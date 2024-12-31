using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Altabaja
{
    public int CbCodigo { get; set; }

    public string CbPatron { get; set; } = null!;

    public DateTime CbAlta { get; set; }

    public DateTime? CbBaja { get; set; }
}
