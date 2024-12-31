using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Tcambio
{
    public DateTime TcFecIni { get; set; }

    public decimal TcMonto { get; set; }

    public decimal TcNumero { get; set; }

    public string TcTexto { get; set; } = null!;

    public int Llave { get; set; }
}
