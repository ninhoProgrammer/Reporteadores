using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Rsocial
{
    public string RsCodigo { get; set; } = null!;

    public string RsNombre { get; set; } = null!;

    public string RsCalle { get; set; } = null!;

    public string RsNumext { get; set; } = null!;

    public string RsNumint { get; set; } = null!;

    public string RsColonia { get; set; } = null!;

    public string RsCiudad { get; set; } = null!;

    public string RsEntidad { get; set; } = null!;

    public string RsCodpost { get; set; } = null!;

    public string RsTel { get; set; } = null!;

    public string RsFax { get; set; } = null!;

    public string RsEmail { get; set; } = null!;

    public string RsWeb { get; set; } = null!;

    public string RsRfc { get; set; } = null!;

    public string RsInfo { get; set; } = null!;

    public string RsGuia { get; set; } = null!;

    public string RsRlegal { get; set; } = null!;

    public decimal RsSubsid { get; set; }

    public string RsGiro { get; set; } = null!;

    public string RsStps { get; set; } = null!;

    public string RsStpsR1 { get; set; } = null!;

    public string RsStpsR2 { get; set; } = null!;

    public decimal RsNumero { get; set; }

    public string RsTexto { get; set; } = null!;

    public int Llave { get; set; }

    public string? RsCurp { get; set; }

    public string? RsRlRfc { get; set; }

    public string? RsRlCurp { get; set; }

    public string? RsSello { get; set; }

    public string? RsKeyPr { get; set; }

    public string? RsKeyPu { get; set; }

    public string? RsCert { get; set; }

    public DateTime? RsValIni { get; set; }

    public DateTime? RsValFin { get; set; }

    public string? RsSerial { get; set; }

    public string? RsIssueto { get; set; }

    public string? RsIssueby { get; set; }

    public virtual ICollection<Rpatron> Rpatrons { get; set; } = new List<Rpatron>();
}
