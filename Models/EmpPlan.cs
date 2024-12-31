using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class EmpPlan
{
    public int CbCodigo { get; set; }

    public string AnCodigo { get; set; } = null!;

    public DateTime EpFecIni { get; set; }

    public DateTime EpFecPro { get; set; }

    public DateTime EpFecFin { get; set; }

    public DateTime EpFecMod { get; set; }

    public short UsCodigo { get; set; }

    public string EpTermino { get; set; } = null!;

    public string EpObserva { get; set; } = null!;

    public decimal EpResult { get; set; }

    public int Llave { get; set; }

    public virtual Accion AnCodigoNavigation { get; set; } = null!;

    public virtual Colabora CbCodigoNavigation { get; set; } = null!;
}
