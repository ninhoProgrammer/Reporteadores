using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Valnivel
{
    public short VlCodigo { get; set; }

    public short VsOrden { get; set; }

    public short VnOrden { get; set; }

    public string VnCodigo { get; set; } = null!;

    public string VnNombre { get; set; } = null!;

    public string? VnDescrip { get; set; }

    public string VnIngles { get; set; } = null!;

    public string? VnDesIng { get; set; }

    public decimal VnNumero { get; set; }

    public string VnTexto { get; set; } = null!;

    public decimal VnPuntos { get; set; }

    public int VnColor { get; set; }

    public int Llave { get; set; }

    public virtual Vsubfact Vsubfact { get; set; } = null!;
}
