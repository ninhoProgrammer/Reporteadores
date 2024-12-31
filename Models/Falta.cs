using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Falta
{
    public short PeYear { get; set; }

    public short PeTipo { get; set; }

    public short PeNumero { get; set; }

    public int CbCodigo { get; set; }

    public DateTime FaFecIni { get; set; }

    public string FaDiaHor { get; set; } = null!;

    public short FaMotivo { get; set; }

    public decimal FaDias { get; set; }

    public decimal FaHoras { get; set; }

    public int Llave { get; set; }

    public virtual Nomina Nomina { get; set; } = null!;
}
