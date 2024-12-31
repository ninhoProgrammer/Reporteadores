using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Acceslog
{
    public int CbCodigo { get; set; }

    public DateTime AlFecha { get; set; }

    public string AlHora { get; set; } = null!;

    public string AlEntrada { get; set; } = null!;

    public string AlOkSist { get; set; } = null!;

    public string AlOkMan { get; set; } = null!;

    public DateTime AlOkFec { get; set; }

    public string AlOkHor { get; set; } = null!;

    public string AlComent { get; set; } = null!;

    public string AeCodigo { get; set; } = null!;

    public string AlCaseta { get; set; } = null!;

    public short UsCodigo { get; set; }

    public int Llave { get; set; }

    public virtual Colabora CbCodigoNavigation { get; set; } = null!;
}
