using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Poliza
{
    public short PeYear { get; set; }

    public short PeTipo { get; set; }

    public short PeNumero { get; set; }

    public string PtCodigo { get; set; } = null!;

    public short TpFolio { get; set; }

    public string TpCuenta { get; set; } = null!;

    public decimal TpCargo { get; set; }

    public decimal TpAbono { get; set; }

    public string TpComenta { get; set; } = null!;

    public string TpCarAbo { get; set; } = null!;

    public string TpTexto { get; set; } = null!;

    public short TpNumero { get; set; }

    public int Llave { get; set; }

    public virtual PolHead PolHead { get; set; } = null!;
}
