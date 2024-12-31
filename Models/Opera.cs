using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Opera
{
    public string OpNumber { get; set; } = null!;

    public string ToCodigo { get; set; } = null!;

    public string OpNombre { get; set; } = null!;

    public string OpDescrip { get; set; } = null!;

    public decimal OpStdHr { get; set; }

    public short OpTipo { get; set; }

    public decimal OpFactor { get; set; }

    public string CbNivel1 { get; set; } = null!;

    public string CbNivel2 { get; set; } = null!;

    public string CbNivel3 { get; set; } = null!;

    public string CbNivel4 { get; set; } = null!;

    public string CbNivel5 { get; set; } = null!;

    public string CbNivel6 { get; set; } = null!;

    public string CbNivel7 { get; set; } = null!;

    public string CbNivel8 { get; set; } = null!;

    public string CbNivel9 { get; set; } = null!;

    public decimal OpStdCst { get; set; }

    public string OpIngles { get; set; } = null!;

    public int Llave { get; set; }
}
