using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class CedInsp
{
    public int CiFolio { get; set; }

    public string CiArea { get; set; } = null!;

    public int CeFolio { get; set; }

    public string WoNumber { get; set; } = null!;

    public string ArCodigo { get; set; } = null!;

    public DateTime CiFecha { get; set; }

    public string CiHora { get; set; } = null!;

    public short UsCodigo { get; set; }

    public short CiTipo { get; set; }

    public short CiResult { get; set; }

    public string CiComenta { get; set; } = null!;

    public string? CiObserva { get; set; }

    public decimal CiTamlote { get; set; }

    public decimal CiMuestra { get; set; }

    public short CiTiempo { get; set; }

    public decimal CiNumero1 { get; set; }

    public decimal CiNumero2 { get; set; }

    public int Llave { get; set; }

    public virtual ICollection<Defecto> Defectos { get; set; } = new List<Defecto>();
}
