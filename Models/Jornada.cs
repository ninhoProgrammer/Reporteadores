using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Jornada
{
    public int Id { get; set; }

    public int IdJornada { get; set; }

    public string Descripcion { get; set; } = null!;

    public DateTime TotalI1 { get; set; }

    public DateTime HE1 { get; set; }

    public DateTime TolF1 { get; set; }

    public DateTime TotalI2 { get; set; }

    public DateTime HS2 { get; set; }

    public DateTime TolF2 { get; set; }

    public DateTime TotalI3 { get; set; }

    public DateTime HE3 { get; set; }

    public DateTime TolF3 { get; set; }

    public DateTime TotalI4 { get; set; }

    public DateTime HS4 { get; set; }

    public DateTime TolF4 { get; set; }
}
