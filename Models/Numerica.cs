using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Numerica
{
    public short NuCodigo { get; set; }

    public string NuDescrip { get; set; } = null!;

    public string NuIngles { get; set; } = null!;

    public decimal NuNumero { get; set; }

    public string NuTexto { get; set; } = null!;

    public int Llave { get; set; }

    public virtual ICollection<TArt80> TArt80s { get; set; } = new List<TArt80>();
}
