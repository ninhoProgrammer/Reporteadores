using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class VAdvanceitEmpleado
{
    public string CbApeMat { get; set; } = null!;

    public string CbApePat { get; set; } = null!;

    public string CbNombres { get; set; } = null!;

    public string CbTel { get; set; } = null!;

    public string TipoDocumento { get; set; } = null!;

    public string CbRfc { get; set; } = null!;

    public decimal SalarioDiario { get; set; }

    public decimal? DiasPeriodo { get; set; }

    public decimal? SalarioPeriodo { get; set; }

    public string? PuDescrip { get; set; }

    public string CbBanEle { get; set; } = null!;

    public string? IdEmpresa { get; set; }

    public string CodEmpresa { get; set; } = null!;
}
