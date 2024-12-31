using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class VAcumula
{
    public int CbCodigo { get; set; }

    public short CoNumero { get; set; }

    public short AcYear { get; set; }

    public int AcMes { get; set; }

    public decimal AcMonto { get; set; }
}
