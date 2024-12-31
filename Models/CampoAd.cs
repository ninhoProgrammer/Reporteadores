using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class CampoAd
{
    public string CxNombre { get; set; } = null!;

    public string GxCodigo { get; set; } = null!;

    public short CxPosicio { get; set; }

    public string CxTitulo { get; set; } = null!;

    public short CxTipo { get; set; }

    public string CxDefault { get; set; } = null!;

    public short CxMostrar { get; set; }

    public short CxEntidad { get; set; }

    public int Llave { get; set; }

    public string? CxObliga { get; set; }
}
