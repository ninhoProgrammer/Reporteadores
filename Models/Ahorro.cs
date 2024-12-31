using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Ahorro
{
    public decimal AhAbonos { get; set; }

    public decimal AhCargos { get; set; }

    public DateTime AhFecha { get; set; }

    public string AhFormula { get; set; } = null!;

    public short AhNumero { get; set; }

    public decimal AhSaldoI { get; set; }

    public short AhStatus { get; set; }

    public decimal AhSaldo { get; set; }

    public string AhTipo { get; set; } = null!;

    public decimal AhTotal { get; set; }

    public short UsCodigo { get; set; }

    public int CbCodigo { get; set; }

    public string AhSubCta { get; set; } = null!;

    public int Llave { get; set; }

    public virtual ICollection<AcarAbo> AcarAbos { get; set; } = new List<AcarAbo>();

    public virtual Tahorro AhTipoNavigation { get; set; } = null!;

    public virtual Colabora CbCodigoNavigation { get; set; } = null!;
}
