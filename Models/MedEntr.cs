using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class MedEntr
{
    public string MeCodigo { get; set; } = null!;

    public int ExCodigo { get; set; }

    public DateTime MtFecha { get; set; }

    public decimal MtCantida { get; set; }

    public string MtComenta { get; set; } = null!;

    public short UsCodigo { get; set; }

    public int Llave { get; set; }

    public virtual Expedien ExCodigoNavigation { get; set; } = null!;

    public virtual Medicina MeCodigoNavigation { get; set; } = null!;
}
