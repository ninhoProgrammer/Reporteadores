using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class RClasAcc
{
    public string CmCodigo { get; set; } = null!;

    public short GrCodigo { get; set; }

    public short RcCodigo { get; set; }

    public short RaDerecho { get; set; }

    public int Llave { get; set; }

    public short? RaVersion { get; set; }

    public short? UsCodigo { get; set; }

    public virtual RClasifi RcCodigoNavigation { get; set; } = null!;
}
