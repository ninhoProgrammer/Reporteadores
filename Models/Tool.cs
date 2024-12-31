using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Tool
{
    public string ToCodigo { get; set; } = null!;

    public string ToDescrip { get; set; } = null!;

    public string ToIngles { get; set; } = null!;

    public decimal ToNumero { get; set; }

    public string ToTexto { get; set; } = null!;

    public decimal ToCosto { get; set; }

    public decimal ToValRep { get; set; }

    public decimal ToValBaj { get; set; }

    public short ToVida { get; set; }

    public short ToDescto { get; set; }

    public int Llave { get; set; }

    public virtual ICollection<KarTool> KarTools { get; set; } = new List<KarTool>();

    public virtual ICollection<Ptotool> Ptotools { get; set; } = new List<Ptotool>();
}
