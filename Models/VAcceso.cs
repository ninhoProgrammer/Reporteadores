using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class VAcceso
{
    public short GrCodigo { get; set; }

    public string CmCodigo { get; set; } = null!;

    public short AxNumero { get; set; }

    public short AxDerecho { get; set; }
}
