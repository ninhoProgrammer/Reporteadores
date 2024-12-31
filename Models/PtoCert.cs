using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class PtoCert
{
    public string CiCodigo { get; set; } = null!;

    public string PuCodigo { get; set; } = null!;

    public short PcDias { get; set; }

    public string PcOpciona { get; set; } = null!;

    public string PcLista { get; set; } = null!;

    public int Llave { get; set; }

    public virtual ICollection<Cernivel> Cernivels { get; set; } = new List<Cernivel>();

    public virtual Certific CiCodigoNavigation { get; set; } = null!;

    public virtual Puesto PuCodigoNavigation { get; set; } = null!;
}
