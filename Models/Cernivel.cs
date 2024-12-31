using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Cernivel
{
    public string PuCodigo { get; set; } = null!;

    public string CiCodigo { get; set; } = null!;

    public string CnCodigo { get; set; } = null!;

    public int Llave { get; set; }

    public virtual PtoCert PtoCert { get; set; } = null!;
}
