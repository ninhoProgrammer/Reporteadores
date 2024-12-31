using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class EmpComp
{
    public int CbCodigo { get; set; }

    public string CmCodigo { get; set; } = null!;

    public string CaCodigo { get; set; } = null!;

    public string EcObserva { get; set; } = null!;

    public DateTime EcFecMod { get; set; }

    public short UsCodigo { get; set; }

    public int Llave { get; set; }

    public virtual Colabora CbCodigoNavigation { get; set; } = null!;

    public virtual Competen CmCodigoNavigation { get; set; } = null!;
}
