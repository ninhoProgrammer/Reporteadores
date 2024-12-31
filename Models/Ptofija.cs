using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Ptofija
{
    public string PuCodigo { get; set; } = null!;

    public short PfFolio { get; set; }

    public string PfCodigo { get; set; } = null!;

    public int Llave { get; set; }

    public virtual Puesto PuCodigoNavigation { get; set; } = null!;
}
