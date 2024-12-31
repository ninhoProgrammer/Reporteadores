using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Cursopre
{
    public string CuCodigo { get; set; } = null!;

    public string CpCurso { get; set; } = null!;

    public string CpComenta { get; set; } = null!;

    public string CpOpciona { get; set; } = null!;

    public int Llave { get; set; }

    public virtual Curso CuCodigoNavigation { get; set; } = null!;
}
