using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Checada
{
    public int CbCodigo { get; set; }

    public DateTime AuFecha { get; set; }

    public short ChDescrip { get; set; }

    public string ChGlobal { get; set; } = null!;

    public string ChHAjus { get; set; } = null!;

    public string ChHReal { get; set; } = null!;

    public decimal ChHorDes { get; set; }

    public decimal ChHorExt { get; set; }

    public decimal ChHorOrd { get; set; }

    public string ChIgnorar { get; set; } = null!;

    public string ChReloj { get; set; } = null!;

    public string ChSistema { get; set; } = null!;

    public short ChTipo { get; set; }

    public short UsCodigo { get; set; }

    public short UsCodOk { get; set; }

    public short ChPosicio { get; set; }

    public string ChMotivo { get; set; } = null!;

    public int Llave { get; set; }

    public virtual Ausencium Ausencium { get; set; } = null!;
}
