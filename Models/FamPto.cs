using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class FamPto
{
    public string FpCodigo { get; set; } = null!;

    public string FpDescrip { get; set; } = null!;

    public string FpIngles { get; set; } = null!;

    public decimal FpNumero { get; set; }

    public string FpTexto { get; set; } = null!;

    public int Llave { get; set; }

    public virtual ICollection<CompFam> CompFams { get; set; } = new List<CompFam>();
}
