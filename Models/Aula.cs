using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Aula
{
    public string AlCodigo { get; set; } = null!;

    public string AlNombre { get; set; } = null!;

    public string AlIngles { get; set; } = null!;

    public decimal AlNumero { get; set; }

    public string AlTexto { get; set; } = null!;

    public int AlCupo { get; set; }

    public string AlDescrip { get; set; } = null!;

    public string AlActiva { get; set; } = null!;

    public int Llave { get; set; }
}
