using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Tahorro
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

    public string TbPresta { get; set; } = null!;

    public decimal TbTasa1 { get; set; }

    public decimal TbTasa2 { get; set; }

    public decimal TbTasa3 { get; set; }

    public int Llave { get; set; }

    public DateTime? TbFecIni { get; set; }

    public DateTime? TbFecFin { get; set; }

    public string? TbValRan { get; set; }

    public virtual ICollection<Ahorro> Ahorros { get; set; } = new List<Ahorro>();

    public virtual ICollection<Ctabanco> Ctabancos { get; set; } = new List<Ctabanco>();

    public virtual ICollection<RepAho> RepAhos { get; set; } = new List<RepAho>();
}
