using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Reglaprest
{
    public short RpCodigo { get; set; }

    public string RpLetrero { get; set; } = null!;

    public string RpActivo { get; set; } = null!;

    public short RpPreSts { get; set; }

    public short RpLimite { get; set; }

    public string RpValFec { get; set; } = null!;

    public string RpTope { get; set; } = null!;

    public short RpEmpSts { get; set; }

    public short RpAntIni { get; set; }

    public short RpAntFin { get; set; }

    public string QuCodigo { get; set; } = null!;

    public string RpFiltro { get; set; } = null!;

    public string RpLista { get; set; } = null!;

    public short RpOrden { get; set; }

    public int Llave { get; set; }

    public virtual ICollection<Prestaxreg> Prestaxregs { get; set; } = new List<Prestaxreg>();
}
