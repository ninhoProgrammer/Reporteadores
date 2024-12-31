using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Vpunto
{
    public int VpFolio { get; set; }

    public short VtOrden { get; set; }

    public short VtCual { get; set; }

    public string? VtComenta { get; set; }

    public int Llave { get; set; }

    public virtual ValPto VpFolioNavigation { get; set; } = null!;
}
