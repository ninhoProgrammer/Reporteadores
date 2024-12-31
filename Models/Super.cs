using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Super
{
    public short UsCodigo { get; set; }

    public string CbNivel { get; set; } = null!;

    public int Llave { get; set; }
}
