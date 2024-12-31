using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class TArt80
{
    public short NuCodigo { get; set; }

    public DateTime TiInicio { get; set; }

    public string TiDescrip { get; set; } = null!;

    public int Llave { get; set; }

    public virtual ICollection<Art80> Art80s { get; set; } = new List<Art80>();

    public virtual Numerica NuCodigoNavigation { get; set; } = null!;
}
