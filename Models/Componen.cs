using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Componen
{
    public string CnCodigo { get; set; } = null!;

    public string CnNombre { get; set; } = null!;

    public string CnShort { get; set; } = null!;

    public string CnBarcode { get; set; } = null!;

    public string CnIngles { get; set; } = null!;

    public decimal CnCosto { get; set; }

    public string CnUnidad { get; set; } = null!;

    public string CnDetalle { get; set; } = null!;

    public decimal CnNumero1 { get; set; }

    public decimal CnNumero2 { get; set; }

    public string CnTexto1 { get; set; } = null!;

    public string CnTexto2 { get; set; } = null!;

    public int Llave { get; set; }

    public virtual ICollection<Scrap> Scraps { get; set; } = new List<Scrap>();
}
