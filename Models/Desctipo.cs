using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Desctipo
{
    public string DtCodigo { get; set; } = null!;

    public string DtNombre { get; set; } = null!;

    public string DtIngles { get; set; } = null!;

    public short DtOrden { get; set; }

    public decimal DtNumero { get; set; }

    public string DtTexto { get; set; } = null!;

    public int Llave { get; set; }

    public virtual ICollection<DescFld> DescFlds { get; set; } = new List<DescFld>();

    public virtual ICollection<DescPto> DescPtos { get; set; } = new List<DescPto>();
}
