using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Clasitmp
{
    public int CbCodigo { get; set; }

    public DateTime AuFecha { get; set; }

    public string CbClasifi { get; set; } = null!;

    public string CbTurno { get; set; } = null!;

    public string CbPuesto { get; set; } = null!;

    public string CbNivel1 { get; set; } = null!;

    public string CbNivel2 { get; set; } = null!;

    public string CbNivel3 { get; set; } = null!;

    public string CbNivel4 { get; set; } = null!;

    public string CbNivel5 { get; set; } = null!;

    public string CbNivel6 { get; set; } = null!;

    public string CbNivel7 { get; set; } = null!;

    public string CbNivel8 { get; set; } = null!;

    public string CbNivel9 { get; set; } = null!;

    public short UsCodigo { get; set; }

    public DateTime CtFecha { get; set; }

    public short UsCodOk { get; set; }

    public DateTime CtFecOk { get; set; }

    public int Llave { get; set; }

    public virtual Colabora CbCodigoNavigation { get; set; } = null!;
}
