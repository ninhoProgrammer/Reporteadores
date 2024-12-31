using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Karcurso
{
    public int CbCodigo { get; set; }

    public string CuCodigo { get; set; } = null!;

    public string CbClasifi { get; set; } = null!;

    public string CbTurno { get; set; } = null!;

    public decimal KcEvalua { get; set; }

    public DateTime KcFecTom { get; set; }

    public decimal KcHoras { get; set; }

    public string CbPuesto { get; set; } = null!;

    public string CbNivel1 { get; set; } = null!;

    public string CbNivel2 { get; set; } = null!;

    public string CbNivel3 { get; set; } = null!;

    public string CbNivel4 { get; set; } = null!;

    public string CbNivel5 { get; set; } = null!;

    public string CbNivel6 { get; set; } = null!;

    public string CbNivel7 { get; set; } = null!;

    public string CbNivel8 { get; set; } = null!;

    public string CbNivel9 { get; set; } = null!;

    public string MaCodigo { get; set; } = null!;

    public DateTime KcFecFin { get; set; }

    public string KcRevisio { get; set; } = null!;

    public int SeFolio { get; set; }

    public int Llave { get; set; }

    public DateTime? KcFecprog { get; set; }

    public int? KcNoStps { get; set; }

    public string? KcEst { get; set; }

    public virtual Colabora CbCodigoNavigation { get; set; } = null!;
}
