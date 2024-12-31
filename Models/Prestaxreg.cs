using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Prestaxreg
{
    public short RpCodigo { get; set; }

    public string TbCodigo { get; set; } = null!;

    public int Llave { get; set; }

    public virtual Reglaprest RpCodigoNavigation { get; set; } = null!;
}
