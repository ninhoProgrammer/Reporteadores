using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Diccion
{
    public short DiClasifi { get; set; }

    public string DiNombre { get; set; } = null!;

    public string DiTitulo { get; set; } = null!;

    public short DiCalc { get; set; }

    public short DiAncho { get; set; }

    public string DiMascara { get; set; } = null!;

    public short DiTfield { get; set; }

    public string DiOrden { get; set; } = null!;

    public string DiRequier { get; set; } = null!;

    public short DiTrango { get; set; }

    public short DiNumero { get; set; }

    public string DiValorac { get; set; } = null!;

    public short DiRangoac { get; set; }

    public string DiClaves { get; set; } = null!;

    public string DiTcorto { get; set; } = null!;

    public string DiConfi { get; set; } = null!;

    public int Llave { get; set; }
}
