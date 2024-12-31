using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Tperiodo
{
    public short TpTipo { get; set; }

    public string TpNombre { get; set; } = null!;

    public string TpDescrip { get; set; } = null!;

    public decimal TpDias { get; set; }

    public decimal TpDias7 { get; set; }

    public decimal TpHoras { get; set; }

    public short TpDiasBt { get; set; }

    public string TpDiasEv { get; set; } = null!;

    public string TpHorasjo { get; set; } = null!;

    public int Llave { get; set; }
}
