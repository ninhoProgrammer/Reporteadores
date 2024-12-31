using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class MotTool
{
    public string TbCodigo { get; set; } = null!;

    public string TbElement { get; set; } = null!;

    public string TbIngles { get; set; } = null!;

    public decimal TbNumero { get; set; }

    public string TbTexto { get; set; } = null!;

    public short TbTipo { get; set; }

    public string TbPresta { get; set; } = null!;

    public int Llave { get; set; }
}
