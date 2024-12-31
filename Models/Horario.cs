using System;
using System.Collections.Generic;

namespace Reporteadores.Models;

public partial class Horario
{
    public string HoCodigo { get; set; } = null!;

    public string HoAddEat { get; set; } = null!;

    public string HoChkEat { get; set; } = null!;

    public short HoComer { get; set; }

    public string HoDescrip { get; set; } = null!;

    public decimal HoDobles { get; set; }

    public decimal HoExtFij { get; set; }

    public string HoIgnEat { get; set; } = null!;

    public string HoInEat { get; set; } = null!;

    public short HoInTard { get; set; }

    public short HoInTemp { get; set; }

    public string HoIntime { get; set; } = null!;

    public string HoLastout { get; set; } = null!;

    public short HoMinEat { get; set; }

    public decimal HoJornada { get; set; }

    public short HoOuTard { get; set; }

    public short HoOuTemp { get; set; }

    public string HoOutEat { get; set; } = null!;

    public string HoOuttime { get; set; } = null!;

    public short HoTipo { get; set; }

    public short HoExtCom { get; set; }

    public short HoExtMin { get; set; }

    public string HoOutBrk { get; set; } = null!;

    public string HoInBrk { get; set; } = null!;

    public string HoActivo { get; set; } = null!;

    public string? HoPares { get; set; }

    public string? HoTexto { get; set; }

    public string? HoIngles { get; set; }

    public decimal? HoNumero { get; set; }

    public int Llave { get; set; }
}
