using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class REntAcc
{
    public string CmCodigo { get; set; } = null!;

    public short GrCodigo { get; set; }

    public short EnCodigo { get; set; }

    public short ReDerecho { get; set; }

    public int Llave { get; set; }

    public short? ReVersion { get; set; }

    public short? UsCodigo { get; set; }
}
