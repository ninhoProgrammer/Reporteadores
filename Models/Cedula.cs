using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Cedula
{
    public int CeFolio { get; set; }

    public string WoNumber { get; set; } = null!;

    public string ArCodigo { get; set; } = null!;

    public string OpNumber { get; set; } = null!;

    public string CeArea { get; set; } = null!;

    public short CeTipo { get; set; }

    public DateTime CeFecha { get; set; }

    public string CeHora { get; set; } = null!;

    public short CeStatus { get; set; }

    public string CeMod1 { get; set; } = null!;

    public string CeMod2 { get; set; } = null!;

    public string CeMod3 { get; set; } = null!;

    public string CeTmuerto { get; set; } = null!;

    public decimal CePiezas { get; set; }

    public string CeComenta { get; set; } = null!;

    public string CeMulti { get; set; } = null!;

    public decimal CeTiempo { get; set; }

    public short UsCodigo { get; set; }

    public int Llave { get; set; }

    public virtual ICollection<CedEmp> CedEmps { get; set; } = new List<CedEmp>();

    public virtual ICollection<CedWord> CedWords { get; set; } = new List<CedWord>();
}
