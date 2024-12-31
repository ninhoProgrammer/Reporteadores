using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class DefectV
{
    public int CiFolio { get; set; }

    public short DeFolio { get; set; }

    public string DeCodigo { get; set; } = null!;

    public decimal DePiezas { get; set; }

    public string DeComenta { get; set; } = null!;

    public string? CiArea { get; set; }

    public int? CeFolio { get; set; }

    public string? WoNumber { get; set; }

    public string? ArCodigo { get; set; }

    public DateTime? CiFecha { get; set; }

    public string? CiHora { get; set; }

    public short? UsCodigo { get; set; }

    public short? CiTipo { get; set; }

    public short? CiResult { get; set; }

    public string? CiComenta { get; set; }

    public string? CiObserva { get; set; }

    public decimal? CiTamlote { get; set; }

    public decimal? CiMuestra { get; set; }

    public short? CiTiempo { get; set; }

    public decimal? CiNumero1 { get; set; }

    public decimal? CiNumero2 { get; set; }
}
