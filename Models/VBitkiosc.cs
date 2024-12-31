using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class VBitkiosc
{
    public int CbCodigo { get; set; }

    public string CmCodigo { get; set; } = null!;

    public DateTime BiFecha { get; set; }

    public string BiHora { get; set; } = null!;

    public short BiTipo { get; set; }

    public short BiAccion { get; set; }

    public int BiNumero { get; set; }

    public string BiTexto { get; set; } = null!;

    public string BiUbica { get; set; } = null!;

    public string BiKiosco { get; set; } = null!;

    public DateTime BiFecMov { get; set; }

    public DateTime BiFecHor { get; set; }
}
