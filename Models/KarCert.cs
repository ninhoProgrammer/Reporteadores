using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class KarCert
{
    public int CbCodigo { get; set; }

    public DateTime KiFecCer { get; set; }

    public string CiCodigo { get; set; } = null!;

    public string KiFolio { get; set; } = null!;

    public short KiRenovar { get; set; }

    public string KiAprobo { get; set; } = null!;

    public decimal KiCalif1 { get; set; }

    public decimal KiCalif2 { get; set; }

    public decimal KiCalif3 { get; set; }

    public string KiSinod1 { get; set; } = null!;

    public string KiSinod2 { get; set; } = null!;

    public string KiSinod3 { get; set; } = null!;

    public string? KiObserva { get; set; }

    public short UsCodigo { get; set; }

    public int Llave { get; set; }

    public virtual Colabora CbCodigoNavigation { get; set; } = null!;

    public virtual Certific CiCodigoNavigation { get; set; } = null!;
}
