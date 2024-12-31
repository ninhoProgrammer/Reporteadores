using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class VUmiAbg
{
    public int? UmiFecha { get; set; }

    public double? UmiDiario { get; set; }

    public double? UmiMensual { get; set; }

    public double? UmiAnual { get; set; }

    public DateOnly? UmiVigencia { get; set; }

    public int Llave { get; set; }
}
