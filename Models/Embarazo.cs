using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Embarazo
{
    public int ExCodigo { get; set; }

    public DateTime EmFecUm { get; set; }

    public DateTime EmFecPp { get; set; }

    public string EmFinal { get; set; } = null!;

    public DateTime EmFecFin { get; set; }

    public short EmTermino { get; set; }

    public string EmNormal { get; set; } = null!;

    public string EmMortal { get; set; } = null!;

    public string EmComenta { get; set; } = null!;

    public DateTime EmPrenat { get; set; }

    public DateTime EmPosnat { get; set; }

    public string EmRiesgo { get; set; } = null!;

    public DateTime EmIncIni { get; set; }

    public DateTime EmIncFin { get; set; }

    public string EmObsRie { get; set; } = null!;

    public short UsCodigo { get; set; }

    public int Llave { get; set; }

    public virtual Expedien ExCodigoNavigation { get; set; } = null!;
}
