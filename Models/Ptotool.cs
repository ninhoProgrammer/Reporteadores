using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Ptotool
{
    public string PuCodigo { get; set; } = null!;

    public string ToCodigo { get; set; } = null!;

    public string KtReferen { get; set; } = null!;

    public int Llave { get; set; }

    public virtual Puesto PuCodigoNavigation { get; set; } = null!;

    public virtual Tool ToCodigoNavigation { get; set; } = null!;
}
