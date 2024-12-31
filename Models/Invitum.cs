using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Invitum
{
    public int IvCodigo { get; set; }

    public string IvNombre { get; set; } = null!;

    public string IvIdNum { get; set; } = null!;

    public int CbCodigo { get; set; }

    public string IvActivo { get; set; } = null!;

    public DateTime IvFecIni { get; set; }

    public DateTime IvFecFin { get; set; }

    public int IvTope1 { get; set; }

    public int IvTope2 { get; set; }

    public int IvTope3 { get; set; }

    public int IvTope4 { get; set; }

    public int IvTope5 { get; set; }

    public int IvTope6 { get; set; }

    public int IvTope7 { get; set; }

    public int IvTope8 { get; set; }

    public int IvTope9 { get; set; }

    public int Llave { get; set; }

    public virtual ICollection<CafInv> CafInvs { get; set; } = new List<CafInv>();
}
