using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Suscrip
{
    public short ReCodigo { get; set; }

    public short UsCodigo { get; set; }

    public short SuFrecuen { get; set; }

    public short SuEnviar { get; set; }

    public short SuVacio { get; set; }

    public int Llave { get; set; }

    public virtual Reporte ReCodigoNavigation { get; set; } = null!;
}
