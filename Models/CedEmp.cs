using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class CedEmp
{
    public int CeFolio { get; set; }

    public int CbCodigo { get; set; }

    public short CePosicio { get; set; }

    public string CbPuesto { get; set; } = null!;

    public int Llave { get; set; }

    public virtual Cedula CeFolioNavigation { get; set; } = null!;
}
