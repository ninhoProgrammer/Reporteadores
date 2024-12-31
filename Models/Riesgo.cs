using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Riesgo
{
    public short RiClase { get; set; }

    public short RiGrado { get; set; }

    public int RiIndice { get; set; }

    public decimal RiPrima { get; set; }

    public int Llave { get; set; }
}
