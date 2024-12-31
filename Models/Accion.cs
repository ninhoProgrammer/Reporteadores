using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Accion
{
    public string AnCodigo { get; set; } = null!;

    public string CuCodigo { get; set; } = null!;

    public string AnNombre { get; set; } = null!;

    public string AnIngles { get; set; } = null!;

    public decimal AnNumero { get; set; }

    public string AnTexto { get; set; } = null!;

    public short AnClase { get; set; }

    public string AnTipMat { get; set; } = null!;

    public string? AnDetalle { get; set; }

    public short AnDias { get; set; }

    public string AnUrl { get; set; } = null!;

    public int Llave { get; set; }

    public virtual ICollection<CompMap> CompMaps { get; set; } = new List<CompMap>();

    public virtual Curso CuCodigoNavigation { get; set; } = null!;

    public virtual ICollection<EmpPlan> EmpPlans { get; set; } = new List<EmpPlan>();
}
