using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Conteo
{
    public DateTime CtFecha { get; set; }

    public string CtNivel1 { get; set; } = null!;

    public string CtNivel2 { get; set; } = null!;

    public string CtNivel3 { get; set; } = null!;

    public string CtNivel4 { get; set; } = null!;

    public string CtNivel5 { get; set; } = null!;

    public decimal CtNumero1 { get; set; }

    public decimal CtNumero2 { get; set; }

    public decimal CtNumero3 { get; set; }

    public string CtTexto1 { get; set; } = null!;

    public string CtTexto2 { get; set; } = null!;

    public decimal CtReal { get; set; }

    public int CtCuantos { get; set; }

    public int Llave { get; set; }
}
