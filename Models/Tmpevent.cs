using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Tmpevent
{
    public short UsCodigo { get; set; }

    public int CbCodigo { get; set; }

    public DateTime TvFecha { get; set; }

    public string Prettyname { get; set; } = null!;

    public DateTime CbFecIng { get; set; }

    public short CbAntig { get; set; }

    public string CbActivo { get; set; } = null!;

    public string TvComent { get; set; } = null!;

    public short TvPriorid { get; set; }

    public string EvCodigo { get; set; } = null!;

    public string TvPuesto { get; set; } = null!;

    public string TvClasifi { get; set; } = null!;

    public string TvTablass { get; set; } = null!;

    public string TvContrat { get; set; } = null!;

    public string TvTurno { get; set; } = null!;

    public string TvNivel1 { get; set; } = null!;

    public string TvNivel2 { get; set; } = null!;

    public string TvNivel3 { get; set; } = null!;

    public string TvNivel4 { get; set; } = null!;

    public string TvNivel5 { get; set; } = null!;

    public string TvNivel6 { get; set; } = null!;

    public string TvNivel7 { get; set; } = null!;

    public string TvNivel8 { get; set; } = null!;

    public string TvNivel9 { get; set; } = null!;

    public decimal TvSalario { get; set; }

    public string TvOtras1 { get; set; } = null!;

    public string TvOtras2 { get; set; } = null!;

    public string TvOtras3 { get; set; } = null!;

    public string TvOtras4 { get; set; } = null!;

    public string TvOtras5 { get; set; } = null!;

    public string TvKardex { get; set; } = null!;

    public decimal TvMonto { get; set; }

    public string TvAutosal { get; set; } = null!;

    public string TvCampo { get; set; } = null!;

    public string TvValor { get; set; } = null!;

    public string TvAlta { get; set; } = null!;

    public string TvBaja { get; set; } = null!;

    public string TvMotBaj { get; set; } = null!;

    public short TvNomyear { get; set; }

    public short TvNomtipo { get; set; }

    public short TvNomnume { get; set; }

    public DateTime TvFecBss { get; set; }

    public string TvPatron { get; set; } = null!;

    public DateTime TvFecAnt { get; set; }

    public DateTime TvFecCon { get; set; }
}
