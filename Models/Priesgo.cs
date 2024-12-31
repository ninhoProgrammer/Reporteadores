using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Priesgo
{
    public string TbCodigo { get; set; } = null!;

    public DateTime RtFecha { get; set; }

    public decimal RtPrima { get; set; }

    public int Llave { get; set; }

    public decimal? RtPtant { get; set; }

    public decimal? RtS { get; set; }

    public decimal? RtI { get; set; }

    public decimal? RtD { get; set; }

    public decimal? RtN { get; set; }

    public decimal? RtM { get; set; }

    public decimal? RtF { get; set; }

    public virtual Rpatron TbCodigoNavigation { get; set; } = null!;
}
