using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class KarArea
{
    public int CbCodigo { get; set; }

    public DateTime KaFecha { get; set; }

    public string KaHora { get; set; } = null!;

    public string CbArea { get; set; } = null!;

    public short UsCodigo { get; set; }

    public DateTime KaFecMov { get; set; }

    public string KaHorMov { get; set; } = null!;

    public int Llave { get; set; }

    public virtual Colabora CbCodigoNavigation { get; set; } = null!;
}
