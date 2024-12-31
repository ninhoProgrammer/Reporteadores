using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Consultum
{
    public int ExCodigo { get; set; }

    public DateTime CnFecha { get; set; }

    public string CnHorIni { get; set; } = null!;

    public string DaCodigo { get; set; } = null!;

    public string CnTipo { get; set; } = null!;

    public string CnMotivo { get; set; } = null!;

    public string? CnSintoma { get; set; }

    public string? CnExplora { get; set; }

    public string? CnObserva { get; set; }

    public string? CnDiagnos { get; set; }

    public short CnPulso { get; set; }

    public short CnRespira { get; set; }

    public decimal CnPeso { get; set; }

    public short CnTempera { get; set; }

    public decimal CnAltura { get; set; }

    public short CnPreSis { get; set; }

    public short CnPreDia { get; set; }

    public string? CnCuidado { get; set; }

    public string? CnReceta { get; set; }

    public short CnAvIzq { get; set; }

    public short CnAvDer { get; set; }

    public string CnEstTip { get; set; } = null!;

    public string CnEstDes { get; set; } = null!;

    public string CnEstHay { get; set; } = null!;

    public DateTime CnEstFec { get; set; }

    public string? CnEstRes { get; set; }

    public string? CnEstObs { get; set; }

    public string CnHorFin { get; set; } = null!;

    public string CnImss { get; set; } = null!;

    public short UsCodigo { get; set; }

    public DateTime CnFecMod { get; set; }

    public string CnSubSec { get; set; } = null!;

    public string CnDExt { get; set; } = null!;

    public byte[]? CnDBlob { get; set; }

    public string CnDObs { get; set; } = null!;

    public int Llave { get; set; }

    public virtual Expedien ExCodigoNavigation { get; set; } = null!;
}
