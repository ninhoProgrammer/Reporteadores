using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Tmprotai
{
    public short TrUser { get; set; }

    public int CbCodigo { get; set; }

    public string TrGrupo { get; set; } = null!;

    public string TrDescrip { get; set; } = null!;

    public DateTime CbFecIng { get; set; }

    public DateTime CbFecBaj { get; set; }
}
