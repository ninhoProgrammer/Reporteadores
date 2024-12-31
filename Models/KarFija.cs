using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class KarFija
{
    public int CbCodigo { get; set; }

    public DateTime CbFecha { get; set; }

    public string CbTipo { get; set; } = null!;

    public short KfFolio { get; set; }

    public string KfCodigo { get; set; } = null!;

    public decimal KfMonto { get; set; }

    public decimal KfGravado { get; set; }

    public short KfImss { get; set; }

    public int Llave { get; set; }

    public virtual Kardex Kardex { get; set; } = null!;
}
