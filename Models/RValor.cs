using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class RValor
{
    public short LvCodigo { get; set; }

    public short VlCodigo { get; set; }

    public string VlDescrip { get; set; } = null!;

    public int Llave { get; set; }

    public short? VlVersion { get; set; }

    public short? UsCodigo { get; set; }

    public virtual RListaval LvCodigoNavigation { get; set; } = null!;
}
