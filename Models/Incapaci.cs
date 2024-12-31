using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Incapaci
{
    public int CbCodigo { get; set; }

    public DateTime InFecIni { get; set; }

    public string InComenta { get; set; } = null!;

    public short InDias { get; set; }

    public DateTime InFecFin { get; set; }

    public short InFin { get; set; }

    public string InNumero { get; set; } = null!;

    public decimal InTasaIp { get; set; }

    public DateTime InCaptura { get; set; }

    public string InTipo { get; set; } = null!;

    public short UsCodigo { get; set; }

    public short InMotivo { get; set; }

    public decimal InDiassub { get; set; }

    public short InNomyear { get; set; }

    public short InNomtipo { get; set; }

    public short InNomnume { get; set; }

    public DateTime InSuaIni { get; set; }

    public DateTime InSuaFin { get; set; }

    public int Llave { get; set; }

    public virtual Colabora CbCodigoNavigation { get; set; } = null!;
}
