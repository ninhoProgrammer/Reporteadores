using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Festivo
{
    public string TuCodigo { get; set; } = null!;

    public short FeMes { get; set; }

    public short FeDia { get; set; }

    public string FeDescrip { get; set; } = null!;

    public short FeTipo { get; set; }

    public DateTime FeCambio { get; set; }

    public int Llave { get; set; }

    public short FeYear { get; set; }

    public virtual Turno TuCodigoNavigation { get; set; } = null!;
}
