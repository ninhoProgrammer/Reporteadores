using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class LiqImss
{
    public decimal LsActAmo { get; set; }

    public decimal LsActApo { get; set; }

    public decimal LsActIms { get; set; }

    public decimal LsActInf { get; set; }

    public decimal LsActRet { get; set; }

    public decimal LsApoVol { get; set; }

    public decimal LsCesVej { get; set; }

    public int LsDiasBm { get; set; }

    public int LsDiasCo { get; set; }

    public decimal LsEymDin { get; set; }

    public decimal LsEymEsp { get; set; }

    public decimal LsEymExc { get; set; }

    public decimal LsEymFij { get; set; }

    public decimal LsFacAct { get; set; }

    public decimal LsFacRec { get; set; }

    public DateTime LsFecRec { get; set; }

    public decimal LsGuarder { get; set; }

    public decimal LsInfAcr { get; set; }

    public decimal LsInfAmo { get; set; }

    public decimal LsInfNac { get; set; }

    public int LsInfNum { get; set; }

    public decimal LsInvVid { get; set; }

    public int LsNumBim { get; set; }

    public int LsNumTra { get; set; }

    public string LsPatron { get; set; } = null!;

    public decimal LsRecAmo { get; set; }

    public decimal LsRecApo { get; set; }

    public decimal LsRecIms { get; set; }

    public decimal LsRecInf { get; set; }

    public decimal LsRecRet { get; set; }

    public decimal LsRetiro { get; set; }

    public decimal LsRiesgos { get; set; }

    public short LsStatus { get; set; }

    public short LsYear { get; set; }

    public short LsMonth { get; set; }

    public short LsTipo { get; set; }

    public decimal LsSubIms { get; set; }

    public decimal LsTotIms { get; set; }

    public decimal LsTotMes { get; set; }

    public decimal LsSubRet { get; set; }

    public decimal LsTotRet { get; set; }

    public decimal LsSubInf { get; set; }

    public decimal LsTotInf { get; set; }

    public short UsCodigo { get; set; }

    public decimal LsImssOb { get; set; }

    public decimal LsImssPa { get; set; }

    public int Llave { get; set; }

    public decimal? LsParcial { get; set; }

    public string? LsFinan { get; set; }

    public string? LsDes20 { get; set; }

    public virtual ICollection<LiqEmp> LiqEmps { get; set; } = new List<LiqEmp>();
}
