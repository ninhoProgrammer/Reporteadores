using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Ausencium
{
    public int CbCodigo { get; set; }

    public decimal AuDesTra { get; set; }

    public decimal AuDobles { get; set; }

    public decimal AuExtras { get; set; }

    public DateTime AuFecha { get; set; }

    public decimal AuHoras { get; set; }

    public decimal AuPerCg { get; set; }

    public decimal AuPerSg { get; set; }

    public decimal AuTardes { get; set; }

    public string AuTipo { get; set; } = null!;

    public short AuTipodia { get; set; }

    public string CbClasifi { get; set; } = null!;

    public string CbTurno { get; set; } = null!;

    public string CbPuesto { get; set; } = null!;

    public string HoCodigo { get; set; } = null!;

    public string CbNivel1 { get; set; } = null!;

    public string CbNivel2 { get; set; } = null!;

    public string CbNivel3 { get; set; } = null!;

    public string CbNivel4 { get; set; } = null!;

    public string CbNivel5 { get; set; } = null!;

    public string CbNivel6 { get; set; } = null!;

    public string CbNivel7 { get; set; } = null!;

    public string CbNivel8 { get; set; } = null!;

    public string CbNivel9 { get; set; } = null!;

    public decimal AuAutExt { get; set; }

    public decimal AuAutTra { get; set; }

    public string AuHorMan { get; set; } = null!;

    public short AuStatus { get; set; }

    public decimal AuNumExt { get; set; }

    public decimal AuTriples { get; set; }

    public short UsCodigo { get; set; }

    public short AuPosicio { get; set; }

    public decimal AuHorasck { get; set; }

    public short AuOut2eat { get; set; }

    public short PeYear { get; set; }

    public short PeTipo { get; set; }

    public short PeNumero { get; set; }

    public decimal AuHorasnt { get; set; }

    public decimal CbSalario { get; set; }

    public short AuStaFes { get; set; }

    public decimal? AuPreExt { get; set; }

    public int Llave { get; set; }

    public short? CbNomina { get; set; }

    public virtual Colabora CbCodigoNavigation { get; set; } = null!;

    public virtual ICollection<Checada> Checada { get; set; } = new List<Checada>();
}
