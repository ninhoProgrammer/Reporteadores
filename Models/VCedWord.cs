using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class VCedWord
{
    public int CeFolio { get; set; }

    public string WoNumber { get; set; } = null!;

    public int CwPosicio { get; set; }

    public decimal CwPiezas { get; set; }

    public string? VDescrip { get; set; }

    public string? VarCodigo { get; set; }

    public DateTime? CeFecha { get; set; }

    public short? UsCodigo { get; set; }

    public short? CeTipo { get; set; }

    public string? CeComenta { get; set; }

    public string? ArCodigo { get; set; }

    public string? OpNumber { get; set; }

    public string? CeArea { get; set; }

    public string? CeHora { get; set; }

    public short? CeStatus { get; set; }

    public string? CeMod1 { get; set; }

    public string? CeMod2 { get; set; }

    public string? CeMod3 { get; set; }

    public string? CeTmuerto { get; set; }

    public decimal? CePiezas { get; set; }

    public string? CeMulti { get; set; }

    public decimal? CeTiempo { get; set; }

    public string Setcambios { get; set; } = null!;
}
