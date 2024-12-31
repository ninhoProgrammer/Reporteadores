using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Inscrito
{
    public int SeFolio { get; set; }

    public int CbCodigo { get; set; }

    public short IcStatus { get; set; }

    public DateTime IcFecBaj { get; set; }

    public string IcComenta { get; set; } = null!;

    public decimal IcEva1 { get; set; }

    public decimal IcEva2 { get; set; }

    public decimal IcEva3 { get; set; }

    public decimal IcEvaFin { get; set; }

    public short UsCodigo { get; set; }

    public DateTime IcFecIns { get; set; }

    public string IcHorIns { get; set; } = null!;

    public int Llave { get; set; }

    public virtual Colabora CbCodigoNavigation { get; set; } = null!;

    public virtual ICollection<CurAsi> CurAsis { get; set; } = new List<CurAsi>();

    public virtual Sesion SeFolioNavigation { get; set; } = null!;
}
