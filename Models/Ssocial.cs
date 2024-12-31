using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Ssocial
{
    public string TbCodigo { get; set; } = null!;

    public string TbElement { get; set; } = null!;

    public string TbIngles { get; set; } = null!;

    public decimal TbNumero { get; set; }

    public string TbTexto { get; set; } = null!;

    public decimal TbPrimava { get; set; }

    public decimal TbDiasAg { get; set; }

    public string TbPago7 { get; set; } = null!;

    public string TbPrima7 { get; set; } = null!;

    public decimal TbPrimado { get; set; }

    public decimal TbDiasAd { get; set; }

    public string TbActivo { get; set; } = null!;

    public int Llave { get; set; }

    public virtual ICollection<Prestaci> Prestacis { get; set; } = new List<Prestaci>();
}
