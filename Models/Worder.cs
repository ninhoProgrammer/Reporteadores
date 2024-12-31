using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Worder
{
    public string WoNumber { get; set; } = null!;

    public string ArCodigo { get; set; } = null!;

    public string WoDescrip { get; set; } = null!;

    public decimal WoQty { get; set; }

    public decimal WoFinishd { get; set; }

    public DateTime WoFecIni { get; set; }

    public DateTime WoFecFin { get; set; }

    public DateTime WoFecCie { get; set; }

    public short WoStatus { get; set; }

    public short WoLstStp { get; set; }

    public string WoTexto { get; set; } = null!;

    public decimal WoNumGen { get; set; }

    public int Llave { get; set; }

    public virtual ICollection<Step> Steps { get; set; } = new List<Step>();

    public virtual ICollection<Wofija> Wofijas { get; set; } = new List<Wofija>();
}
