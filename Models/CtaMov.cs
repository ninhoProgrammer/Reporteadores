using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class CtaMov
{
    public int CmFolio { get; set; }

    public string CtCodigo { get; set; } = null!;

    public string CmTipo { get; set; } = null!;

    public string CmDepRet { get; set; } = null!;

    public decimal CmMonto { get; set; }

    public string CmDescrip { get; set; } = null!;

    public int CmCheque { get; set; }

    public DateTime CmFecha { get; set; }

    public string CmBenefi { get; set; } = null!;

    public short CmStatus { get; set; }

    public decimal CmTotAho { get; set; }

    public decimal CmInteres { get; set; }

    public decimal CmSalPre { get; set; }

    public int CbCodigo { get; set; }

    public short PeYear { get; set; }

    public short PeTipo { get; set; }

    public short PeNumero { get; set; }

    public string PrReferen { get; set; } = null!;

    public string PrTipo { get; set; } = null!;

    public short CmPresta { get; set; }

    public decimal CmDeposit { get; set; }

    public decimal CmRetiro { get; set; }

    public virtual Ctabanco CtCodigoNavigation { get; set; } = null!;
}
