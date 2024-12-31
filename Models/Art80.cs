using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Art80
{
    public short NuCodigo { get; set; }

    public DateTime TiInicio { get; set; }

    public decimal A80Li { get; set; }

    public decimal A80Cuota { get; set; }

    public decimal A80Tasa { get; set; }

    public int Llave { get; set; }

    public virtual TArt80 TArt80 { get; set; } = null!;
}
