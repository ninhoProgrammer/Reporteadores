using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Entrena
{
    public string CuCodigo { get; set; } = null!;

    public string PuCodigo { get; set; } = null!;

    public short EnDias { get; set; }

    public string EnOpciona { get; set; } = null!;

    public string EnLista { get; set; } = null!;

    public int Llave { get; set; }

    public string? EnReprog { get; set; }

    public short? EnReDias { get; set; }

    public virtual Curso CuCodigoNavigation { get; set; } = null!;

    public virtual ICollection<Entnivel> Entnivels { get; set; } = new List<Entnivel>();

    public virtual Puesto PuCodigoNavigation { get; set; } = null!;
}
