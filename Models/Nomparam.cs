using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Nomparam
{
    public short NpFolio { get; set; }

    public string NpNombre { get; set; } = null!;

    public string? NpFormula { get; set; }

    public short NpTipo { get; set; }

    public string NpDescrip { get; set; } = null!;

    public string NpActivo { get; set; } = null!;

    public int Llave { get; set; }
}
