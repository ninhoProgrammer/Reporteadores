using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class NivDime
{
    public string DmCodigo { get; set; } = null!;

    public string NpCodigo { get; set; } = null!;

    public string NdResumen { get; set; } = null!;

    public string? NdDescrip { get; set; }

    public int Llave { get; set; }

    public virtual Dimensio DmCodigoNavigation { get; set; } = null!;

    public virtual NivPto NpCodigoNavigation { get; set; } = null!;
}
