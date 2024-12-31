using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Establec
{
    public string EsCodigo { get; set; } = null!;

    public string EsElement { get; set; } = null!;

    public string EsIngles { get; set; } = null!;

    public decimal EsNumero { get; set; }

    public string EsTexto { get; set; } = null!;

    public string EsCalle { get; set; } = null!;

    public string EsNumext { get; set; } = null!;

    public string EsNumint { get; set; } = null!;

    public string EsColonia { get; set; } = null!;

    public string EsCiudad { get; set; } = null!;

    public string EsEntidad { get; set; } = null!;

    public string EsCodpost { get; set; } = null!;

    public string EsActivo { get; set; } = null!;

    public int Llave { get; set; }
}
