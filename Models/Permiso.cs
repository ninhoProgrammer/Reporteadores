using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Permiso
{
    public int CbCodigo { get; set; }

    public DateTime PmFecIni { get; set; }

    public short PmClasifi { get; set; }

    public string PmComenta { get; set; } = null!;

    public short PmDias { get; set; }

    public DateTime PmFecFin { get; set; }

    public DateTime PmCaptura { get; set; }

    public short UsCodigo { get; set; }

    public string PmTipo { get; set; } = null!;

    public string PmNumero { get; set; } = null!;

    public string PmGlobal { get; set; } = null!;

    public int Llave { get; set; }

    public virtual Colabora CbCodigoNavigation { get; set; } = null!;
}
