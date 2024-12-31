using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class LiqMov
{
    public short LmAusenci { get; set; }

    public decimal LmBase { get; set; }

    public int CbCodigo { get; set; }

    public decimal LmCesVej { get; set; }

    public string LmClave { get; set; } = null!;

    public short LmDias { get; set; }

    public decimal LmEymDin { get; set; }

    public decimal LmEymEsp { get; set; }

    public decimal LmEymExc { get; set; }

    public decimal LmEymFij { get; set; }

    public DateTime LmFecha { get; set; }

    public decimal LmGuarder { get; set; }

    public decimal LmInfAmo { get; set; }

    public decimal LmInvVid { get; set; }

    public DateTime LmKarFec { get; set; }

    public string LmKarTip { get; set; } = null!;

    public decimal LmRetiro { get; set; }

    public decimal LmRiesgos { get; set; }

    public string LmTipo { get; set; } = null!;

    public string LsPatron { get; set; } = null!;

    public short LsYear { get; set; }

    public short LsMonth { get; set; }

    public decimal LmInfPat { get; set; }

    public short LsTipo { get; set; }

    public short LmIncapac { get; set; }

    public decimal LmEymespp { get; set; }

    public decimal LmEymexcp { get; set; }

    public decimal LmEymdinp { get; set; }

    public decimal LmInvvidp { get; set; }

    public decimal LmCesvejp { get; set; }

    public int Llave { get; set; }

    public virtual LiqEmp LiqEmp { get; set; } = null!;
}
