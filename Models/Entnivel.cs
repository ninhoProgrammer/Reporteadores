using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Entnivel
{
    public string PuCodigo { get; set; } = null!;

    public string CuCodigo { get; set; } = null!;

    public string EtCodigo { get; set; } = null!;

    public int Llave { get; set; }

    public virtual Entrena Entrena { get; set; } = null!;
}
