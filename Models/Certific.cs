using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Certific
{
    public string CiCodigo { get; set; } = null!;

    public string CiNombre { get; set; } = null!;

    public string CiResumen { get; set; } = null!;

    public string? CiDetalle { get; set; }

    public string CiIngles { get; set; } = null!;

    public decimal CiNumero { get; set; }

    public string CiTexto { get; set; } = null!;

    public short CiRenovar { get; set; }

    public string CiActivo { get; set; } = null!;

    public int Llave { get; set; }

    public virtual ICollection<KarCert> KarCerts { get; set; } = new List<KarCert>();

    public virtual ICollection<PtoCert> PtoCerts { get; set; } = new List<PtoCert>();
}
