using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class VCompany
{
    public string CmCodigo { get; set; } = null!;

    public string CmNombre { get; set; } = null!;

    public string CmAcumula { get; set; } = null!;

    public string CmControl { get; set; } = null!;

    public int CmEmpate { get; set; }

    public string CmAlias { get; set; } = null!;

    public string CmUsrname { get; set; } = null!;

    public string CmUsacafe { get; set; } = null!;

    public string CmNivel0 { get; set; } = null!;

    public string CmDatos { get; set; } = null!;

    public string CmDigito { get; set; } = null!;

    public short? CmKclasifi { get; set; }

    public string? CmKconfi { get; set; }

    public string? CmKusers { get; set; }
}
