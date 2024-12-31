using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Imagen
{
    public int CbCodigo { get; set; }

    public string ImTipo { get; set; } = null!;

    public byte[]? ImBlob { get; set; }

    public string ImObserva { get; set; } = null!;

    public int Llave { get; set; }

    public virtual Colabora CbCodigoNavigation { get; set; } = null!;
}
