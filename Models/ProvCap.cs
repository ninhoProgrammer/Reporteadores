using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class ProvCap
{
    public string PcCodigo { get; set; } = null!;

    public string PcNombre { get; set; } = null!;

    public string PcDirecci { get; set; } = null!;

    public string PcCiudad { get; set; } = null!;

    public string PcEstado { get; set; } = null!;

    public string PcPais { get; set; } = null!;

    public string PcCodpost { get; set; } = null!;

    public string PcRfc { get; set; } = null!;

    public string PcContact { get; set; } = null!;

    public string PcTel { get; set; } = null!;

    public string PcFax { get; set; } = null!;

    public string PcEmail { get; set; } = null!;

    public string PcWeb { get; set; } = null!;

    public decimal PcNumero { get; set; }

    public string PcTexto { get; set; } = null!;

    public string PcActivo { get; set; } = null!;

    public int Llave { get; set; }
}
