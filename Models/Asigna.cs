using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Asigna
{
    public DateTime AsFecha { get; set; }

    public int CbCodigo { get; set; }

    public string CbNivel { get; set; } = null!;

    public short UsCodigo { get; set; }

    public int Llave { get; set; }

    public virtual Colabora CbCodigoNavigation { get; set; } = null!;
}
