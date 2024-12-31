using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class CompFam
{
    public string FpCodigo { get; set; } = null!;

    public string CmCodigo { get; set; } = null!;

    public string CfObserva { get; set; } = null!;

    public int Llave { get; set; }

    public virtual Competen CmCodigoNavigation { get; set; } = null!;

    public virtual FamPto FpCodigoNavigation { get; set; } = null!;
}
