using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Tfija
{
    public short TfTabla { get; set; }

    public short TfCodigo { get; set; }

    public string TfDescrip { get; set; } = null!;
}
