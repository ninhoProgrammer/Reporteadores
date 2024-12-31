using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class RDatosdef
{
    public short EnCodigo { get; set; }

    public short RdOrden { get; set; }

    public short RdEntidad { get; set; }

    public string AtCampo { get; set; } = null!;

    public short? RdVersion { get; set; }

    public short? UsCodigo { get; set; }
}
