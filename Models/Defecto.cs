using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Defecto
{
    public int CiFolio { get; set; }

    public short DeFolio { get; set; }

    public string DeCodigo { get; set; } = null!;

    public decimal DePiezas { get; set; }

    public string DeComenta { get; set; } = null!;

    public int Llave { get; set; }

    public virtual CedInsp CiFolioNavigation { get; set; } = null!;

    public virtual Tdefecto DeCodigoNavigation { get; set; } = null!;
}
