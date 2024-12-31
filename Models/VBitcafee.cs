using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class VBitcafee
{
    public int BcFolio { get; set; }

    public int CbCodigo { get; set; }

    public int IvCodigo { get; set; }

    public string BcEmpresa { get; set; } = null!;

    public string BcCredenc { get; set; } = null!;

    public DateTime BcFecha { get; set; }

    public string BcHora { get; set; } = null!;

    public string BcReloj { get; set; } = null!;

    public string BcTipo { get; set; } = null!;

    public short BcComidas { get; set; }

    public short BcExtras { get; set; }

    public string BcRegExt { get; set; } = null!;

    public string BcManual { get; set; } = null!;

    public short ClCodigo { get; set; }

    public short BcTgafete { get; set; }

    public short BcTiempo { get; set; }

    public short BcStatus { get; set; }

    public string BcMensaje { get; set; } = null!;

    public string BcRespues { get; set; } = null!;

    public string BcChecada { get; set; } = null!;
}
