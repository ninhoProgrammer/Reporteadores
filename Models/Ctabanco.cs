using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Ctabanco
{
    public string CtCodigo { get; set; } = null!;

    public string CtNumCta { get; set; } = null!;

    public string CtNombre { get; set; } = null!;

    public string CtBanco { get; set; } = null!;

    public decimal CtNumero { get; set; }

    public string CtTexto { get; set; } = null!;

    public string AhTipo { get; set; } = null!;

    public short CtStatus { get; set; }

    public short CtRepChk { get; set; }

    public short CtRepLiq { get; set; }

    public int Llave { get; set; }

    public virtual Tahorro AhTipoNavigation { get; set; } = null!;

    public virtual ICollection<CtaMov> CtaMovs { get; set; } = new List<CtaMov>();
}
