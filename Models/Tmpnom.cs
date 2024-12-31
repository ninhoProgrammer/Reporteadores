using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Tmpnom
{
    public short TaUser { get; set; }

    public string TaNivel1 { get; set; } = null!;

    public string TaNivel2 { get; set; } = null!;

    public string TaNivel3 { get; set; } = null!;

    public string TaNivel4 { get; set; } = null!;

    public string TaNivel5 { get; set; } = null!;

    public int CbCodigo { get; set; }

    public decimal CbSalInt { get; set; }

    public decimal CbSalario { get; set; }

    public decimal NoDias { get; set; }

    public decimal NoAdicion { get; set; }

    public int TaTotal { get; set; }

    public decimal NoDeducci { get; set; }

    public decimal NoNeto { get; set; }

    public decimal NoDesTra { get; set; }

    public decimal NoDiasAg { get; set; }

    public decimal NoDiasVa { get; set; }

    public decimal NoDobles { get; set; }

    public decimal NoExtras { get; set; }

    public decimal NoFesPag { get; set; }

    public decimal NoFesTra { get; set; }

    public decimal NoHoraCg { get; set; }

    public decimal NoHoraSg { get; set; }

    public decimal NoHoras { get; set; }

    public decimal NoImpCal { get; set; }

    public decimal NoJornada { get; set; }

    public decimal NoPerCal { get; set; }

    public decimal NoPerMen { get; set; }

    public decimal NoPercepc { get; set; }

    public decimal NoTardes { get; set; }

    public decimal NoTriples { get; set; }

    public decimal NoTotPre { get; set; }

    public decimal NoVacTra { get; set; }

    public decimal NoXCal { get; set; }

    public decimal NoXIspt { get; set; }

    public decimal NoXMens { get; set; }

    public decimal NoDTurno { get; set; }

    public decimal NoDiasAj { get; set; }

    public decimal NoDiasAs { get; set; }

    public decimal NoDiasCg { get; set; }

    public decimal NoDiasEm { get; set; }

    public decimal NoDiasFi { get; set; }

    public decimal NoDiasFj { get; set; }

    public decimal NoDiasFv { get; set; }

    public decimal NoDiasIn { get; set; }

    public decimal NoDiasNt { get; set; }

    public decimal NoDiasOt { get; set; }

    public decimal NoDiasRe { get; set; }

    public decimal NoDiasSg { get; set; }

    public decimal NoDiasSs { get; set; }

    public decimal NoDiasSu { get; set; }

    public decimal NoHoraPd { get; set; }

    public decimal NoExentas { get; set; }

    public decimal NoDiasBa { get; set; }

    public decimal NoDiasSi { get; set; }

    public decimal NoHorasnt { get; set; }

    public decimal NoHorapdt { get; set; }

    public string NoHorOk { get; set; } = null!;

    public decimal NoPrevGr { get; set; }

    public decimal NoDiasVj { get; set; }

    public decimal NoDiasPv { get; set; }

    public decimal? NoPreExt { get; set; }
}
