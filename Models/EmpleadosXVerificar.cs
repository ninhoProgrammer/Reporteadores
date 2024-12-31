using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class EmpleadosXVerificar
{
    public int CbCodigo { get; set; }

    public string CbApePat { get; set; } = null!;

    public string CbApeMat { get; set; } = null!;

    public string CbNombres { get; set; } = null!;

    public string CbCurp { get; set; } = null!;

    public string CbRfc { get; set; } = null!;

    public string CbSegsoc { get; set; } = null!;

    public string CbSexo { get; set; } = null!;

    public DateTime CbFecNac { get; set; }

    public string CbActivo { get; set; } = null!;

    public string CbRecontr { get; set; } = null!;

    public string Prettyname { get; set; } = null!;

    public byte[]? Foto { get; set; }

    public string? Referencia { get; set; }
}
