using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class MovGral
{
    public short PeYear { get; set; }

    public short PeTipo { get; set; }

    public short PeNumero { get; set; }

    public short CoNumero { get; set; }

    public string MgFijo { get; set; } = null!;

    public decimal MgMonto { get; set; }

    public short UsCodigo { get; set; }

    public int Llave { get; set; }

    public virtual Concepto CoNumeroNavigation { get; set; } = null!;

    public virtual Periodo Periodo { get; set; } = null!;
}
