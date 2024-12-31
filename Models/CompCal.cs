using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class CompCal
{
    public string CmCodigo { get; set; } = null!;

    public string CaCodigo { get; set; } = null!;

    public string McDescrip { get; set; } = null!;

    public int Llave { get; set; }

    public virtual Califica CaCodigoNavigation { get; set; } = null!;

    public virtual Competen CmCodigoNavigation { get; set; } = null!;
}
