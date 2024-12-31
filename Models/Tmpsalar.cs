using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Tmpsalar
{
    public short TsUser { get; set; }

    public int CbCodigo { get; set; }

    public string Prettyname { get; set; } = null!;

    public decimal TsMonto1 { get; set; }

    public decimal TsMonto2 { get; set; }

    public decimal CbSalario { get; set; }

    public string CbTablass { get; set; } = null!;

    public DateTime CbFecAnt { get; set; }

    public decimal CbPerVar { get; set; }

    public DateTime CbFecSal { get; set; }

    public string CbAutosal { get; set; } = null!;

    public decimal TsDif { get; set; }

    public decimal TsPor { get; set; }

    public string? CbNota { get; set; }
}
