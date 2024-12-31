using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class VValplant
{
    public short VlCodigo { get; set; }

    public string VlNombre { get; set; } = null!;

    public string VlIngles { get; set; } = null!;

    public decimal VlNumero { get; set; }

    public string VlTexto { get; set; } = null!;

    public DateTime VlFecha { get; set; }

    public string? VlComenta { get; set; }

    public short VlTabPts { get; set; }

    public short VlStatus { get; set; }

    public int? VlNumFac { get; set; }

    public int? VlNumSub { get; set; }

    public decimal? VlMinPts { get; set; }

    public decimal? VlMaxPts { get; set; }

    public int? VlNumPto { get; set; }
}
