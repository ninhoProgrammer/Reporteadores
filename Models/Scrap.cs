using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Scrap
{
    public int CsFolio { get; set; }

    public short ScFolio { get; set; }

    public string CnCodigo { get; set; } = null!;

    public string ScMotivo { get; set; } = null!;

    public decimal ScPiezas { get; set; }

    public string ScComenta { get; set; } = null!;

    public int Llave { get; set; }

    public virtual Componen CnCodigoNavigation { get; set; } = null!;

    public virtual Cedscrap CsFolioNavigation { get; set; } = null!;

    public virtual Motscrap ScMotivoNavigation { get; set; } = null!;
}
