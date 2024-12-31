using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class REntidad
{
    public short EnCodigo { get; set; }

    public string EnTitulo { get; set; } = null!;

    public string EnTabla { get; set; } = null!;

    public string EnDescrip { get; set; } = null!;

    public string EnPrimary { get; set; } = null!;

    public string EnAtdesc { get; set; } = null!;

    public short EnAlias { get; set; }

    public int Llave { get; set; }

    public string? EnActivo { get; set; }

    public short? EnVersion { get; set; }

    public short? UsCodigo { get; set; }

    public virtual ICollection<RAtributo> RAtributos { get; set; } = new List<RAtributo>();

    public virtual ICollection<RDefault> RDefaults { get; set; } = new List<RDefault>();

    public virtual ICollection<RFiltro> RFiltros { get; set; } = new List<RFiltro>();

    public virtual ICollection<ROrden> ROrdens { get; set; } = new List<ROrden>();

    public virtual ICollection<RRelacion> RRelacions { get; set; } = new List<RRelacion>();
}
