using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Tmpbala2
{
    public short TpUser { get; set; }

    public string TpNivel1 { get; set; } = null!;

    public string TpNivel2 { get; set; } = null!;

    public string TpNivel3 { get; set; } = null!;

    public string TpNivel4 { get; set; } = null!;

    public string TpNivel5 { get; set; } = null!;

    public short TpOrden { get; set; }

    public int CbCodigo { get; set; }

    public short TpNumPer { get; set; }

    public string TpDesPer { get; set; } = null!;

    public decimal TpMonPer { get; set; }

    public decimal TpHorPer { get; set; }

    public string TpRefPer { get; set; } = null!;

    public short TpNumDed { get; set; }

    public string TpDesDed { get; set; } = null!;

    public decimal TpMonDed { get; set; }

    public string TpRefDed { get; set; } = null!;

    public decimal TpHorDed { get; set; }

    public int TpTotal { get; set; }

    public short PeYear { get; set; }

    public short PeTipo { get; set; }

    public short PeNumero { get; set; }

    public string TpEmplead { get; set; } = null!;
}
