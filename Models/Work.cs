using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Work
{
    public int CbCodigo { get; set; }

    public DateTime AuFecha { get; set; }

    public string WkHoraA { get; set; } = null!;

    public short WkFolio { get; set; }

    public string OpNumber { get; set; } = null!;

    public string WoNumber { get; set; } = null!;

    public string ArCodigo { get; set; } = null!;

    public DateTime WkFechaR { get; set; }

    public string WkHoraR { get; set; } = null!;

    public string WkHoraI { get; set; } = null!;

    public string WkLinxId { get; set; } = null!;

    public decimal WkTiempo { get; set; }

    public decimal WkPreCal { get; set; }

    public short WkStatus { get; set; }

    public string WkMod1 { get; set; } = null!;

    public string WkMod2 { get; set; } = null!;

    public string WkMod3 { get; set; } = null!;

    public string WkTmuerto { get; set; } = null!;

    public decimal WkHrsOrd { get; set; }

    public decimal WkHrs2ex { get; set; }

    public decimal WkHrs3ex { get; set; }

    public string WkManual { get; set; } = null!;

    public decimal WkPiezas { get; set; }

    public decimal WkStdHr { get; set; }

    public decimal WkStdCst { get; set; }

    public string CbPuesto { get; set; } = null!;

    public string CbArea { get; set; } = null!;

    public short WkTipo { get; set; }

    public int WkCedula { get; set; }

    public int Llave { get; set; }
}
