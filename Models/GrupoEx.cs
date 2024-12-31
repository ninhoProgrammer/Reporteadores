using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class GrupoEx
{
    public string GxCodigo { get; set; } = null!;

    public string GxTitulo { get; set; } = null!;

    public short GxPosicio { get; set; }

    public int Llave { get; set; }
}
