using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Movimien
{
    public short PeYear { get; set; }

    public short PeTipo { get; set; }

    public short PeNumero { get; set; }

    public int CbCodigo { get; set; }

    public string MoActivo { get; set; } = null!;

    public short CoNumero { get; set; }

    public decimal MoImpCal { get; set; }

    public short UsCodigo { get; set; }

    public string MoPerCal { get; set; } = null!;

    public string MoReferen { get; set; } = null!;

    public decimal MoXIspt { get; set; }

    public decimal MoPercepc { get; set; }

    public decimal MoDeducci { get; set; }

    public int Llave { get; set; }

    public virtual Concepto CoNumeroNavigation { get; set; } = null!;

    public virtual Nomina Nomina { get; set; } = null!;
}
