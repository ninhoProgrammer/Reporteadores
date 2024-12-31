using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class DescPto
{
    public string PuCodigo { get; set; } = null!;

    public string DtCodigo { get; set; } = null!;

    public short DpOrden { get; set; }

    public string DpText01 { get; set; } = null!;

    public string DpText02 { get; set; } = null!;

    public string DpText03 { get; set; } = null!;

    public string? DpMemo01 { get; set; }

    public string? DpMemo02 { get; set; }

    public string? DpMemo03 { get; set; }

    public decimal DpNume01 { get; set; }

    public DateTime DpFech01 { get; set; }

    public int Llave { get; set; }

    public virtual Desctipo DtCodigoNavigation { get; set; } = null!;

    public virtual Perfil PuCodigoNavigation { get; set; } = null!;
}
