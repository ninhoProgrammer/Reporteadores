using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Query
{
    public string QuCodigo { get; set; } = null!;

    public string QuDescrip { get; set; } = null!;

    public string QuFiltro { get; set; } = null!;

    public short QuNivel { get; set; }

    public short UsCodigo { get; set; }

    public int Llave { get; set; }

    public string? QuNavega { get; set; }

    public short? QuOrden { get; set; }

    public string? QuCandado { get; set; }
}
