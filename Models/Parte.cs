using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Parte
{
    public string ArCodigo { get; set; } = null!;

    public string ArNombre { get; set; } = null!;

    public string ArShort { get; set; } = null!;

    public string ArBarcode { get; set; } = null!;

    public decimal ArStdHr { get; set; }

    public decimal ArFactor { get; set; }

    public string TtCodigo { get; set; } = null!;

    public decimal ArStdCst { get; set; }

    public string ArIngles { get; set; } = null!;

    public int Llave { get; set; }

    public virtual ICollection<Defstep> Defsteps { get; set; } = new List<Defstep>();
}
