using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class CompPto
{
    public string PuCodigo { get; set; } = null!;

    public string CmCodigo { get; set; } = null!;

    public string CaCodigo { get; set; } = null!;

    public string MpDescrip { get; set; } = null!;

    public int Llave { get; set; }

    public virtual Competen CmCodigoNavigation { get; set; } = null!;

    public virtual Puesto PuCodigoNavigation { get; set; } = null!;
}
