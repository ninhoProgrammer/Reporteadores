using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Pariente
{
    public int CbCodigo { get; set; }

    public short PaRelacio { get; set; }

    public short PaFolio { get; set; }

    public string PaNombre { get; set; } = null!;

    public string PaSexo { get; set; } = null!;

    public DateTime PaFecNac { get; set; }

    public int PaTrabaja { get; set; }

    public decimal PaNumero { get; set; }

    public string PaTexto { get; set; } = null!;

    public int Llave { get; set; }

    public virtual Colabora CbCodigoNavigation { get; set; } = null!;
}
