using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Break
{
    public string BrCodigo { get; set; } = null!;

    public string BrNombre { get; set; } = null!;

    public string BrIngles { get; set; } = null!;

    public decimal BrNumero { get; set; }

    public string BrTexto { get; set; } = null!;

    public int Llave { get; set; }

    public virtual ICollection<BrkHora> BrkHoras { get; set; } = new List<BrkHora>();
}
