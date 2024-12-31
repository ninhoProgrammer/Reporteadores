using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class AcarAbo
{
    public string AhTipo { get; set; } = null!;

    public int CbCodigo { get; set; }

    public DateTime CrCaptura { get; set; }

    public decimal CrAbono { get; set; }

    public DateTime CrFecha { get; set; }

    public decimal CrCargo { get; set; }

    public string CrObserva { get; set; } = null!;

    public short UsCodigo { get; set; }

    public int Llave { get; set; }

    public virtual Ahorro Ahorro { get; set; } = null!;
}
