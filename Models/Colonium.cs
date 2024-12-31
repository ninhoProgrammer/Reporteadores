using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Colonium
{
    public string TbCodigo { get; set; } = null!;

    public string TbElement { get; set; } = null!;

    public string TbCodpost { get; set; } = null!;

    public string TbClinica { get; set; } = null!;

    public string TbZona { get; set; } = null!;

    public string TbIngles { get; set; } = null!;

    public decimal TbNumero { get; set; }

    public string TbTexto { get; set; } = null!;

    public int Llave { get; set; }
}
