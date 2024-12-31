using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class PolTipo
{
    public string PtCodigo { get; set; } = null!;

    public string PtNombre { get; set; } = null!;

    public string PtIngles { get; set; } = null!;

    public decimal PtNumero { get; set; }

    public string PtTexto { get; set; } = null!;

    public short PtReporte { get; set; }

    public int Llave { get; set; }

    public virtual ICollection<PolHead> PolHeads { get; set; } = new List<PolHead>();
}
