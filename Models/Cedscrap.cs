using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Cedscrap
{
    public int CsFolio { get; set; }

    public string CsArea { get; set; } = null!;

    public DateTime CsFecha { get; set; }

    public string CsHora { get; set; } = null!;

    public string WoNumber { get; set; } = null!;

    public string ArCodigo { get; set; } = null!;

    public string OpNumber { get; set; } = null!;

    public DateTime CsFecFab { get; set; }

    public decimal CsTamlote { get; set; }

    public string CsComenta { get; set; } = null!;

    public string? CsObserva { get; set; }

    public decimal CsNumero1 { get; set; }

    public decimal CsNumero2 { get; set; }

    public string CsTexto1 { get; set; } = null!;

    public string CsTexto2 { get; set; } = null!;

    public short UsCodigo { get; set; }

    public int Llave { get; set; }

    public virtual ICollection<Scrap> Scraps { get; set; } = new List<Scrap>();
}
