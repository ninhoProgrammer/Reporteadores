using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Antescur
{
    public int CbCodigo { get; set; }

    public short ArFolio { get; set; }

    public string ArCurso { get; set; } = null!;

    public DateTime ArFecha { get; set; }

    public string ArLugar { get; set; } = null!;

    public int Llave { get; set; }

    public virtual Colabora CbCodigoNavigation { get; set; } = null!;
}
