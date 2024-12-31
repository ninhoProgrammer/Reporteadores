using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Area
{
    public string TbCodigo { get; set; } = null!;

    public string TbElement { get; set; } = null!;

    public string TbIngles { get; set; } = null!;

    public decimal TbNumero { get; set; }

    public string TbTexto { get; set; } = null!;

    public string CbNivel1 { get; set; } = null!;

    public string CbNivel2 { get; set; } = null!;

    public string CbNivel3 { get; set; } = null!;

    public string CbNivel4 { get; set; } = null!;

    public string CbNivel5 { get; set; } = null!;

    public string CbNivel6 { get; set; } = null!;

    public string CbNivel7 { get; set; } = null!;

    public string CbNivel8 { get; set; } = null!;

    public string CbNivel9 { get; set; } = null!;

    public string TbBreak1 { get; set; } = null!;

    public string TbBreak2 { get; set; } = null!;

    public string TbBreak3 { get; set; } = null!;

    public string TbBreak4 { get; set; } = null!;

    public string TbBreak5 { get; set; } = null!;

    public string TbBreak6 { get; set; } = null!;

    public string TbBreak7 { get; set; } = null!;

    public string TbOpera { get; set; } = null!;

    public string TbOpUni { get; set; } = null!;

    public short ArTipo { get; set; }

    public short ArShift { get; set; }

    public string ArPriHor { get; set; } = null!;

    public int Llave { get; set; }
}
