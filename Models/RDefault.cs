using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class RDefault
{
    public short EnCodigo { get; set; }

    public short RdOrden { get; set; }

    public short RdEntidad { get; set; }

    public string AtCampo { get; set; } = null!;

    public int Llave { get; set; }

    public short? RdVersion { get; set; }

    public short? UsCodigo { get; set; }

    public virtual REntidad EnCodigoNavigation { get; set; } = null!;
}
