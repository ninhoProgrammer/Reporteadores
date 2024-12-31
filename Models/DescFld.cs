using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class DescFld
{
    public string DtCodigo { get; set; } = null!;

    public short DfOrden { get; set; }

    public string DfTitulo { get; set; } = null!;

    public string DfCampo { get; set; } = null!;

    public short DfControl { get; set; }

    public int DfLimite { get; set; }

    public string? DfValores { get; set; }

    public int Llave { get; set; }

    public virtual Desctipo DtCodigoNavigation { get; set; } = null!;
}
