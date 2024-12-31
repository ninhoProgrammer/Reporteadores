using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class LiqEmp
{
    public decimal LeApoVol { get; set; }

    public decimal LeCesVej { get; set; }

    public short LeDiasBm { get; set; }

    public short LeDiasCo { get; set; }

    public decimal LeEymDin { get; set; }

    public int CbCodigo { get; set; }

    public decimal LeEymEsp { get; set; }

    public decimal LeEymExc { get; set; }

    public decimal LeEymFij { get; set; }

    public decimal LeGuarder { get; set; }

    public decimal LeInfAmo { get; set; }

    public decimal LeInfPat { get; set; }

    public decimal LeInvVid { get; set; }

    public decimal LeRetiro { get; set; }

    public decimal LeRiesgos { get; set; }

    public short LeStatus { get; set; }

    public short LsYear { get; set; }

    public short LsMonth { get; set; }

    public string LsPatron { get; set; } = null!;

    public short LsTipo { get; set; }

    public decimal LeTotIms { get; set; }

    public decimal LeTotRet { get; set; }

    public decimal LeTotInf { get; set; }

    public decimal LeImssOb { get; set; }

    public decimal LeImssPa { get; set; }

    public int Llave { get; set; }

    public decimal? LeAcumula { get; set; }

    public decimal? LeBimAnt { get; set; }

    public decimal? LeBimSig { get; set; }

    public short? LeVaPago { get; set; }

    public short? LeVaGozo { get; set; }

    public decimal? LeProv { get; set; }

    public virtual LiqImss LiqImss { get; set; } = null!;

    public virtual ICollection<LiqMov> LiqMovs { get; set; } = new List<LiqMov>();
}
