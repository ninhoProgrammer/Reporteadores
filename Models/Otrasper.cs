using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Otrasper
{
    public string TbCodigo { get; set; } = null!;

    public string TbElement { get; set; } = null!;

    public string TbIngles { get; set; } = null!;

    public decimal TbNumero { get; set; }

    public string TbTexto { get; set; } = null!;

    public short TbTipo { get; set; }

    public decimal TbMonto { get; set; }

    public decimal TbTasa { get; set; }

    public short TbImss { get; set; }

    public short TbIspt { get; set; }

    public decimal TbTope { get; set; }

    public int Llave { get; set; }
}
