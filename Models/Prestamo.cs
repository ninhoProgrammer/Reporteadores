using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Prestamo
{
    public decimal PrAbonos { get; set; }

    public decimal PrCargos { get; set; }

    public DateTime PrFecha { get; set; }

    public string PrFormula { get; set; } = null!;

    public decimal PrMonto { get; set; }

    public short PrNumero { get; set; }

    public string PrReferen { get; set; } = null!;

    public decimal PrSaldoI { get; set; }

    public short PrStatus { get; set; }

    public string PrTipo { get; set; } = null!;

    public decimal PrTotal { get; set; }

    public decimal PrSaldo { get; set; }

    public short UsCodigo { get; set; }

    public int CbCodigo { get; set; }

    public string PrSubCta { get; set; } = null!;

    public decimal PrMontoS { get; set; }

    public decimal PrInteres { get; set; }

    public decimal PrTasa { get; set; }

    public short PrMeses { get; set; }

    public short PrPagos { get; set; }

    public decimal PrPagPer { get; set; }

    public int Llave { get; set; }

    public string? PrObserva { get; set; }

    public virtual Colabora CbCodigoNavigation { get; set; } = null!;

    public virtual ICollection<PcarAbo> PcarAbos { get; set; } = new List<PcarAbo>();

    public virtual Tprestum PrTipoNavigation { get; set; } = null!;
}
