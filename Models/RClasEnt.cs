using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class RClasEnt
{
    public short RcCodigo { get; set; }

    public short CeOrden { get; set; }

    public short EnCodigo { get; set; }

    public int Llave { get; set; }

    public short? CeVersion { get; set; }

    public short? UsCodigo { get; set; }

    public virtual RClasifi RcCodigoNavigation { get; set; } = null!;
}
