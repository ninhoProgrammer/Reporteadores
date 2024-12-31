using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Tparte
{
    public string TtCodigo { get; set; } = null!;

    public string TtDescrip { get; set; } = null!;

    public string TtIngles { get; set; } = null!;

    public decimal TtNumero { get; set; }

    public string TtTexto { get; set; } = null!;

    public int Llave { get; set; }
}
