using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Municipio
{
    public string TbCodigo { get; set; } = null!;

    public string TbElement { get; set; } = null!;

    public string TbIngles { get; set; } = null!;

    public decimal TbNumero { get; set; }

    public string TbTexto { get; set; } = null!;

    public string TbEntidad { get; set; } = null!;

    public short TbStps { get; set; }

    public int Llave { get; set; }
}
