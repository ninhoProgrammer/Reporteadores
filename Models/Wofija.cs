using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Wofija
{
    public int CbCodigo { get; set; }

    public string WoNumber { get; set; } = null!;

    public DateTime WfFecIni { get; set; }

    public string OpNumber { get; set; } = null!;

    public string ArCodigo { get; set; } = null!;

    public int Llave { get; set; }

    public virtual Colabora CbCodigoNavigation { get; set; } = null!;

    public virtual Worder WoNumberNavigation { get; set; } = null!;
}
