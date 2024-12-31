using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Dimensio
{
    public string DmCodigo { get; set; } = null!;

    public string DmDescrip { get; set; } = null!;

    public string DmIngles { get; set; } = null!;

    public decimal DmNumero { get; set; }

    public string DmTexto { get; set; } = null!;

    public int Llave { get; set; }

    public virtual ICollection<NivDime> NivDimes { get; set; } = new List<NivDime>();

    public virtual ICollection<PtoDime> PtoDimes { get; set; } = new List<PtoDime>();
}
