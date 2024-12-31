using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Sesion
{
    public int SeFolio { get; set; }

    public string CuCodigo { get; set; } = null!;

    public string MaCodigo { get; set; } = null!;

    public string SeLugar { get; set; } = null!;

    public DateTime SeFecIni { get; set; }

    public string SeHorIni { get; set; } = null!;

    public DateTime SeFecFin { get; set; }

    public decimal SeHoras { get; set; }

    public string SeHorFin { get; set; } = null!;

    public short SeCupo { get; set; }

    public decimal SeCosto1 { get; set; }

    public decimal SeCosto2 { get; set; }

    public decimal SeCosto3 { get; set; }

    public string SeComenta { get; set; } = null!;

    public string SeRevisio { get; set; } = null!;

    public short SeStatus { get; set; }

    public short? UsCodigo { get; set; }

    public int Llave { get; set; }

    public string? SeEst { get; set; }

    public virtual ICollection<Inscrito> Inscritos { get; set; } = new List<Inscrito>();
}
