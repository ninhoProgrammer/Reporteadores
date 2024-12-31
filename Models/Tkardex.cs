using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Tkardex
{
    public string TbCodigo { get; set; } = null!;

    public string TbElement { get; set; } = null!;

    public string TbIngles { get; set; } = null!;

    public decimal TbNumero { get; set; }

    public string TbTexto { get; set; } = null!;

    public short TbNivel { get; set; }

    public string TbSistema { get; set; } = null!;

    public int Llave { get; set; }

    public virtual ICollection<Kardex> Kardices { get; set; } = new List<Kardex>();
}
