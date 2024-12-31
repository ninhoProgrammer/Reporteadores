using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class PolHead
{
    public short PeYear { get; set; }

    public short PeTipo { get; set; }

    public short PeNumero { get; set; }

    public string PtCodigo { get; set; } = null!;

    public short UsCodigo { get; set; }

    public DateTime PhFecha { get; set; }

    public string PhHora { get; set; } = null!;

    public short PhVeces { get; set; }

    public short PhReporte { get; set; }

    public short PhStatus { get; set; }

    public int Llave { get; set; }

    public virtual Periodo Periodo { get; set; } = null!;

    public virtual ICollection<Poliza> Polizas { get; set; } = new List<Poliza>();

    public virtual PolTipo PtCodigoNavigation { get; set; } = null!;
}
