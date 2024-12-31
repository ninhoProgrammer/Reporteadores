using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Folio
{
    public short FlCodigo { get; set; }

    public string FlDescrip { get; set; } = null!;

    public short FlReporte { get; set; }

    public string FlMonto { get; set; } = null!;

    public string FlRepite { get; set; } = null!;

    public decimal FlMoneda { get; set; }

    public string FlCeros { get; set; } = null!;

    public int FlInicial { get; set; }

    public int FlFinal { get; set; }

    public string FlFiltro { get; set; } = null!;

    public string QuCodigo { get; set; } = null!;

    public int Llave { get; set; }

    public virtual ICollection<Ordfolio> Ordfolios { get; set; } = new List<Ordfolio>();
}
