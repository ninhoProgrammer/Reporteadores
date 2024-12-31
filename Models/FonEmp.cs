using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class FonEmp
{
    public short FtYear { get; set; }

    public short FtMonth { get; set; }

    public string PrTipo { get; set; } = null!;

    public int CbCodigo { get; set; }

    public decimal FeRetenc { get; set; }

    public decimal FeNomina { get; set; }

    public decimal FeAjuste { get; set; }

    public int FeCuantos { get; set; }

    public string FeIncide { get; set; } = null!;

    public DateTime FeFecha1 { get; set; }

    public DateTime FeFecha2 { get; set; }

    public int Llave { get; set; }

    public virtual ICollection<FonCre> FonCres { get; set; } = new List<FonCre>();

    public virtual FonTot FonTot { get; set; } = null!;
}
