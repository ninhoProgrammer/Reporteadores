using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Vacacion
{
    public int CbCodigo { get; set; }

    public DateTime VaFecIni { get; set; }

    public short VaTipo { get; set; }

    public DateTime VaFecFin { get; set; }

    public string VaComenta { get; set; } = null!;

    public DateTime VaCaptura { get; set; }

    public short UsCodigo { get; set; }

    public decimal VaDPago { get; set; }

    public decimal VaPago { get; set; }

    public decimal VaSPago { get; set; }

    public decimal VaDGozo { get; set; }

    public decimal VaGozo { get; set; }

    public decimal VaSGozo { get; set; }

    public decimal CbSalario { get; set; }

    public string CbTablass { get; set; } = null!;

    public short VaNomyear { get; set; }

    public short VaNomtipo { get; set; }

    public short VaNomnume { get; set; }

    public short VaYear { get; set; }

    public decimal VaMonto { get; set; }

    public decimal VaSeven { get; set; }

    public decimal VaTasaPr { get; set; }

    public decimal VaPrima { get; set; }

    public decimal VaOtros { get; set; }

    public decimal VaTotal { get; set; }

    public string VaPeriodo { get; set; } = null!;

    public string VaGlobal { get; set; } = null!;

    public decimal VaDPrima { get; set; }

    public decimal VaPPrima { get; set; }

    public decimal VaSPrima { get; set; }

    public int Llave { get; set; }

    public string? VaAjuste { get; set; }

    public virtual Colabora CbCodigoNavigation { get; set; } = null!;
}
