using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Defstep
{
    public string ArCodigo { get; set; } = null!;

    public short DfSequenc { get; set; }

    public string OpNumber { get; set; } = null!;

    public decimal DfStdHr { get; set; }

    public int Llave { get; set; }

    public virtual Parte ArCodigoNavigation { get; set; } = null!;
}
