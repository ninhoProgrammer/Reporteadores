using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class VGrupo
{
    public short GrCodigo { get; set; }

    public string GrDescrip { get; set; } = null!;

    public short GrPadre { get; set; }
}
