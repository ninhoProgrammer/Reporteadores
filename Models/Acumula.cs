using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Acumula
{
    public decimal AcMes01 { get; set; }

    public short AcYear { get; set; }

    public decimal AcMes02 { get; set; }

    public short CoNumero { get; set; }

    public decimal AcMes03 { get; set; }

    public decimal AcMes04 { get; set; }

    public decimal AcMes05 { get; set; }

    public decimal AcMes06 { get; set; }

    public decimal AcMes07 { get; set; }

    public decimal AcMes08 { get; set; }

    public decimal AcMes09 { get; set; }

    public decimal AcMes10 { get; set; }

    public decimal AcMes11 { get; set; }

    public decimal AcMes12 { get; set; }

    public decimal AcMes13 { get; set; }

    public int CbCodigo { get; set; }

    public decimal AcAnual { get; set; }

    public int Llave { get; set; }

    public virtual Colabora CbCodigoNavigation { get; set; } = null!;

    public virtual Concepto CoNumeroNavigation { get; set; } = null!;
}
