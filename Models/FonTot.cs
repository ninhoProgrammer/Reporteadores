using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class FonTot
{
    public short FtYear { get; set; }

    public short FtMonth { get; set; }

    public string PrTipo { get; set; } = null!;

    public short FtStatus { get; set; }

    public decimal FtRetenc { get; set; }

    public decimal FtNomina { get; set; }

    public string FtTajust { get; set; } = null!;

    public decimal FtAjuste { get; set; }

    public int FtEmplead { get; set; }

    public int FtCuantos { get; set; }

    public int FtBajas { get; set; }

    public int FtIncapa { get; set; }

    public int Llave { get; set; }

    public string? FtDetalle { get; set; }

    public virtual ICollection<FonEmp> FonEmps { get; set; } = new List<FonEmp>();
}
