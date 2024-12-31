using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Aguinal
{
    public short AgYear { get; set; }

    public int CbCodigo { get; set; }

    public DateTime AgFecIng { get; set; }

    public short AgBase { get; set; }

    public short AgFaltas { get; set; }

    public short AgIncapa { get; set; }

    public short AgNetos { get; set; }

    public decimal AgDiasAg { get; set; }

    public decimal AgSalario { get; set; }

    public decimal AgAguinal { get; set; }

    public short UsCodigo { get; set; }

    public int Llave { get; set; }

    public virtual Colabora CbCodigoNavigation { get; set; } = null!;
}
