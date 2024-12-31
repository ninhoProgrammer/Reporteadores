using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class RFiltro
{
    public short EnCodigo { get; set; }

    public short RfOrden { get; set; }

    public short RfEntidad { get; set; }

    public string AtCampo { get; set; } = null!;

    public int Llave { get; set; }

    public short? RfVersion { get; set; }

    public short? UsCodigo { get; set; }

    public virtual REntidad EnCodigoNavigation { get; set; } = null!;
}
