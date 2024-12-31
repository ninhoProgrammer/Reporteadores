using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Nomina
{
    public short PeYear { get; set; }

    public short PeTipo { get; set; }

    public short PeNumero { get; set; }

    public int CbCodigo { get; set; }

    public string CbClasifi { get; set; } = null!;

    public string CbTurno { get; set; } = null!;

    public string CbPatron { get; set; } = null!;

    public string CbPuesto { get; set; } = null!;

    public string CbZonaGe { get; set; } = null!;

    public int NoFolio1 { get; set; }

    public int NoFolio2 { get; set; }

    public int NoFolio3 { get; set; }

    public int NoFolio4 { get; set; }

    public int NoFolio5 { get; set; }

    public string NoObserva { get; set; } = null!;

    public short NoStatus { get; set; }

    public short UsCodigo { get; set; }

    public short NoUserRj { get; set; }

    public string CbNivel1 { get; set; } = null!;

    public string CbNivel2 { get; set; } = null!;

    public string CbNivel3 { get; set; } = null!;

    public string CbNivel4 { get; set; } = null!;

    public string CbNivel5 { get; set; } = null!;

    public string CbNivel6 { get; set; } = null!;

    public string CbNivel7 { get; set; } = null!;

    public string CbNivel8 { get; set; } = null!;

    public string CbNivel9 { get; set; } = null!;

    public decimal CbSalInt { get; set; }

    public decimal CbSalario { get; set; }

    public decimal NoDias { get; set; }

    public decimal NoAdicion { get; set; }

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

    public short NoDTurno { get; set; }

    public short NoDiasAj { get; set; }

    public short NoDiasAs { get; set; }

    public short NoDiasCg { get; set; }

    public short NoDiasEm { get; set; }

    public short NoDiasFi { get; set; }

    public short NoDiasFj { get; set; }

    public short NoDiasFv { get; set; }

    public short NoDiasIn { get; set; }

    public short NoDiasNt { get; set; }

    public short NoDiasOt { get; set; }

    public short NoDiasRe { get; set; }

    public short NoDiasSg { get; set; }

    public short NoDiasSs { get; set; }

    public short NoDiasSu { get; set; }

    public decimal NoHoraPd { get; set; }

    public short NoLiquida { get; set; }

    public string NoFuera { get; set; } = null!;

    public decimal NoExentas { get; set; }

    public DateTime NoFecPag { get; set; }

    public short NoUsrPag { get; set; }

    public decimal NoHorasnt { get; set; }

    public string CbNivel0 { get; set; } = null!;

    public string CbBanEle { get; set; } = null!;

    public decimal NoHorapdt { get; set; }

    public decimal NoDiasSi { get; set; }

    public short NoSupOk { get; set; }

    public DateTime NoFecOk { get; set; }

    public string NoHorOk { get; set; } = null!;

    public DateTime NoAsiIni { get; set; }

    public DateTime NoAsiFin { get; set; }

    public decimal NoDiasBa { get; set; }

    public DateTime NoFecLiq { get; set; }

    public int CbPlaza { get; set; }

    public decimal NoDiasVj { get; set; }

    public decimal NoPrevGr { get; set; }

    public decimal NoDiasPv { get; set; }

    public decimal? NoPreExt { get; set; }

    public int Llave { get; set; }

    public short? NoDiasPe { get; set; }

    public string? NoGlobal { get; set; }

    public short? NoAproba { get; set; }

    public string? NoRastreo { get; set; }

    public string CbCtaGas { get; set; } = null!;

    public string CbCtaVal { get; set; } = null!;

    public virtual ICollection<Falta> Falta { get; set; } = new List<Falta>();

    public virtual ICollection<Movimien> Movimiens { get; set; } = new List<Movimien>();

    public virtual Periodo Periodo { get; set; } = null!;
}
