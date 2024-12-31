using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class RListaval
{
    public short LvCodigo { get; set; }

    public string LvNombre { get; set; } = null!;

    public int Llave { get; set; }

    public string? LvActivo { get; set; }

    public short? LvVersion { get; set; }

    public short? UsCodigo { get; set; }

    public virtual ICollection<RValor> RValors { get; set; } = new List<RValor>();
}
