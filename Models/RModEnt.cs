using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class RModEnt
{
    public short MoCodigo { get; set; }

    public short MeOrden { get; set; }

    public short EnCodigo { get; set; }

    public int Llave { get; set; }

    public short? MeVersion { get; set; }

    public short? UsCodigo { get; set; }

    public virtual RModulo MoCodigoNavigation { get; set; } = null!;
}
