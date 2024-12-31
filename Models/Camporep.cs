using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Camporep
{
    public short ReCodigo { get; set; }

    public short CrTipo { get; set; }

    public short CrPosicio { get; set; }

    public short CrClasifi { get; set; }

    public short CrSubpos { get; set; }

    public short CrTabla { get; set; }

    public string CrTitulo { get; set; } = null!;

    public string CrRequier { get; set; } = null!;

    public short CrCalc { get; set; }

    public string CrMascara { get; set; } = null!;

    public short CrAncho { get; set; }

    public short CrOper { get; set; }

    public short CrTfield { get; set; }

    public short CrShow { get; set; }

    public string CrDescrip { get; set; } = null!;

    public short CrColor { get; set; }

    public string CrFormula { get; set; } = null!;

    public string CrBold { get; set; } = null!;

    public string CrItalic { get; set; } = null!;

    public string CrSubraya { get; set; } = null!;

    public string CrStrike { get; set; } = null!;

    public short CrAlinea { get; set; }

    public int Llave { get; set; }

    public virtual Reporte ReCodigoNavigation { get; set; } = null!;
}
