using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class VGlobalAbg
{
    public short GlCodigo { get; set; }

    public string GlDescrip { get; set; } = null!;

    public string GlFormula { get; set; } = null!;

    public short GlTipo { get; set; }

    public short UsCodigo { get; set; }

    public DateTime GlCaptura { get; set; }

    public short GlNivel { get; set; }

    public int Llave { get; set; }

    public string? GlSql { get; set; }
}
