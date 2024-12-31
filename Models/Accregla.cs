using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Accregla
{
    public short AeCodigo { get; set; }

    public short AeTipo { get; set; }

    public string AeLetrero { get; set; } = null!;

    public string AeFormula { get; set; } = null!;

    public string QuCodigo { get; set; } = null!;

    public string AeFiltro { get; set; } = null!;

    public short AeSeveri { get; set; }

    public string AeActivo { get; set; } = null!;

    public short UsCodigo { get; set; }

    public int Llave { get; set; }
}
