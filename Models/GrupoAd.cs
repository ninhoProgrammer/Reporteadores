using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class GrupoAd
{
    public string GxCodigo { get; set; } = null!;

    public string GxTitulo { get; set; } = null!;

    public short GxPosicio { get; set; }

    public int Llave { get; set; }
}
