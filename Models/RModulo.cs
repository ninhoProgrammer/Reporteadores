using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class RModulo
{
    public short MoCodigo { get; set; }

    public string MoNombre { get; set; } = null!;

    public short MoOrden { get; set; }

    public int Llave { get; set; }

    public string? MoActivo { get; set; }

    public short? MoVersion { get; set; }

    public short? UsCodigo { get; set; }

    public virtual ICollection<RModEnt> RModEnts { get; set; } = new List<RModEnt>();
}
