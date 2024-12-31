using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Step
{
    public string WoNumber { get; set; } = null!;

    public short StSequenc { get; set; }

    public string OpNumber { get; set; } = null!;

    public decimal StStdHr { get; set; }

    public decimal StRealHr { get; set; }

    public decimal StQty { get; set; }

    public int Llave { get; set; }

    public virtual Worder WoNumberNavigation { get; set; } = null!;
}
