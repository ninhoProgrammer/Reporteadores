using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Plaza
{
    public int PlFolio { get; set; }

    public short PlOrden { get; set; }

    public string PlCodigo { get; set; } = null!;

    public string PlNombre { get; set; } = null!;

    public string PlIngles { get; set; } = null!;

    public decimal PlNumero { get; set; }

    public string PlTexto { get; set; } = null!;

    public int PlReporta { get; set; }

    public short PlTipo { get; set; }

    public short PlTirep { get; set; }

    public DateTime PlFecIni { get; set; }

    public DateTime PlFecFin { get; set; }

    public string PlSubCta { get; set; } = null!;

    public int CbCodigo { get; set; }

    public string PuCodigo { get; set; } = null!;

    public string PlClasifi { get; set; } = null!;

    public string PlTurno { get; set; } = null!;

    public string PlPatron { get; set; } = null!;

    public string PlNivel0 { get; set; } = null!;

    public string PlNivel1 { get; set; } = null!;

    public string PlNivel2 { get; set; } = null!;

    public string PlNivel3 { get; set; } = null!;

    public string PlNivel4 { get; set; } = null!;

    public string PlNivel5 { get; set; } = null!;

    public string PlNivel6 { get; set; } = null!;

    public string PlNivel7 { get; set; } = null!;

    public string PlNivel8 { get; set; } = null!;

    public string PlNivel9 { get; set; } = null!;

    public string PlContrat { get; set; } = null!;

    public string PlAutosal { get; set; } = null!;

    public decimal PlSalario { get; set; }

    public decimal PlPerVar { get; set; }

    public string PlTablass { get; set; } = null!;

    public string PlZonaGe { get; set; } = null!;

    public string PlCheca { get; set; } = null!;

    public string PlArea { get; set; } = null!;

    public short PlNomina { get; set; }

    public virtual Puesto PuCodigoNavigation { get; set; } = null!;
}
