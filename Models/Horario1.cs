using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Horario1
{
    public int Id { get; set; }

    public int? IdHorarios { get; set; }

    public string? Descripcion { get; set; }

    public string? DiaNum { get; set; }

    public string? IdJornada { get; set; }
}
