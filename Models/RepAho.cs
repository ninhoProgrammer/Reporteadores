using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class RepAho
{
    public short RaYear { get; set; }

    public string TbCodigo { get; set; } = null!;

    public int CbCodigo { get; set; }

    public decimal RaAhorro { get; set; }

    public decimal RaReparto { get; set; }

    public short UsCodigo { get; set; }

    public int Llave { get; set; }

    public virtual Colabora CbCodigoNavigation { get; set; } = null!;

    public virtual Tahorro TbCodigoNavigation { get; set; } = null!;
}
