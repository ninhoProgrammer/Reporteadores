using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class RAtributo
{
    public short EnCodigo { get; set; }

    public string AtCampo { get; set; } = null!;

    public string AtTitulo { get; set; } = null!;

    public short AtTipo { get; set; }

    public short AtAncho { get; set; }

    public string AtMascara { get; set; } = null!;

    public short AtFiltro { get; set; }

    public string AtFiltroa { get; set; } = null!;

    public short AtTrango { get; set; }

    public short AtEntidad { get; set; }

    public short LvCodigo { get; set; }

    public string AtClaves { get; set; } = null!;

    public string AtDescrip { get; set; } = null!;

    public string AtTcorto { get; set; } = null!;

    public string AtSistema { get; set; } = null!;

    public short AtValorac { get; set; }

    public short AtTotal { get; set; }

    public string AtConfi { get; set; } = null!;

    public int Llave { get; set; }

    public string? AtActivo { get; set; }

    public short? AtVersion { get; set; }

    public short? UsCodigo { get; set; }

    public virtual REntidad EnCodigoNavigation { get; set; } = null!;
}
