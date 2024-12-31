using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class VTurnoAbg
{
    public string TuCodigo { get; set; } = null!;

    public string TuDescrip { get; set; } = null!;

    public short TuDias { get; set; }

    public decimal TuDobles { get; set; }

    public decimal TuDomingo { get; set; }

    public string TuFestivo { get; set; } = null!;

    public string TuHor1 { get; set; } = null!;

    public string TuHor2 { get; set; } = null!;

    public string TuHor3 { get; set; } = null!;

    public string TuHor4 { get; set; } = null!;

    public string TuHor5 { get; set; } = null!;

    public string TuHor6 { get; set; } = null!;

    public string TuHor7 { get; set; } = null!;

    public short TuHorario { get; set; }

    public decimal TuJornada { get; set; }

    public short TuNomina { get; set; }

    public DateTime TuRitIni { get; set; }

    public string TuRitPat { get; set; } = null!;

    public short TuTip1 { get; set; }

    public short TuTip2 { get; set; }

    public short TuTip3 { get; set; }

    public short TuTip4 { get; set; }

    public short TuTip5 { get; set; }

    public short TuTip6 { get; set; }

    public short TuTip7 { get; set; }

    public short TuTipJor { get; set; }

    public string TuIngles { get; set; } = null!;

    public string TuTexto { get; set; } = null!;

    public decimal TuNumero { get; set; }

    public string TuHorFes { get; set; } = null!;

    public decimal TuVacaHa { get; set; }

    public decimal TuVacaSa { get; set; }

    public decimal TuVacaDe { get; set; }

    public string TuSubCta { get; set; } = null!;

    public decimal TuDiasBa { get; set; }

    public string TuActivo { get; set; } = null!;

    public int Llave { get; set; }

    public short? TuTipJt { get; set; }

    public int? TuDiasOrd { get; set; }
}
