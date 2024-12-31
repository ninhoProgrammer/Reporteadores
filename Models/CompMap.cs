using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class CompMap
{
    public string CmCodigo { get; set; } = null!;

    public string AnCodigo { get; set; } = null!;

    public string CmObserva { get; set; } = null!;

    public short CmOrden { get; set; }

    public int Llave { get; set; }

    public virtual Accion AnCodigoNavigation { get; set; } = null!;

    public virtual Competen CmCodigoNavigation { get; set; } = null!;
}
