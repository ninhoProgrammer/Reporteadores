using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Topera
{
    public string ToCodigo { get; set; } = null!;

    public string ToDescrip { get; set; } = null!;

    public string ToIngles { get; set; } = null!;

    public decimal ToNumero { get; set; }

    public string ToTexto { get; set; } = null!;

    public int Llave { get; set; }
}
