using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Compara
{
    public short CpYear { get; set; }

    public int CbCodigo { get; set; }

    public decimal CbSalario { get; set; }

    public decimal CpTotPer { get; set; }

    public decimal CpGravado { get; set; }

    public decimal CpPagado { get; set; }

    public decimal CpRetenid { get; set; }

    public decimal CpArt141 { get; set; }

    public decimal CpFavor { get; set; }

    public decimal CpContra { get; set; }

    public decimal CpAPagar { get; set; }

    public short UsCodigo { get; set; }

    public int Llave { get; set; }

    public string? CpCalculo { get; set; }

    public virtual Colabora CbCodigoNavigation { get; set; } = null!;
}
