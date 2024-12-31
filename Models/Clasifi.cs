using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Clasifi
{
    public string TbCodigo { get; set; } = null!;

    public string TbElement { get; set; } = null!;

    public string TbIngles { get; set; } = null!;

    public decimal TbNumero { get; set; }

    public string TbTexto { get; set; } = null!;

    public decimal TbSalario { get; set; }

    public string TbOp1 { get; set; } = null!;

    public string TbOp2 { get; set; } = null!;

    public string TbOp3 { get; set; } = null!;

    public string TbOp4 { get; set; } = null!;

    public string TbOp5 { get; set; } = null!;

    public string TbSubCta { get; set; } = null!;

    public string TbActivo { get; set; } = null!;

    public int Llave { get; set; }
}
