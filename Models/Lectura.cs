using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Lectura
{
    public int CbCodigo { get; set; }

    public DateTime LxFecha { get; set; }

    public string LxHora { get; set; } = null!;

    public string LxWorder { get; set; } = null!;

    public string LxOpera { get; set; } = null!;

    public decimal LxPiezas { get; set; }

    public short LxStatus { get; set; }

    public string LxModula1 { get; set; } = null!;

    public string LxModula2 { get; set; } = null!;

    public string LxModula3 { get; set; } = null!;

    public string LxTmuerto { get; set; } = null!;

    public string LxNumero { get; set; } = null!;

    public string LxLinxId { get; set; } = null!;

    public short LxFolio { get; set; }

    public int Llave { get; set; }

    public virtual Colabora CbCodigoNavigation { get; set; } = null!;
}
