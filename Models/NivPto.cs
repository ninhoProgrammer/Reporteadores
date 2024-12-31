using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class NivPto
{
    public string NpCodigo { get; set; } = null!;

    public string NpDescrip { get; set; } = null!;

    public string NpIngles { get; set; } = null!;

    public decimal NpNumero { get; set; }

    public string NpTexto { get; set; } = null!;

    public string NpActitud { get; set; } = null!;

    public string? NpDetalle { get; set; }

    public int Llave { get; set; }

    public virtual ICollection<NivDime> NivDimes { get; set; } = new List<NivDime>();
}
