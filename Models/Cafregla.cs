using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Cafregla
{
    public short ClCodigo { get; set; }

    public string ClLetrero { get; set; } = null!;

    public string ClActivo { get; set; } = null!;

    public string ClQuery { get; set; } = null!;

    public string ClFiltro { get; set; } = null!;

    public string ClTipos { get; set; } = null!;

    public string ClTotal { get; set; } = null!;

    public short ClLimite { get; set; }

    public string ClExtras { get; set; } = null!;

    public int Llave { get; set; }
}
