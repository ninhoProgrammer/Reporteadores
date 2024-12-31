using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class ScrapV
{
    public int CsFolio { get; set; }

    public short ScFolio { get; set; }

    public string CnCodigo { get; set; } = null!;

    public string ScMotivo { get; set; } = null!;

    public decimal DePiezas { get; set; }

    public string DeComenta { get; set; } = null!;

    public string? CsArea { get; set; }

    public DateTime? CsFecha { get; set; }

    public string? CsHora { get; set; }

    public string? WoNumber { get; set; }

    public string? ArCodigo { get; set; }

    public string? OpNumber { get; set; }

    public DateTime? CsFecFab { get; set; }

    public decimal? CsTamlote { get; set; }

    public string? CsComenta { get; set; }

    public string? CsObserva { get; set; }

    public decimal? CsNumero1 { get; set; }

    public decimal? CsNumero2 { get; set; }

    public string? CsTexto1 { get; set; }

    public string? CsTexto2 { get; set; }

    public short? UsCodigo { get; set; }
}
