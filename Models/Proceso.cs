using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Proceso
{
    public short PcProcId { get; set; }

    public int PcNumero { get; set; }

    public short UsCodigo { get; set; }

    public DateTime PcFecIni { get; set; }

    public string PcHorIni { get; set; } = null!;

    public DateTime PcFecFin { get; set; }

    public string PcHorFin { get; set; } = null!;

    public string PcError { get; set; } = null!;

    public int CbCodigo { get; set; }

    public int PcMaximo { get; set; }

    public int PcPaso { get; set; }

    public short UsCancela { get; set; }

    public string PcParams { get; set; } = null!;

    public int Llave { get; set; }
}
