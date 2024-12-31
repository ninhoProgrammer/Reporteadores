using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Tmprotum
{
    public short TrUser { get; set; }

    public string TrGrupo { get; set; } = null!;

    public string TrDescrip { get; set; } = null!;

    public int TrInicio { get; set; }

    public int TrFinal { get; set; }

    public int TrAltas { get; set; }

    public int TrBajas { get; set; }

    public decimal TrProm { get; set; }

    public DateTime TrFecha { get; set; }
}
