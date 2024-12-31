using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class VValPto
{
    public int VpFolio { get; set; }

    public short VlCodigo { get; set; }

    public string PuCodigo { get; set; } = null!;

    public DateTime VpFecha { get; set; }

    public string? VpComenta { get; set; }

    public decimal VpGrado { get; set; }

    public string VpPtCode { get; set; } = null!;

    public string VpPtNom { get; set; } = null!;

    public decimal VpPtGrad { get; set; }

    public DateTime VpFecIni { get; set; }

    public DateTime VpFecFin { get; set; }

    public short UsCodigo { get; set; }

    public short VpStatus { get; set; }

    public int? VpNumFin { get; set; }

    public decimal? VpPuntos { get; set; }

    public string VpUltima { get; set; } = null!;
}
