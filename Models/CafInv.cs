using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class CafInv
{
    public int IvCodigo { get; set; }

    public DateTime CfFecha { get; set; }

    public string CfHora { get; set; } = null!;

    public string CfTipo { get; set; } = null!;

    public short CfComidas { get; set; }

    public short CfExtras { get; set; }

    public string CfReloj { get; set; } = null!;

    public short UsCodigo { get; set; }

    public short ClCodigo { get; set; }

    public string CfRegExt { get; set; } = null!;

    public int Llave { get; set; }

    public virtual Invitum IvCodigoNavigation { get; set; } = null!;
}
