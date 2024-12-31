using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class VVsubfact
{
    public short VlCodigo { get; set; }

    public short VsOrden { get; set; }

    public short VfOrden { get; set; }

    public string VsCodigo { get; set; } = null!;

    public string VsNombre { get; set; } = null!;

    public string? VsDescrip { get; set; }

    public string VsIngles { get; set; } = null!;

    public string? VsDesIng { get; set; }

    public decimal VsNumero { get; set; }

    public string VsTexto { get; set; } = null!;

    public int? VsNumNiv { get; set; }

    public decimal? VsMinPts { get; set; }

    public decimal? VsMaxPts { get; set; }
}
