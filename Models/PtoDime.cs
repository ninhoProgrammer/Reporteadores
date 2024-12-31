using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class PtoDime
{
    public string PuCodigo { get; set; } = null!;

    public string DmCodigo { get; set; } = null!;

    public string PdDescrip { get; set; } = null!;

    public int Llave { get; set; }

    public virtual Dimensio DmCodigoNavigation { get; set; } = null!;

    public virtual Puesto PuCodigoNavigation { get; set; } = null!;
}
