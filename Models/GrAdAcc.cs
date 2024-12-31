using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class GrAdAcc
{
    public string CmCodigo { get; set; } = null!;

    public short GrCodigo { get; set; }

    public string GxCodigo { get; set; } = null!;

    public short GxDerecho { get; set; }

    public int Llave { get; set; }
}
