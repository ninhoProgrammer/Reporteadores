using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class RepPtu
{
    public short RuYear { get; set; }

    public int CbCodigo { get; set; }

    public short RuDias { get; set; }

    public decimal RuMDias { get; set; }

    public decimal RuMonto { get; set; }

    public decimal RuMMonto { get; set; }

    public short UsCodigo { get; set; }

    public int Llave { get; set; }

    public virtual Colabora CbCodigoNavigation { get; set; } = null!;
}
