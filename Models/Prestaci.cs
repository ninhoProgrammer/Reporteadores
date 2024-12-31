using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Prestaci
{
    public string TbCodigo { get; set; } = null!;

    public short PtYear { get; set; }

    public decimal PtDiasVa { get; set; }

    public decimal PtPrimava { get; set; }

    public decimal PtDiasAg { get; set; }

    public decimal PtDiasAd { get; set; }

    public decimal PtPrimado { get; set; }

    public string PtPago7 { get; set; } = null!;

    public string PtPrima7 { get; set; } = null!;

    public decimal PtFactor { get; set; }

    public int Llave { get; set; }

    public virtual Ssocial TbCodigoNavigation { get; set; } = null!;
}
