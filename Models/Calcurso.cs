using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Calcurso
{
    public string CuCodigo { get; set; } = null!;

    public DateTime CcFecha { get; set; }

    public int Llave { get; set; }

    public virtual Curso CuCodigoNavigation { get; set; } = null!;
}
