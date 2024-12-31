using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Tmpmov
{
    public short UsCodigo { get; set; }

    public int CbCodigo { get; set; }

    public short CoNumero { get; set; }

    public string MoReferen { get; set; } = null!;

    public decimal MoMonto { get; set; }

    public short MoTipo { get; set; }

    public DateTime FaFecIni { get; set; }

    public string FaDiaHor { get; set; } = null!;

    public short FaMotivo { get; set; }
}
