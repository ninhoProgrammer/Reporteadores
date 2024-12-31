using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Diagnost
{
    public string DaCodigo { get; set; } = null!;

    public string DaNombre { get; set; } = null!;

    public short DaTipo { get; set; }

    public string DaIngles { get; set; } = null!;

    public decimal DaNumero { get; set; }

    public string DaTexto { get; set; } = null!;

    public int Llave { get; set; }
}
