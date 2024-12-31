using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class ROrden
{
    public short EnCodigo { get; set; }

    public short RoOrden { get; set; }

    public short RoEntidad { get; set; }

    public string AtCampo { get; set; } = null!;

    public int Llave { get; set; }

    public short? RoVersion { get; set; }

    public short? UsCodigo { get; set; }

    public virtual REntidad EnCodigoNavigation { get; set; } = null!;
}
