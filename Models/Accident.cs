using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Accident
{
    public int ExCodigo { get; set; }

    public DateTime AxFecha { get; set; }

    public DateTime AxFecReg { get; set; }

    public string AxCausa { get; set; } = null!;

    public string AxMotivo { get; set; } = null!;

    public string AxHora { get; set; } = null!;

    public string AxTipAcc { get; set; } = null!;

    public DateTime AxFecSus { get; set; }

    public string AxHorSus { get; set; } = null!;

    public string AxPerReg { get; set; } = null!;

    public short AxTipLes { get; set; }

    public string? AxDescrip { get; set; }

    public short AxAtendio { get; set; }

    public string AxObserva { get; set; } = null!;

    public string AxNumInc { get; set; } = null!;

    public short UsCodigo { get; set; }

    public short AxTipo { get; set; }

    public DateTime AxFecCom { get; set; }

    public string AxHorCom { get; set; } = null!;

    public string AxRiesgo { get; set; } = null!;

    public string AxIncapa { get; set; } = null!;

    public string AxDanMat { get; set; } = null!;

    public string? AxInfAcc { get; set; }

    public string? AxInfTes { get; set; }

    public string? AxInfSup { get; set; }

    public int AxNumTes { get; set; }

    public string AxNumero { get; set; } = null!;

    public int Llave { get; set; }

    public virtual Expedien ExCodigoNavigation { get; set; } = null!;
}
