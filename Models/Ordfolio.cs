using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Ordfolio
{
    public short FlCodigo { get; set; }

    public short OfPosicio { get; set; }

    public string OfCampo { get; set; } = null!;

    public string OfTitulo { get; set; } = null!;

    public string OfDescend { get; set; } = null!;

    public int Llave { get; set; }

    public virtual Folio FlCodigoNavigation { get; set; } = null!;
}
