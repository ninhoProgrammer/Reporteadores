using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Entidad
{
    public string TbCodigo { get; set; } = null!;

    public string TbElement { get; set; } = null!;

    public string TbIngles { get; set; } = null!;

    public decimal TbNumero { get; set; }

    public string TbTexto { get; set; } = null!;

    public string TbCurp { get; set; } = null!;

    public int Llave { get; set; }

    public short TbStps { get; set; }
}
