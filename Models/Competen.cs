using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Competen
{
    public string CmCodigo { get; set; } = null!;

    public string TcCodigo { get; set; } = null!;

    public string CmDescrip { get; set; } = null!;

    public string CmIngles { get; set; } = null!;

    public decimal CmNumero { get; set; }

    public string CmTexto { get; set; } = null!;

    public string? CmDetalle { get; set; }

    public int Llave { get; set; }

    public virtual ICollection<CompCal> CompCals { get; set; } = new List<CompCal>();

    public virtual ICollection<CompFam> CompFams { get; set; } = new List<CompFam>();

    public virtual ICollection<CompMap> CompMaps { get; set; } = new List<CompMap>();

    public virtual ICollection<CompPto> CompPtos { get; set; } = new List<CompPto>();

    public virtual ICollection<EmpComp> EmpComps { get; set; } = new List<EmpComp>();
}
