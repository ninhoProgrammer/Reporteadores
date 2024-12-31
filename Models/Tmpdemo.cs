using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Tmpdemo
{
    public short TdUser { get; set; }

    public string TdGrupo { get; set; } = null!;

    public string TdDescrip { get; set; } = null!;

    public int TdEmpl { get; set; }

    public int TdHombres { get; set; }

    public int TdMujeres { get; set; }

    public int TdFamilia { get; set; }

    public int TdMica { get; set; }

    public int TdEstudio { get; set; }

    public int TdIdioma { get; set; }

    public int TdTabula { get; set; }

    public decimal TdEdadmin { get; set; }

    public decimal TdEdadmax { get; set; }

    public decimal TdEdadavg { get; set; }

    public decimal TdAntmin { get; set; }

    public decimal TdAntmax { get; set; }

    public decimal TdAntavg { get; set; }

    public decimal TdResmin { get; set; }

    public decimal TdResmax { get; set; }

    public decimal TdResavg { get; set; }

    public decimal TdHijomin { get; set; }

    public decimal TdHijomax { get; set; }

    public decimal TdHijoavg { get; set; }

    public decimal TdSalmin { get; set; }

    public decimal TdSalmax { get; set; }

    public decimal TdSalavg { get; set; }

    public decimal TdDiasmin { get; set; }

    public decimal TdDiasmax { get; set; }

    public decimal TdDiasavg { get; set; }

    public int TdEmpmin { get; set; }

    public int TdEmpmax { get; set; }
}
