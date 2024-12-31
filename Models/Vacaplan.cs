using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Vacaplan
{
    public int CbCodigo { get; set; }

    public DateTime VpFecIni { get; set; }

    public DateTime VpFecFin { get; set; }

    public decimal VpDias { get; set; }

    public string VpSolCom { get; set; } = null!;

    public short VpSolUsr { get; set; }

    public DateTime VpSolFec { get; set; }

    public short VpStatus { get; set; }

    public string VpAutCom { get; set; } = null!;

    public short VpAutUsr { get; set; }

    public DateTime VpAutFec { get; set; }

    public short VpNomyear { get; set; }

    public short VpNomtipo { get; set; }

    public short VpNomnume { get; set; }

    public decimal VpSalAnt { get; set; }

    public decimal VpSalPro { get; set; }

    public string VpPagoUs { get; set; } = null!;

    public int Llave { get; set; }

    public virtual Colabora CbCodigoNavigation { get; set; } = null!;
}
