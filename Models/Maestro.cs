using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Maestro
{
    public string MaCodigo { get; set; } = null!;

    public string MaNombre { get; set; } = null!;

    public string MaCedula { get; set; } = null!;

    public string MaRfc { get; set; } = null!;

    public decimal MaNumero { get; set; }

    public string MaTexto { get; set; } = null!;

    public string MaEmpresa { get; set; } = null!;

    public string MaDirecci { get; set; } = null!;

    public string MaCiudad { get; set; } = null!;

    public string MaTel { get; set; } = null!;

    public string MaActivo { get; set; } = null!;

    public byte[]? MaImagen { get; set; }

    public string PcCodigo { get; set; } = null!;

    public int Llave { get; set; }

    public short? MaTagente { get; set; }

    public string? MaNagente { get; set; }
}
