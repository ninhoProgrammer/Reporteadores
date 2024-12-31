using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Califica
{
    public string CaCodigo { get; set; } = null!;

    public string CaDescrip { get; set; } = null!;

    public string CaIngles { get; set; } = null!;

    public decimal CaNumero { get; set; }

    public string CaTexto { get; set; } = null!;

    public short CaOrden { get; set; }

    public string CaGrupo { get; set; } = null!;

    public int Llave { get; set; }

    public virtual ICollection<CompCal> CompCals { get; set; } = new List<CompCal>();
}
