using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Antespto
{
    public int CbCodigo { get; set; }

    public short ApFolio { get; set; }

    public string ApPuesto { get; set; } = null!;

    public string ApEmpresa { get; set; } = null!;

    public DateTime ApFecIni { get; set; }

    public DateTime ApFecFin { get; set; }

    public int Llave { get; set; }

    public virtual Colabora CbCodigoNavigation { get; set; } = null!;
}
