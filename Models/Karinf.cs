using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Karinf
{
    public int CbCodigo { get; set; }

    public DateTime KiFecha { get; set; }

    public short KiTipo { get; set; }

    public short CbInftipo { get; set; }

    public string CbInfcred { get; set; } = null!;

    public decimal CbInftasa { get; set; }

    public string CbInfdism { get; set; } = null!;

    public string KiComenta { get; set; } = null!;

    public short UsCodigo { get; set; }

    public DateTime KiCaptura { get; set; }

    public DateTime? CbInfAnt { get; set; }

    public virtual Colabora CbCodigoNavigation { get; set; } = null!;
}
