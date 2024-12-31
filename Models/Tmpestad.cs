using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Tmpestad
{
    public short TeUser { get; set; }

    public short TeCodigo { get; set; }

    public DateTime TeFecha { get; set; }

    public decimal TeCargo { get; set; }

    public decimal TeAbono { get; set; }

    public decimal TeSaldo { get; set; }

    public short UsCodigo { get; set; }

    public string TeDescrip { get; set; } = null!;

    public int CbCodigo { get; set; }

    public string TeTipo { get; set; } = null!;

    public string TeReferen { get; set; } = null!;
}
