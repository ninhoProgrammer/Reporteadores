using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class MotBaja
{
    public string TbCodigo { get; set; } = null!;

    public string TbElement { get; set; } = null!;

    public string TbIngles { get; set; } = null!;

    public short TbImss { get; set; }

    public decimal TbNumero { get; set; }

    public string TbTexto { get; set; } = null!;

    public int Llave { get; set; }
}
