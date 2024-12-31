using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class VDisposit
{
    public string DiNombre { get; set; } = null!;

    public short DiTipo { get; set; }

    public string? DiDescrip { get; set; }

    public string? DiNota { get; set; }

    public string? DiIp { get; set; }
}
