using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Declara
{
    public short DcYear { get; set; }

    public int CbCodigo { get; set; }

    public decimal DcTotPer { get; set; }

    public decimal DcGravado { get; set; }

    public decimal DcCredito { get; set; }

    public short UsCodigo { get; set; }

    public int Llave { get; set; }

    public virtual Colabora CbCodigoNavigation { get; set; } = null!;
}
