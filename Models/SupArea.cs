using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class SupArea
{
    public short UsCodigo { get; set; }

    public string CbArea { get; set; } = null!;

    public int Llave { get; set; }
}
