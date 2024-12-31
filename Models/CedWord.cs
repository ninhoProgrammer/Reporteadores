using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class CedWord
{
    public int CeFolio { get; set; }

    public string WoNumber { get; set; } = null!;

    public short CwPosicio { get; set; }

    public decimal CwPiezas { get; set; }

    public int Llave { get; set; }

    public virtual Cedula CeFolioNavigation { get; set; } = null!;
}
