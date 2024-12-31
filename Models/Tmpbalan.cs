using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Tmpbalan
{
    public short TzUser { get; set; }

    public int CbCodigo { get; set; }

    public short TzCodigo { get; set; }

    public short TzNumPer { get; set; }

    public string TzDesPer { get; set; } = null!;

    public decimal TzMonPer { get; set; }

    public string TzRefPer { get; set; } = null!;

    public short TzNumDed { get; set; }

    public decimal TzHorPer { get; set; }

    public string TzDesDed { get; set; } = null!;

    public decimal TzMonDed { get; set; }

    public string TzRefDed { get; set; } = null!;

    public decimal TzHorDed { get; set; }

    public short PeYear { get; set; }

    public short PeTipo { get; set; }

    public short PeNumero { get; set; }
}
