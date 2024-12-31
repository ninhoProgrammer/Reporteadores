using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Tprestum
{
    public string TbCodigo { get; set; } = null!;

    public string TbElement { get; set; } = null!;

    public string TbIngles { get; set; } = null!;

    public decimal TbNumero { get; set; }

    public string TbTexto { get; set; } = null!;

    public short TbConcept { get; set; }

    public short TbRelativ { get; set; }

    public short TbLiquida { get; set; }

    public short TbAlta { get; set; }

    public short TbPriorid { get; set; }

    public decimal TbTasa1 { get; set; }

    public decimal TbTasa2 { get; set; }

    public decimal TbTasa3 { get; set; }

    public int Llave { get; set; }

    public virtual ICollection<Prestamo> Prestamos { get; set; } = new List<Prestamo>();
}
