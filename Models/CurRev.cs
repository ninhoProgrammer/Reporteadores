using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class CurRev
{
    public string CuCodigo { get; set; } = null!;

    public string ChRevisio { get; set; } = null!;

    public DateTime ChFecha { get; set; }

    public string ChObserva { get; set; } = null!;

    public short UsCodigo { get; set; }

    public int Llave { get; set; }

    public virtual Curso CuCodigoNavigation { get; set; } = null!;
}
