using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Tmppromvar
{
    public int CbCodigo { get; set; }

    public DateTime CbFecha { get; set; }

    public string CbTipo { get; set; } = null!;

    public decimal TvDias { get; set; }

    public decimal TvProm { get; set; }

    public decimal TvTotPro { get; set; }

    public short CoNumero { get; set; }

    public decimal TvMonto { get; set; }

    public virtual Kardex Kardex { get; set; } = null!;
}
