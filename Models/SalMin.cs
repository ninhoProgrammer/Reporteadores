using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class SalMin
{
    public DateTime SmFecIni { get; set; }

    public decimal SmZonaA { get; set; }

    public decimal SmZonaB { get; set; }

    public decimal SmZonaC { get; set; }

    public int Llave { get; set; }
}
