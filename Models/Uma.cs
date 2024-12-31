using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Uma
{
    public int? UmaFecha { get; set; }

    public double? UmaDiario { get; set; }

    public double? UmaMensual { get; set; }

    public double? UmaAnual { get; set; }

    public int Llave { get; set; }

    public DateOnly? UmaVigen { get; set; }
}
