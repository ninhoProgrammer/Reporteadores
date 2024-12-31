using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class HorarioPersonal
{
    public int Id { get; set; }

    public string? CbCodigo { get; set; }

    public string? IdHorario { get; set; }

    public DateTime? FechInicio { get; set; }
}
