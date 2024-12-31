using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class VCurso
{
    public string CuCodigo { get; set; } = null!;

    public string CuFolio { get; set; } = null!;

    public string CuNombre { get; set; } = null!;

    public string CuActivo { get; set; } = null!;

    public string MaCodigo { get; set; } = null!;

    public decimal CuHoras { get; set; }

    public string CuRevisio { get; set; } = null!;

    public decimal CuCosto1 { get; set; }

    public decimal CuCosto2 { get; set; }

    public decimal CuCosto3 { get; set; }
}
