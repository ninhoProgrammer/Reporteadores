using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Tmpfolio
{
    public short ToUser { get; set; }

    public int ToFolio { get; set; }

    public int CbCodigo { get; set; }

    public short PeYear { get; set; }

    public short PeTipo { get; set; }

    public short PeNumero { get; set; }
}
