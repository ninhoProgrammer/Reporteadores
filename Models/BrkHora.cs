using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class BrkHora
{
    public string BrCodigo { get; set; } = null!;

    public string BhInicio { get; set; } = null!;

    public short BhTiempo { get; set; }

    public string BhMotivo { get; set; } = null!;

    public int Llave { get; set; }

    public virtual Break BrCodigoNavigation { get; set; } = null!;
}
