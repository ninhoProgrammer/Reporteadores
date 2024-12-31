using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class EmpProg
{
    public int CbCodigo { get; set; }

    public string CuCodigo { get; set; } = null!;

    public short EpDias { get; set; }

    public string EpOpciona { get; set; } = null!;

    public int Llave { get; set; }

    public DateTime? EpFecha { get; set; }

    public string? EpPordias { get; set; }

    public string? EpGlobal { get; set; }

    public virtual Colabora CbCodigoNavigation { get; set; } = null!;

    public virtual Curso CuCodigoNavigation { get; set; } = null!;
}
