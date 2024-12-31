using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class VVpunto
{
    public int VpFolio { get; set; }

    public short VtOrden { get; set; }

    public short VtCual { get; set; }

    public string? VtComenta { get; set; }

    public decimal? VtPuntos { get; set; }

    public short? VlCodigo { get; set; }

    public short? VsOrden { get; set; }

    public short? VnOrden { get; set; }

    public string? VnCodigo { get; set; }

    public string? VnNombre { get; set; }

    public string? VnDescrip { get; set; }

    public string? VnIngles { get; set; }

    public string? VnDesIng { get; set; }

    public decimal? VnNumero { get; set; }

    public string? VnTexto { get; set; }

    public decimal? VnPuntos { get; set; }

    public int? VnColor { get; set; }

    public int? Llave { get; set; }
}
