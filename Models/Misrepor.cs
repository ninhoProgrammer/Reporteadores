using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Misrepor
{
    public short UsCodigo { get; set; }

    public short ReCodigo { get; set; }

    public int Llave { get; set; }

    public virtual Reporte ReCodigoNavigation { get; set; } = null!;
}
