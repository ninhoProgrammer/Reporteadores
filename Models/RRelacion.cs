using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class RRelacion
{
    public short EnCodigo { get; set; }

    public short RlOrden { get; set; }

    public short RlEntidad { get; set; }

    public string RlCampos { get; set; } = null!;

    public string RlInner { get; set; } = null!;

    public int Llave { get; set; }

    public string? RlActivo { get; set; }

    public short? RlVersion { get; set; }

    public short? UsCodigo { get; set; }

    public virtual REntidad EnCodigoNavigation { get; set; } = null!;
}
