using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class LCalculo
{
    public short? PeYear { get; set; }

    public short? PeTipo { get; set; }

    public short? PeNumero { get; set; }

    public int? CbCodigo { get; set; }

    public short? CoNumero { get; set; }

    public string? CalcLog { get; set; }

    public DateTime? ClFecha { get; set; }
}
