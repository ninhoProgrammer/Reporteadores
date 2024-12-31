using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Bitacora
{
    public short UsCodigo { get; set; }

    public DateTime BiFecha { get; set; }

    public string BiHora { get; set; } = null!;

    public short BiProcId { get; set; }

    public short BiTipo { get; set; }

    public int BiNumero { get; set; }

    public string BiTexto { get; set; } = null!;

    public int CbCodigo { get; set; }

    public string? BiData { get; set; }

    public short BiClase { get; set; }

    public DateTime BiFecMov { get; set; }

    public int Llave { get; set; }
}
