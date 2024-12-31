using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Evento
{
    public string EvActivo { get; set; } = null!;

    public string EvAlta { get; set; } = null!;

    public short EvAntFin { get; set; }

    public short EvAntIni { get; set; }

    public string EvAutosal { get; set; } = null!;

    public string EvBaja { get; set; } = null!;

    public string EvClasifi { get; set; } = null!;

    public string EvCodigo { get; set; } = null!;

    public string EvContrat { get; set; } = null!;

    public string EvDescrip { get; set; } = null!;

    public DateTime EvFecBss { get; set; }

    public string EvFiltro { get; set; } = null!;

    public string EvKardex { get; set; } = null!;

    public string EvMotBaj { get; set; } = null!;

    public string EvOtras1 { get; set; } = null!;

    public string EvOtras2 { get; set; } = null!;

    public string EvOtras3 { get; set; } = null!;

    public string EvOtras4 { get; set; } = null!;

    public string EvOtras5 { get; set; } = null!;

    public string EvPatron { get; set; } = null!;

    public short EvNomnume { get; set; }

    public short EvPriorid { get; set; }

    public string EvPuesto { get; set; } = null!;

    public string EvQuery { get; set; } = null!;

    public string EvSalario { get; set; } = null!;

    public string EvTablass { get; set; } = null!;

    public string EvNivel1 { get; set; } = null!;

    public string EvNivel2 { get; set; } = null!;

    public string EvNivel3 { get; set; } = null!;

    public string EvNivel4 { get; set; } = null!;

    public string EvNivel5 { get; set; } = null!;

    public string EvNivel6 { get; set; } = null!;

    public string EvNivel7 { get; set; } = null!;

    public string EvNivel8 { get; set; } = null!;

    public string EvNivel9 { get; set; } = null!;

    public string EvTurno { get; set; } = null!;

    public short EvIncluye { get; set; }

    public short EvNomtipo { get; set; }

    public short EvNomyear { get; set; }

    public string EvTabula { get; set; } = null!;

    public string EvMAntig { get; set; } = null!;

    public string EvFecCon { get; set; } = null!;

    public string EvCampo { get; set; } = null!;

    public string EvFormula { get; set; } = null!;

    public int Llave { get; set; }

    public string? EvMSvac { get; set; }

    public short? EvMTvac { get; set; }
}
