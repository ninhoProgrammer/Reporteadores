using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Tmplistum
{
    public short TaUser { get; set; }

    public string TaNivel1 { get; set; } = null!;

    public string TaNivel2 { get; set; } = null!;

    public string TaNivel3 { get; set; } = null!;

    public string TaNivel4 { get; set; } = null!;

    public string TaNivel5 { get; set; } = null!;

    public int CbCodigo { get; set; }

    public short CoNumero { get; set; }

    public string TaReferen { get; set; } = null!;

    public decimal TaPercepc { get; set; }

    public decimal TaDeducci { get; set; }

    public int TaTotal { get; set; }

    public short PeYear { get; set; }

    public short PeTipo { get; set; }

    public short PeNumero { get; set; }

    public decimal? TaHoras { get; set; }
}
