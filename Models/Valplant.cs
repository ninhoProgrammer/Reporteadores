using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Valplant
{
    public short VlCodigo { get; set; }

    public string VlNombre { get; set; } = null!;

    public string VlIngles { get; set; } = null!;

    public decimal VlNumero { get; set; }

    public string VlTexto { get; set; } = null!;

    public DateTime VlFecha { get; set; }

    public string? VlComenta { get; set; }

    public short VlTabPts { get; set; }

    public short VlStatus { get; set; }

    public virtual ICollection<ValPto> ValPtos { get; set; } = new List<ValPto>();

    public virtual ICollection<Vfactor> Vfactors { get; set; } = new List<Vfactor>();

    public virtual ICollection<Vsubfact> Vsubfacts { get; set; } = new List<Vsubfact>();
}
