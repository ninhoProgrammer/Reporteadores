using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class FonCre
{
    public short FtYear { get; set; }

    public short FtMonth { get; set; }

    public string PrTipo { get; set; } = null!;

    public int CbCodigo { get; set; }

    public string PrReferen { get; set; } = null!;

    public decimal FcRetenc { get; set; }

    public decimal FcNomina { get; set; }

    public decimal FcAjuste { get; set; }

    public int Llave { get; set; }

    public virtual FonEmp FonEmp { get; set; } = null!;
}
