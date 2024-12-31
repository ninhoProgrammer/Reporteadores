using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class VRentall
{
    public int AaSource { get; set; }

    public string CmCodigo { get; set; } = null!;

    public short GrCodigo { get; set; }

    public short AxNumero { get; set; }
}
