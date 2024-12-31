using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class CurAsi
{
    public int RvFolio { get; set; }

    public int SeFolio { get; set; }

    public int CbCodigo { get; set; }

    public string CsAsistio { get; set; } = null!;

    public decimal CsEva1 { get; set; }

    public decimal CsEva2 { get; set; }

    public decimal CsEva3 { get; set; }

    public decimal CsEvaFin { get; set; }

    public string CsComenta { get; set; } = null!;

    public int Llave { get; set; }

    public virtual Inscrito Inscrito { get; set; } = null!;

    public virtual Reserva RvFolioNavigation { get; set; } = null!;
}
