using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class VLiqEmp
{
    public short LsYear { get; set; }

    public short LsMonth { get; set; }

    public decimal? LeAcumula { get; set; }

    public decimal? LeProv { get; set; }

    public short? LeVaGozo { get; set; }

    public short? LeVaPago { get; set; }

    public decimal? LeInfPat { get; set; }

    public decimal? LeInfAmo { get; set; }

    public int CbCodigo { get; set; }

    public decimal? LeTotInf { get; set; }

    public int? LeDiasBm { get; set; }

    public decimal? LeBimSig { get; set; }

    public decimal? LeBimAnt { get; set; }
}
