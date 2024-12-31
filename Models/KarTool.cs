using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class KarTool
{
    public int CbCodigo { get; set; }

    public DateTime KtFecIni { get; set; }

    public string ToCodigo { get; set; } = null!;

    public string KtReferen { get; set; } = null!;

    public string KtMotFin { get; set; } = null!;

    public string KtTalla { get; set; } = null!;

    public string KtActivo { get; set; } = null!;

    public string KtComenta { get; set; } = null!;

    public DateTime KtFecFin { get; set; }

    public short UsCodigo { get; set; }

    public int Llave { get; set; }

    public virtual Colabora CbCodigoNavigation { get; set; } = null!;

    public virtual Tool ToCodigoNavigation { get; set; } = null!;
}
