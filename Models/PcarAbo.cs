using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class PcarAbo
{
    public int CbCodigo { get; set; }

    public DateTime CrCaptura { get; set; }

    public string PrTipo { get; set; } = null!;

    public DateTime CrFecha { get; set; }

    public string PrReferen { get; set; } = null!;

    public string CrObserva { get; set; } = null!;

    public decimal CrAbono { get; set; }

    public decimal CrCargo { get; set; }

    public short UsCodigo { get; set; }

    public int Llave { get; set; }

    public virtual Prestamo Prestamo { get; set; } = null!;
}
