using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class VAccemp
{
    public int AaSource { get; set; }

    public string CmCodigo { get; set; } = null!;

    public short GrCodigo { get; set; }

    public int? AxNumero { get; set; }

    public int? AxDerecho { get; set; }
}
