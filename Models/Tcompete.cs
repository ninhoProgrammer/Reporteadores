using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Tcompete
{
    public string TcCodigo { get; set; } = null!;

    public string TcDescrip { get; set; } = null!;

    public string TcIngles { get; set; } = null!;

    public decimal TcNumero { get; set; }

    public string TcTexto { get; set; } = null!;

    public short TcTipo { get; set; }

    public int Llave { get; set; }
}
