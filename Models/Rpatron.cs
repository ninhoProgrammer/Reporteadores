using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Rpatron
{
    public string TbCodigo { get; set; } = null!;

    public string TbElement { get; set; } = null!;

    public string TbIngles { get; set; } = null!;

    public decimal TbNumero { get; set; }

    public string TbTexto { get; set; } = null!;

    public string TbNumreg { get; set; } = null!;

    public short TbModulo { get; set; }

    public string? RsCodigo { get; set; }

    public int Llave { get; set; }

    public string? TbCalle { get; set; }

    public string? TbNumext { get; set; }

    public string? TbNumint { get; set; }

    public string? TbColonia { get; set; }

    public string? TbCiudad { get; set; }

    public string? TbEntidad { get; set; }

    public string? TbCodpost { get; set; }

    public string? TbTel { get; set; }

    public string? TbFax { get; set; }

    public string? TbEmail { get; set; }

    public string? TbWeb { get; set; }

    public short? TbClase { get; set; }

    public int? TbFracc { get; set; }

    public string? TbStyps { get; set; }

    public string TbSiem { get; set; } = null!;

    public string TbPlanpre { get; set; } = null!;

    public string TbPlanper { get; set; } = null!;

    public string TbPlanfol { get; set; } = null!;

    public virtual ICollection<Priesgo> Priesgos { get; set; } = new List<Priesgo>();

    public virtual Rsocial? RsCodigoNavigation { get; set; }
}
