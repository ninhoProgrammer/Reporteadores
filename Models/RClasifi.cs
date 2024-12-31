using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class RClasifi
{
    public short RcCodigo { get; set; }

    public string RcNombre { get; set; } = null!;

    public short RcOrden { get; set; }

    public int Llave { get; set; }

    public string? RcActivo { get; set; }

    public short? RcVersion { get; set; }

    public short? RcModulo { get; set; }

    public short? UsCodigo { get; set; }

    public virtual ICollection<RClasAcc> RClasAccs { get; set; } = new List<RClasAcc>();

    public virtual ICollection<RClasEnt> RClasEnts { get; set; } = new List<RClasEnt>();

    public virtual ICollection<Reporte> Reportes { get; set; } = new List<Reporte>();
}
